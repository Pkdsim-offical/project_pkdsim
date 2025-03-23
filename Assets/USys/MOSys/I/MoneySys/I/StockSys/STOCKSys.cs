using project_pkdsim.Assets.USys.MoneySys.I.STOCKSys.ITEMS.ItemsScripts;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.STOCKSys
{
	public class StockSys : MonoBehaviour 
	{
		public ItemStock itemsStockSys;
		private void ItemStockSysI () 
		{
			itemsStockSys.NecklaceItemStocks();
		}
		public void StockSysI() 
		{
			ItemStockSysI();
		}
	}
}