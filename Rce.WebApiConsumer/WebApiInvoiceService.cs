using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rce.WebApiConsumer
{
    //public class WebApiInvoiceService : IInvoiceService
    //{
    //    private readonly HttpClient _client;

    //    public WebApiUserService(HttpClient client)
    //    {
    //        this._client = client;
    //    }
    //    public User GetUserByEmail(string emailAddress)
    //    {
    //        string request = String.Format("api/users?emailAddress={0}", emailAddress);
    //        HttpResponseMessage response = _client.GetAsync(request).Result; // blocking call

    //        if (response.IsSuccessStatusCode)
    //        {
    //            var user = response.Content.ReadAsAsync<User>().Result;
    //            return user;
    //        }
    //        return null;
    //    }
    //}
}
