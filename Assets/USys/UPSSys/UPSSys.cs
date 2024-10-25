using project_pkdsim.Assets.USys.ITEMSSys.INVENTORY;
using project_pkdsim.Assets.USys.LOVESys.NPC;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UPSSys
{
	public class UPSSys : MonoBehaviour
	{
		[System.Serializable]
		public class PlayerData
		{
			private InventorySystem  inventory;
			private NPC_LOVESys NPC_LoveSys;

			public int Build_Version;
			public UnityEngine.Object pkphone;

			public PlayerData()
			{
				Build_Version = 1;
				NPC_LoveSys.NPC_LoveSys();         // Call the method        // Initialize inventory
				inventory.Get_Inventory();         // Call the method
			}
		}
	}
}
