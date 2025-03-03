using project_pkdsim.Assets.USys.ITEMSSys.INVENTORY;
using project_pkdsim.Assets.USys.LOVESys.NPC;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UPSSys
{
	[System.Serializable]
	public class UnityPlayerSaveSys
	{
		private InventorySystem  inventory;

		private NPC_LOVESys NPC_LoveSys;

		public int Build_Version;

		public UnityEngine.Object pkphone;

		public void PlayerDataBuilder(string value)
		{
			Build_Version = 1;
			NPC_LoveSys.NPC_LoveSys();         // Call the method        // Initialize inventory
			inventory.Get_Inventory(value);         // Call the method
		}
		public void UPSSysI() 
		{
			PlayerDataBuilder("value");
		}
	}
}

