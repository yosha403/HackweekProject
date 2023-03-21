using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using EmailProcessor.ServiceLayer.Interfaces;
using static System.Net.WebRequestMethods;

namespace EmailProcessor.ServiceLayer
{
    public class ExtractResponseServiceLayer : IExtractResponseServiceLayer
    {
        //public async Task<string> GetInfoFromEmail(string mailBody)
        //{
        //    var url = "https://bqvu92uv72.execute-api.us-east-2.amazonaws.com/Dev";

        //    var content = new StringContent(content: JsonContent.SerializeObject(mailBody),
        //        encoding: Encoding.UTF8, mediaType: "application/json");

        //    try
        //    {
        //        using (HttpResponseMessage response = await this._IvrCloudApihttpClient.PostAsync(url, content))
        //        {
        //            response.EnsureSuccessStatusCode();

        //            var responseBody = await response.Content.ReadAsStringAsync();
        //            {
        //                var result = JsonConvert.DeserializeObject<PayoffQuoteResponse>(responseBody);
        //                return result;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message + "  " + ex.StackTrace, "Error in IVRCloudAPIService GeneratePayOffQuotesInfo");
        //        throw ex;
        //    }

        //}
    }
}
