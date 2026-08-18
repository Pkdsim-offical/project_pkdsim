using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.Modules
{
	public class IAssetSorter : MonoBehaviour
	{
		private HolidayItem HolidayItems;
		public void LoadAllHolidays()
		{
			HolidayItems.LoadItems("");
		}
	}
}
