using project_pkdsim.Assets.USys.MONEYSys.STORESys.I.Buy;
using project_pkdsim.Assets.USys.MONEYSys.STORESys.I.Sell;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.STORESys.I
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