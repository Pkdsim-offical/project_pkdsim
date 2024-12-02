using project_pkdsim.Assets.USys.StockSys.ITEMS.ItemsScripts;
using UnityEngine;

namespace project_pkdsim.Assets.USys.StockSys
{
	public class StockSys : MonoBehaviour 
	{
		public ItemStock itemsStockSys;
		public void ItemStockSysI () 
		{
			itemsStockSys = GetComponent<ItemStock> ();
			itemsStockSys.NecklaceItemStocks();
		}
		public void StockSysI () 
		{
			ItemStockSysI ();
		}
	}
}