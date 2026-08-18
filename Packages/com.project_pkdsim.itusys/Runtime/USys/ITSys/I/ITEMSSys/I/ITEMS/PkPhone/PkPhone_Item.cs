using project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.PkPhone.inventory;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.PkPhone
{
	public class PkPhone_Item : MonoBehaviour
	{
		private GameObject pkphone;
		private PkPhone_inventory pkphone_inventory;
		public void Get_Game_object()
		{
			pkphone = GameObject.Find("PkPhone");
		}
		public void Get_Inventory(string inventory)
		{
			pkphone_inventory.Get_Inventory(inventory);
		}
	}
}