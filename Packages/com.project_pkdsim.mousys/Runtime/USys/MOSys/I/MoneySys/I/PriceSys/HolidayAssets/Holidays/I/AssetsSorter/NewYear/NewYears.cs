using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.NewYear
{
	public class NewYears_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadNewYearsHAssetsLoader()
		{
			// Load New Years Assets
		}

		public void LoadNewYearsSales()
		{
			// Load New Years Sales
			ChangePrices.LoadNewYearPrices();
		}
	}
}