using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Sell
{
	public class SellItem : MonoBehaviour 
	{

		public void SellItemI() 
		{
			SellItems();
		}
		
		private void SellItemsDebug(int itemID)
		{
			// Debug.Log($"Selling item with ID: {itemID}");
			// if (!itemPrices.ContainsKey(itemID))
			// {
			// 	Debug.Log($"Item ID {itemID} not found in inventory.");
			// 	return;
			// }
		}

		private void SellItems() 
		{
			// TODO: sell item
		}
	}
}