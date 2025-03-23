using project_pkdsim.Assets.USys.MoneySys.I.PRICESys;
using project_pkdsim.Assets.USys.MoneySys.I.STOCKSys;
using project_pkdsim.Assets.USys.MoneySys.I.STORESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I
{
	public class MoneySysI : MonoBehaviour
	{
		private PriceSys PriceSys;
		private StockSys StockSys;
		private StoreSys StoreSys;

		public void MoneySys_I()
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