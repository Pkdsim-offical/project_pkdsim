using project_pkdsim.Assets.USys.LOVESys.NPC;
using project_pkdsim.Assets.USys.LOVESys.PLAYER;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LOVESys
{	
	public class LOVESys_I : MonoBehaviour 
	{ 
		private NPC_LOVESys NPC_LoveSys;
		private Player_LOVESys Player_LoveSys;
		// Use this for initialization
		void Start() 
		{
			NPC_LOVESys();
			Player_LOVESys();
		}

		// Update is called once per frame
		void Update() {

		}
		public void NPC_LOVESys() 
		{
			NPC_LoveSys = new NPC_LOVESys();
		}
		public void Player_LOVESys()
		{
			Player_LoveSys = new Player_LOVESys();
		}
	}
}