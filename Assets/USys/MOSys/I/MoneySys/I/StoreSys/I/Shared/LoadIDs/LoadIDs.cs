using project_pkdsim.Assets.USys.MoneySys.I.STORESys.I.Shared.LoadIDs.I.Necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.STORESys.I.Shared.LoadIDs
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