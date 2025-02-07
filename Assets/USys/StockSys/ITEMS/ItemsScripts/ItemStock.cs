using project_pkdsim.Assets.USys.ItemsStockSys.ITEMS.ItemsScripts.Necklaces.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.StockSys.ITEMS.ItemsScripts
{
	public class ItemStock : MonoBehaviour 
	{
		private NecklaceItemStock necklacesStock;

		public void NecklaceItemStocks()
		{
			necklacesStock = GetComponent<NecklaceItemStock>();
			necklacesStock.LoadNecklaceStocks();
		}
		
	}
}