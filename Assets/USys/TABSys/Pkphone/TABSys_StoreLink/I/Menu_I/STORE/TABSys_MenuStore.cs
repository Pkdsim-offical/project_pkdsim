using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.I.Menu_I.STORE.GetBuyMenu;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.I.Menu_I.STORE.GetSellMenu;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.I.Menu_I.STORE
{
	public class TABSys_MenuStore : MonoBehaviour 
	{
		private Get_Buy_Menu GetBuyMenu;
		private Get_Sell_Menu GetSellMenu;

		private bool StoreMenu_BuyMenu;
		private bool StoreMenu_SellMenu;
		public void StoreMenUBuyMenu()
		{
			UnityEngine.Assertions.Assert.IsFalse(StoreMenu_SellMenu);
			GetBuyMenu.GetBuyMenuI();
		}
		public void StoreMenuSellMenu()
		{
			UnityEngine.Assertions.Assert.IsFalse(StoreMenu_BuyMenu);
			GetSellMenu.GetSellMenuI();
		}
	}
}