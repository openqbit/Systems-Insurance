using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using OpenQbit.Insurance.Presentation.Web.Models.API;
using System.Net.Http.Headers;

namespace OpenQbit.Insurance.Presentation.Web.WebApi
{
    public class WebInsuarance
    {
        HttpClient _client;
        JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();

        public WebInsuarance()
        {
            _client = new HttpClient();
        }

        public async Task<ApiInsuranceModel> GetInsurance()
        {
            ApiInsuranceModel insurance = new ApiInsuranceModel();

            using (var response = await _client.GetAsync("http://localhost:1562/api/Customer/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    insurance = _jsonSerializer.Deserialize<ApiInsuranceModel>(jsonString);
                }
            }


            return insurance;

        }

        public async Task<List<ApiInsuranceModel>> GetInsuranceList()
        {
            List<ApiInsuranceModel> insurances = new List<ApiInsuranceModel>();

            using (var response = await _client.GetAsync("http://localhost:1562/api/Customer/"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    insurances = _jsonSerializer.Deserialize<List<ApiInsuranceModel>>(jsonString);
                }
            }


            return insurances;

        }

        // Send data to the service
        public async Task<HttpResponseMessage> PostInsurance(ApiInsuranceModel insurance)
        {

            {
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await _client.PostAsJsonAsync<ApiInsuranceModel>(new Uri("http://localhost:51279/api/AddInsurance"), insurance);
                return response;
            }
        }
    }
}