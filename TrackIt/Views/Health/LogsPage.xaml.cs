using TrackIt.Model;
using TrackIt.Services;

namespace TrackIt.Views.Health;

public partial class LogsPage : ContentPage
{
	public LogsPage()
	{
		InitializeComponent();

		List<IndexVM> list = new();
		var memberNutrients = NutrientService.GetMemberNutrients();
		Task.Delay(1200);

		if (memberNutrients.Count > 0)
		{
			foreach (var item in memberNutrients)
			{
				IndexVM listItem = new();

				listItem.MemberNutrientID = item.MemberNutrientID;
				listItem.NutrientName = NutrientService.GetNutrientByID(item.NutrientID).NutrientName;
				listItem.CreatedDate = item.CreatedDate.ToShortDateString();

				if (item.ServingType == 1)
				{
					listItem.ServingSize = item.ServingSize.ToString() + " ml";
				}
				else
				{
					listItem.ServingSize = item.ServingSize.ToString() + " gr";
				}

				list.Add(listItem);
			}

			listMNutrients.ItemsSource = list;
		}
		else
		{
			listMNutrients.ItemsSource = new List<MemberNutrient>();
		}
	}

	public class IndexVM
	{
		public int MemberNutrientID { get; set; }
		public string ServingSize { get; set; }
		public string NutrientName { get; set; }
		public string CreatedDate { get; set; }
	}
}