using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.CyberMonday
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