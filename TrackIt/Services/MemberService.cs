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
    public class MemberService : IMemberService
    {
        public async Task<Member> GetMember()
        {
            var id = await SecureStorage.Default.GetAsync("memberId");

            var client = new HttpClient();
            string url = "https://localhost:7004/api/Member/GetMember/" + id;

            client.BaseAddress = new Uri(url);
            HttpResponseMessage responseMessage = await client.GetAsync(url);

            if (responseMessage.IsSuccessStatusCode)
            {
                var member = JsonConvert.DeserializeObject<Member>(await responseMessage.Content.ReadAsStringAsync());

                return member;
            }
            else
            {
                return null;
            }
        }
    }
}
