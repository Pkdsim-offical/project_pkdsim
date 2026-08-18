using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Importer;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base
{
	public class TABSys_AffectionStatsMenuBase : MonoBehaviour
	{
		private NPC_LOVESys_Importer NPC_LOVESys_Importer;
		protected void Get_NPC_AffectionStats()
		{
			NPC_LOVESys_Importer.Get_NPC_LLSys();
		}
		public class HeartBarUI : MonoBehaviour
		{
			[SerializeField] private List<Image> heartImages; // Drag heart images in the inspector.

			public void UpdateHearts(int activeHearts)
			{
				for (int i = 0; i < heartImages.Count; i++)
				{
					heartImages[i].enabled = i < activeHearts;
				}
			}
		}
	}
}