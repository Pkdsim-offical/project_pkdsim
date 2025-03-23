using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.HolidayITEM;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.I
{
	public class IAssetSorter : MonoBehaviour
	{
		private HolidayItem HolidayItems;
		public void LoadAllHolidays()
		{
			HolidayItems.LoadItems();
		}
	}
}
