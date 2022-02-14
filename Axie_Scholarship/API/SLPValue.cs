using Axie_Scholarship.Logs;
using Axie_Scholarship.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.API
{
    public class SLPValue
    {
        static string url = "https://api.coingecko.com/api/v3/coins/smooth-love-potion";
        public static async Task<SLPCoinViewModel> GetSLPValue()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage responseMessage
                        = await client.GetAsync(url))
                    {

                        using (HttpContent response = responseMessage.Content)
                        {
                            string output = await response.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<SLPCoinViewModel>(output);

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                MessageBox.Show("Something went wrong with the request. Please check the logs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            MessageBox.Show("Maximum call to the API might be reached. Please try again after a few minutes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
    }
}
