using Axie_Scholarship.Logs;
using Axie_Scholarship.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Helpers
{
    public class ExcelGenerator
    {
        DataGridViewSelectedRowCollection rows;
        Scholar scholar;
        CashOut cashOut = null;
        DataTable allRewards = null;
        string minDate;
        string maxDate;
        int row = 2;
        bool forCashOut = false;

        Color darkGreen = Color.DarkSeaGreen;
        public ExcelGenerator(DataGridViewSelectedRowCollection rows, Scholar scholar, DataTable allRewards, bool forCashOut = false, CashOut cashOut = null)
        {
            this.rows = rows;
            this.scholar = scholar;
            this.forCashOut = forCashOut;
            this.cashOut = cashOut;
            this.allRewards = allRewards;
            GetMinAndMaxDate();
        }

        private void GetMinAndMaxDate()
        {
            int index = 0;
            foreach (DataGridViewRow item in rows)
            {
                if (index == 0)
                {
                    minDate = item.Cells[3].Value.ToString();
                    maxDate = item.Cells[3].Value.ToString();
                    
                    index++;
                    continue;
                }
                else
                {
                    if (Convert.ToDateTime(minDate) > Convert.ToDateTime(item.Cells[3].Value))
                    {
                        minDate = item.Cells[3].Value.ToString();
                    }

                    if (Convert.ToDateTime(maxDate) < Convert.ToDateTime(item.Cells[3].Value))
                    {
                        maxDate = item.Cells[3].Value.ToString();
                    }
                }
            }
        }

        public void LoadExcel()
        {
            
            string url = "";
            string restOfName = "";

            if (forCashOut)
            {
                url = "C:\\Axie Scholarship\\" + scholar.ScholarName + "\\Cash Out\\";
                restOfName = minDate + "_" + maxDate + "_" + "Cash-Out";
            }
            else
            {
                url = "C:\\Axie Scholarship\\" + scholar.ScholarName + "\\";
                restOfName = minDate + "_" + maxDate;
            }
            
            Directory.CreateDirectory(url);

            string filename = scholar.ScholarName + "_" + restOfName + ".xlsx";

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = null;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = null;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            object misValue = System.Reflection.Missing.Value;

            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Range["A1", "Z100"].NumberFormat = "@";

                xlWorkSheet = GenerateColumns(xlWorkSheet);
                xlWorkSheet = GenerateRows(xlWorkSheet);
                xlWorkSheet = GenerateAdditionalDetails(xlWorkSheet);
                xlWorkSheet = DetermineMissingDates(xlWorkSheet);

                xlWorkSheet.Range["A1", "Z100"].EntireColumn.AutoFit();
                xlWorkSheet.Range["A1", "Z100"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A1"].Font.Bold = true;


                //xlWorkBook.SaveAs(url + filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.SaveAs(url + filename);

                MessageBox.Show("Excel file created! You can find the file at "+ url + filename, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);

            }
            finally
            {

                Release(xlWorkBook, xlWorkSheet, xlApp);

            }
        }

        private Microsoft.Office.Interop.Excel.Worksheet DetermineMissingDates(Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet)
        {
            try
            {
                var start = Convert.ToDateTime(minDate);
                var end = Convert.ToDateTime(maxDate);
                var currLoopDate = start;
                var dgv = new DataGridView();
                var isFirstTry = true;
                int index = 2;

                while (currLoopDate.Date < end.Date)
                {
                    // check if current loop date is in list of rows selected then populate excel cell
                    var exist = rows.Cast<DataGridViewRow>().Where(x => Convert.ToDateTime(x.Cells[3].Value) == currLoopDate).ToList();
                    if (exist.Count == 0)
                    {
                        if (isFirstTry)
                        {
                            xlWorkSheet.Cells[row + index, 10] = "Dates NOT on this list";
                            xlWorkSheet.Cells[row + index, 10].Font.Bold = true;
                            isFirstTry = false;
                        }
                        index++;
                        xlWorkSheet.Cells[row + index, 10] = currLoopDate.ToShortDateString();
                    }
                    currLoopDate = currLoopDate.Date.AddDays(1);
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }

            return xlWorkSheet;
        }

        private Microsoft.Office.Interop.Excel.Worksheet GenerateAdditionalDetails(Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet)
        {
            try
            {
                int share = scholar.ScholarCut;
                xlWorkSheet.Cells[7, 10] = "Share:";
                xlWorkSheet.Cells[8, 10] = "Total SLP Earned:";

                xlWorkSheet.Cells[7, 11] = share.ToString() + "%";
                
                if (forCashOut)
                {
                    xlWorkSheet.Cells[9, 10] = "Adjusted SLP Value:";
                    xlWorkSheet.Cells[10, 10] = "Total SLP you earned w/ deductions:";
                    xlWorkSheet.Cells[11, 10] = "SLP Value:";
                    xlWorkSheet.Cells[12, 10] = "Total Amount you earned:";

                    if (!cashOut.IsSlpCashOut)
                    {
                        xlWorkSheet.Cells[8, 11] = cashOut.TotalSLP - (cashOut.ExtraSLP);
                        xlWorkSheet.Cells[8, 12] = "Bonus SLP:  " + (cashOut.ExtraSLP).ToString();
                        xlWorkSheet.Cells[11, 11] = cashOut.SLPValue.ToString();
                        xlWorkSheet.Cells[12, 11] = "Php " + cashOut.AmountReceived.ToString();
                        xlWorkSheet.Cells[13, 10] = "Total SLP for Transfer: ";
                        xlWorkSheet.Cells[13, 11] = scholar.SLPToTransfer.ToString();
                        xlWorkSheet.Cells[14, 10] = "Total Bonus SLP Balance: ";
                        xlWorkSheet.Cells[14, 11] = cashOut.SLPBalance.ToString();

                        xlWorkSheet.Cells[13, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                        xlWorkSheet.Cells[13, 10].Font.Bold = true;
                        xlWorkSheet.Cells[13, 11].Font.Bold = true;
                    }
                    else
                    {
                        xlWorkSheet.Cells[8, 11] = cashOut.TotalSLP;
                        xlWorkSheet.Cells[11, 11] = "   N/A   ";
                        xlWorkSheet.Cells[12, 11] = "   N/A   ";
                        xlWorkSheet.Cells[16, 10] = "Total SLP for Transfer: ";
                        xlWorkSheet.Cells[16, 11] = scholar.SLPToTransfer.ToString();
                        xlWorkSheet.Cells[17, 10] = "Bonus SLP Earned: ";
                        xlWorkSheet.Cells[17, 11] = (cashOut.ExtraSLP).ToString();
                        xlWorkSheet.Cells[18, 10] = "Total Bonus SLP Balance: ";
                        xlWorkSheet.Cells[18, 11] = cashOut.SLPBalance.ToString();
                        
                        xlWorkSheet.Cells[16, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                        xlWorkSheet.Cells[17, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                        xlWorkSheet.Cells[18, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                        xlWorkSheet.Cells[18, 10].Font.Bold = true;
                        xlWorkSheet.Cells[18, 11].Font.Bold = true;
                        xlWorkSheet.Cells[16, 10].Font.Bold = true;
                        xlWorkSheet.Cells[16, 11].Font.Bold = true;

                    }
                    xlWorkSheet.Cells[9, 11] = cashOut.TotalSLP;
                    xlWorkSheet.Cells[10, 11] = cashOut.ScholarSLP;

                    xlWorkSheet.Cells[10, 10].Font.Bold = true;
                    xlWorkSheet.Cells[10, 11].Font.Bold = true;
                    xlWorkSheet.Cells[12, 10].Font.Bold = true;
                    xlWorkSheet.Cells[12, 11].Font.Bold = true;

                    xlWorkSheet.Cells[10, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                    xlWorkSheet.Cells[11, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                    xlWorkSheet.Cells[12, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);

                    // list of bonuses
                    xlWorkSheet.Cells[7, 14] = "List of Bonuses/Penalties";
                    xlWorkSheet.Cells[7, 14].Font.Bold = true;
                    xlWorkSheet.Range["N7", "P7"].Merge();
                    xlWorkSheet.Cells[8, 14] = "SLP Amount";
                    xlWorkSheet.Cells[8, 15] = "Date Acquired";
                    xlWorkSheet.Cells[8, 16] = "Reason";

                    // rewards
                    int rewardsRow = 8;
                    if (allRewards != null)
                    {
                        foreach (DataRow row in allRewards.Rows)
                        {
                            rewardsRow++;
                            xlWorkSheet.Cells[rewardsRow, 14] = row[0];
                            xlWorkSheet.Cells[rewardsRow, 15] = row[1];
                            xlWorkSheet.Cells[rewardsRow, 16] = row[2];
                        }
                    }

                    row = 13;
                }
                else
                {
                    xlWorkSheet.Cells[9, 10] = "SLP you earned:";
                    int total = 0;
                    // compute manually total slp
                    foreach (DataGridViewRow row in rows)
                    {
                        total += Convert.ToInt32(row.Cells[2].Value);
                    }

                    xlWorkSheet.Cells[8, 11] = total;
                    xlWorkSheet.Cells[9, 11] = total * (Convert.ToDecimal(share) /100);

                    xlWorkSheet.Cells[9, 11].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
                    row = 9;
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }

            return xlWorkSheet;
        }

        private Microsoft.Office.Interop.Excel.Worksheet GenerateRows(Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet)
        {
            try
            {
                row = 2;
                string val = "";

                foreach (DataGridViewRow item in rows)
                {
                    xlWorkSheet.Cells[row, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);

                    if (forCashOut) val = "Yes";
                    else
                    {
                        if (Convert.ToBoolean(item.Cells["Cash Out"].Value))
                        {
                            val = "Yes";
                        }
                        else val = "No";
                    }
                    

                    xlWorkSheet.Cells[row, 1] = item.Cells["Earned SLP"].Value;
                    xlWorkSheet.Cells[row, 2] = item.Cells["Date Earned"].Value;

                    if (item.Cells["Record"].Value.ToString() != "0-0-0")
                    {
                        xlWorkSheet.Cells[row, 3] = item.Cells["Record"].Value.ToString();
                    } else xlWorkSheet.Cells[row, 3] = "N/A";

                    if (item.Cells["MMR"].Value.ToString() != "0")
                    {
                        xlWorkSheet.Cells[row, 4] = item.Cells["MMR"].Value.ToString();
                    } else xlWorkSheet.Cells[row, 4] = "N/A";

                    if (item.Cells["SLP End"].Value.ToString() == "0")
                    {
                        xlWorkSheet.Cells[row, 5] = "N/A";
                    }
                    else xlWorkSheet.Cells[row, 5] = item.Cells["SLP End"].Value;

                    if (item.Cells["SLP Start"].Value.ToString() == "0")
                    {
                        xlWorkSheet.Cells[row, 6] = "N/A";
                    }
                    else xlWorkSheet.Cells[row, 6] = item.Cells["SLP Start"].Value;

                    xlWorkSheet.Cells[row, 7] = val;

                    row++;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                
            }

            return xlWorkSheet;
        }

        private Microsoft.Office.Interop.Excel.Worksheet GenerateColumns(Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet)
        {
            try
            {
                xlWorkSheet.Cells[1, 1] = "SLP Earned";
                xlWorkSheet.Cells[1, 2] = "Date Played";
                xlWorkSheet.Cells[1, 3] = "PVP Record";
                xlWorkSheet.Cells[1, 4] = "MMR";
                xlWorkSheet.Cells[1, 5] = "SLP End of Day";
                xlWorkSheet.Cells[1, 6] = "SLP Start of Day";
                xlWorkSheet.Cells[1, 7] = "Is Cashed Out?";

                xlWorkSheet.Cells[1, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(darkGreen);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }

            return xlWorkSheet;
        }

        private void Release(Microsoft.Office.Interop.Excel.Workbook xlWorkBook, Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet, Microsoft.Office.Interop.Excel.Application xlApp)
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(xlWorkSheet);
                Marshal.FinalReleaseComObject(xlWorkBook);
                Marshal.FinalReleaseComObject(xlApp);

                xlWorkBook = null;
                xlApp = null;
                xlWorkSheet = null;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
