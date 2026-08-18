using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Buy
{
	public class BuyItem : MonoBehaviour 
	{
		public void BuyItemI() 
		{
			BuyItems();
		}
		private void BuyItemsDebug(int itemID) 
		{
			// Debug.Log($"Selling item with ID: {itemID}");
			// if (!itemPrices.ContainsKey(itemID))
			// {
			// 	Debug.Log($"Item ID {itemID} not found in inventory.");
			// 	return;
			// }
		}
		private void BuyItems()
		{
			// TODO: buy item
		}
	}
}