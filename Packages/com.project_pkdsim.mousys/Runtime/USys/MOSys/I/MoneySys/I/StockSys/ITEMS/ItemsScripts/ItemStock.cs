using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STOCKSys.ITEMS.ItemsScripts.Necklaces.Modules;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STOCKSys.ITEMS.ItemsScripts
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