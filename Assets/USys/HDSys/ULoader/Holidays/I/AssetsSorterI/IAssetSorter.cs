using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.HolidayITEM;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.I.AssetsSorterI
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
