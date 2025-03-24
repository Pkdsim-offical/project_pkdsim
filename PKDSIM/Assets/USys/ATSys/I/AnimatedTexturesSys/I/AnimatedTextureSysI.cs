using project_pkdsim.Assets.USys.AnimatedTexturesSys.NPC.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AnimatedTexturesSys.I
{
	public class ATSys_AnimatedTextureSysI : MonoBehaviour 
	{
		private NPC_ATSysI NPC_ATSysI;
		public void AnimatedTextureSysI() 
		{
			GetNPC_AnimatedTextureSys_I();
		}
		private void GetNPC_AnimatedTextureSys_I()
		{
			NPC_ATSysI.NPC_ATSys_I();
		}
	}
}