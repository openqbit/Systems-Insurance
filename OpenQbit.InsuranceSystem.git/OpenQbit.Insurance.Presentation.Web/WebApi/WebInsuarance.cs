using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading.Tasks;


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

        public async Task<> GetCustomer()
        {
            APICustomer customer = new APICustomer();

            using (var response = await _client.GetAsync("http://localhost:1562/api/Customer/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    customer = _jsonSerializer.Deserialize<APICustomer>(jsonString);
                }
            }


            return customer;

        }

        public async Task<List<APICustomer>> GetCustomerList()
        {
            List<APICustomer> customer = new List<APICustomer>();

            using (var response = await _client.GetAsync("http://localhost:1562/api/Customer/"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    customer = _jsonSerializer.Deserialize<List<APICustomer>>(jsonString);
                }
            }


            return customer;

        }
    }
}