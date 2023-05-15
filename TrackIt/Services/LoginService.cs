using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackIt.Interfaces;
using TrackIt.Model;

namespace TrackIt.Services
{
    public class LoginService : ILoginService
    {
        public async Task<bool> Login(string username, string password)
        {
            var client = new HttpClient();
            string url = "https://localhost:7004/api/Member/Login/" + username + "/" + password;
            
            client.BaseAddress = new Uri(url);
            HttpResponseMessage responseMessage = await client.GetAsync(url);

            if (responseMessage != null) 
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    var member = JsonConvert.DeserializeObject<Member>(await responseMessage.Content.ReadAsStringAsync());
                    await SecureStorage.Default.SetAsync("memberId", member.MemberID.ToString());

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
