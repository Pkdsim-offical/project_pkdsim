using project_pkdsim.Assets.USys.MONEYSys.PRICESys;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys;
using project_pkdsim.Assets.USys.MONEYSys.STORESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys
{
	public class MoneySys : MonoBehaviour
	{
		private PriceSys PriceSys;
		private StockSys StockSys;
		private StoreSys StoreSys;

		public void MoneySysI()
		{
			GetPriceSys();
			GetStockSys();
			GetStoreSys();
		}
		private void GetPriceSys()
		{
			PriceSys.PriceSysI();
		}
		private void GetStockSys()
		{
			StockSys.StockSysI();
		}
		private void GetStoreSys()
		{
			StoreSys.StoreSysI();
		}
	}
}