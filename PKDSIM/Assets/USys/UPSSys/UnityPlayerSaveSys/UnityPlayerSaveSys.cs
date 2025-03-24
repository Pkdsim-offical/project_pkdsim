using project_pkdsim.Assets.USys.USystemsSys.INVENTORY;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC;

namespace project_pkdsim.Assets.USys.UnityPlayerSaveSys
{
	[System.Serializable]
	public class UnityPlayerSaveFIleSys
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
		public void UPSSys_I() 
		{
			PlayerDataBuilder("value");
		}
	}
}

