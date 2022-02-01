using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.Logs
{
    public static class Logger
    {
        public static void WriteLog(Exception e)
        {
            string strFileName = "ErrorLogs_"+ DateTime.Today.ToShortDateString() +".txt";

            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Error Logs";
            Directory.CreateDirectory(projectDirectory);
            try
            {
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", projectDirectory, strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(DateTime.Now.ToString("G") + " - - - " + e);
                objStreamWriter.Close();
                objFilestream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Write error log!!!!!" + " --- " + ex);
            }
        }
    }
}
