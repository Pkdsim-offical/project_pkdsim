using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Modules;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts
{
	public class GIfts : GiftsI
	{
		public GIfts(NecklacesGiftType necklaces, EarringsGiftType earrings, BraceletsGiftType bracelets, RingsGiftType rings) : base(necklaces, earrings, bracelets, rings)
		{
			// TODO: Complete member initialization
        }

        public void LoadGifts(string value)
		{
			LoadNecklaces(value);
			LoadEarrings(value);
			LoadBracelets(value);
			LoadRings(value);
		}
	}
}