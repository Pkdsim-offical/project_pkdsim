using project_pkdsim.USys.ATSys.Modules.AnimatedTexturesSys.NPC.Modules;
using UnityEngine;

namespace project_pkdsim.USys.ATSys.Modules.AnimatedTexturesSys.Modules
{
	public class AnimatedTextureSysI : MonoBehaviour 
	{
		private NPC_ATSysI NPC_ATSysI;
		public void AnimatedTextureSys_I() 
		{
			GetNPC_AnimatedTextureSys_I();
		}
		private void GetNPC_AnimatedTextureSys_I()
		{
			NPC_ATSysI.NPC_ATSys_I();
		}
	}
}