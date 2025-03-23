using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadVeterans_DayHAssets()
		{
			//Load Veterans Day Assets
		}

		public void LoadVeterans_DaySales()
		{
			//Load Veterans Day Sales
			ChangePrices.LoadVeterans_DayPrices();
		}
	}
}