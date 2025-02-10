using project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys
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