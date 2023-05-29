using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackIt.Model;

namespace TrackIt.Services
{
	public static class NutrientService
	{
		public static List<MemberNutrient> GetMemberNutrients()
		{
			var id = SecureStorage.Default.GetAsync("memberId");

			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/GetMemberNutrientLogs/" + id.Result;

			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			if (responseMessage != null)
			{
				if (responseMessage.IsSuccessStatusCode)
				{
					var mNutrients = JsonConvert.DeserializeObject<List<MemberNutrient>>(responseMessage.Content.ReadAsStringAsync().Result);

					client.Dispose();
					return mNutrients;
				}
				else
				{
					client.Dispose();
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		public static Nutrient GetNutrientByID(int id)
		{
			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/GetNutrientByID/" + id;

			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			if (responseMessage != null)
			{
				if (responseMessage.IsSuccessStatusCode)
				{
					var nutrient = JsonConvert.DeserializeObject<Nutrient>(responseMessage.Content.ReadAsStringAsync().Result);


					client.Dispose();
					return nutrient;
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

		public static MemberNutrient GetMemberNutrient(int id)
		{
			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/GetMemberNutrientLog/" + id;

			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			if (responseMessage != null)
			{
				if (responseMessage.IsSuccessStatusCode)
				{
					var nutrient = JsonConvert.DeserializeObject<MemberNutrient>(responseMessage.Content.ReadAsStringAsync().Result);


					client.Dispose();
					return nutrient;
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

		public static List<Nutrient> GetNutriens()
		{
			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/GetNutrients/";

			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			if (responseMessage != null)
			{
				if (responseMessage.IsSuccessStatusCode)
				{
					var mNutrients = JsonConvert.DeserializeObject<List<Nutrient>>(responseMessage.Content.ReadAsStringAsync().Result);
					
					client.Dispose();
					return mNutrients;
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

		public static bool CreateMemberNutrient(string info)
		{
			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/CreateMemberNutrient/" + info + "/a";
			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			client.Dispose();
			return responseMessage.IsSuccessStatusCode;
		}

		public static bool DeleteMemberNutrient(int id)
		{
			var client = new HttpClient();
			string url = "https://localhost:7004/api/Nutrient/DeleteMemberNutrient/" + id;
			client.BaseAddress = new Uri(url);
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;

			client.Dispose();
			return responseMessage.IsSuccessStatusCode;
		}
	}
}
