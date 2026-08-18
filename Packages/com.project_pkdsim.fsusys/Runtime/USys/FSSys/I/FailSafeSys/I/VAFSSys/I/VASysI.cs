using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.Player;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.Parents;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules
{
	public class VAFSSysI : MonoBehaviour
	{
		private VAFSSys_Npc VAFSSys_NPC;
		private VAFSSys_Player VAFSSys_Player;
		private VAFSSys_Parents VAFSSys_Parents;

		private void VAFSSysI_NPC()
		{
			VAFSSys_NPC.VAFSSys_NPCI();
		}
		private void VAFSSysI_Player()
		{
			VAFSSys_Player.VAFSSys_PlayerI();
		}
		private void VAFSSysI_Parents()
		{
			VAFSSys_Parents.VAFSSys_ParentsI();
		}

		public void VAFSSys_I()
		{
			VAFSSysI_NPC();
			VAFSSysI_Player();
		}
	}
}