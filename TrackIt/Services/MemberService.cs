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
	public static class MemberService {
		
		public static Member GetMember()
		{
			var id = SecureStorage.Default.GetAsync("memberId");

			var client = new HttpClient();
			string url = "https://localhost:7004/api/Member/GetMember/" + id.Result;

			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			if (responseMessage != null)
			{
				if (responseMessage.IsSuccessStatusCode)
				{
					var member = JsonConvert.DeserializeObject<Member>(responseMessage.Content.ReadAsStringAsync().Result);
					
					client.Dispose();
					return member;
				}
				else
				{
					client.Dispose();
					return null;
				}
			}
			else
			{
				client.Dispose();
				return null;
			}
		}
	}
}
