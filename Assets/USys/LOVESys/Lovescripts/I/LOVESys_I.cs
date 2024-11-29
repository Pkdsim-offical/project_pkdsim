using project_pkdsim.Assets.USys.LOVESys.NPC;
using project_pkdsim.Assets.USys.LOVESys.LoveScripts.PLAYER;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LOVESys
{
	public class LOVESys_I : MonoBehaviour
	{
		private NPC_LOVESys NPC_LoveSys;
		private Player_LOVESys Player_LoveSys;

		protected void Run()
		{
			Get_NPC_LOVESys();
			Get_Player_LOVESys();
		}
		protected void Get_NPC_LOVESys()
		{
			NPC_LoveSys = new NPC_LOVESys();
		}
		protected void Get_Player_LOVESys()
		{
			Player_LoveSys = new Player_LOVESys();
		}
	}
}