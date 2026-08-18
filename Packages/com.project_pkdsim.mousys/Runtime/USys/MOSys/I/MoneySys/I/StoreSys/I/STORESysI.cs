using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Buy;
using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Sell;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules
{
	public class STORESysI : MonoBehaviour 
	{
		private BuyItem BuyItems;
		private SellItem SellItems;

		private void BuyItem()
		{
			BuyItems.BuyItemI();
		}
		private void SellItem()
		{
			SellItems.SellItemI();
		}
		public void StoreSys_I()
		{
			SellItem();
			BuyItem();
		}
	}
}