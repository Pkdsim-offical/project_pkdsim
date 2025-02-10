using project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC;
using project_pkdsim.Assets.USys.HTPSys.HOUSES.PLAYER;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.TABSys_WayPointLink.I.Menu_I.Houses
{
	public class TabSys_WaypointMenuHouses : MonoBehaviour 
	{
		private HTPSys_NPC_FamilyTeleporter HTPSys_NPC_FamilyTeleporter;
        private HTPSys_Player_FamilyTeleporter HTPSys_Player_FamilyTeleporter;

		private bool PlayerHouseMenu;
		private bool NPCHousesMenu;

		public void  DisplayMenu() 
        {
            DisplayNPCHouses();
            DisplayPlayerHouse();
        }
        private void DisplayNPCHouses() 
        {
			UnityEngine.Assertions.Assert.IsFalse(PlayerHouseMenu);
			HTPSys_NPC_FamilyTeleporter.HTPSys_NPC_FamilySceneTeleporter("family");
        }
        private void DisplayPlayerHouse() 
        {
			UnityEngine.Assertions.Assert.IsFalse(NPCHousesMenu);
            HTPSys_Player_FamilyTeleporter.HTPSys_Player_FamilySceneTeleporter();
        }
	}
}