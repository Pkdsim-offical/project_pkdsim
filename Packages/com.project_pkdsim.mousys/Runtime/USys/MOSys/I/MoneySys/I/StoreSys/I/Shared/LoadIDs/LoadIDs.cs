using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Shared.LoadIDs.Modules.Necklace;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STORESys.Modules.Shared.LoadIDs
{
	public class LoadIDs : MonoBehaviour 
	{
		private LoadNecklaceID_StoreLink LoadNecklaceID_StoreLink;
		private void Get_ItemID()
		{
			LoadNecklaceID_StoreLink.Get_Items_NecklaceIDs();
		}
	}
}