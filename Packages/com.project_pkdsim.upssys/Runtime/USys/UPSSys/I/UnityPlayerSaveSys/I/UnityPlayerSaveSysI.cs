using project_pkdsim.USys.UItemsSystemSys.INVENTORY;
using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC;

namespace project_pkdsim.USys.UPSSys.Modules.UnityPlayerSaveSys.Modules
{
	[System.Serializable]
	public class UnityPlayerSaveFIleSysI
	{
		private InventorySystem  inventory;

		private NPC_LOVESys NPC_LoveSys;

		public int Build_Version;

		public UnityEngine.Object pkphone;

		public void PlayerDataBuilder(string value)
		{
			Build_Version = 1;
			NPC_LoveSys.NPC_LoveSys();         // Call the method        // Initialize inventory
			inventory.Get_Inventory();         // Call the method
		}
		public void UnityPlayerSaveFileSys_I() 
		{
			PlayerDataBuilder("value");
		}
	}
}

