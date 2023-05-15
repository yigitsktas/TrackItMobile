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
    public class RegisterService : IRegisterService
    {
        public async Task<bool> Register(string username, string email, string password)
        {
            if (username != null || password != null || email != null)
            {
                Member member = new();

                member.Username = username;
                member.Password = password;
                member.EMail = email;
                member.Gender = 0;
                member.BirthYear = DateTime.Now;
                member.UpdatedDate = DateTime.Now;
                member.CreatedDate = DateTime.Now;

                var info = JsonConvert.SerializeObject(member);

                var client = new HttpClient();
                string url = "https://localhost:7004/api/Member/CreateUser/" + info;
                client.BaseAddress = new Uri(url);
                HttpResponseMessage responseMessage = await client.GetAsync(url);

                return responseMessage.IsSuccessStatusCode;
            }
            else
            {
                return false;
            }
        }
    }
}
