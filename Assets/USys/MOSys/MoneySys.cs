using project_pkdsim.Assets.USys.MoneySys.PriceSys;
using project_pkdsim.Assets.USys.MoneySys.StockSys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys
{
	public class MoneySys : MonoBehaviour 
	{
		private PriceSys.PriceSys PriceSys;
		private StockSys.StockSys StockSys;

		public void MoneySysI() 
		{
			GetPriceSys();
			GetStockSys();
		}
		private void GetPriceSys() 
		{
			PriceSys.PriceSysI();
		}
		private void GetStockSys() 
		{
			StockSys.StockSysI();
		}
	}
}