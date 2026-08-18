using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.CyberMonday
{
	public class CyberMonday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadCyberMondayHAssetLoader()
		{
			// Load Cyber Monday Assets
		}
		public void LoadCyberMondaySales()
		{
			// Load Cyber Monday Sales
			ChangePrices.LoadCyberMondayPrices();
		}
	}
}