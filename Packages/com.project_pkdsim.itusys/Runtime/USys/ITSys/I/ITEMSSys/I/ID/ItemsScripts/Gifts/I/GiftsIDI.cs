using project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Bracelets;
using project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Earrings;
using project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Rings;
using project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Necklaces;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Modules
{
	public class GiftsIDI : MonoBehaviour 
	{
		private NecklacesGiftTypeID NecklacesID;
		private RingsGiftTypeID RingsID;
		private EarringsGiftTypeID EarringsID;
		private BraceletsGiftTypeID BraceletsID;
		public GiftsIDI(NecklacesGiftTypeID necklacesID, EarringsGiftTypeID earringsID, BraceletsGiftTypeID braceletsID, RingsGiftTypeID ringsID)
		{
			NecklacesID = necklacesID;
			EarringsID = earringsID;
			BraceletsID = braceletsID;
			RingsID = ringsID;
		}
		public void LoadNecklacesID()
		{
			NecklacesID.LoadNecklacesID();
		}
		public void LoadRingsID() 
		{
			RingsID.LoadRingsID();
		}
		public void LoadBraceletsID() 
		{
			BraceletsID.LoadBraceletsID();
		}
		public void LoadEarringsID() 
		{
			EarringsID.LoadEarringID();
		}
	}
}