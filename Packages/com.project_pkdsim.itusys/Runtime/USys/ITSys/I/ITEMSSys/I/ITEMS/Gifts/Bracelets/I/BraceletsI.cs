using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Merger;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules
{
    public class BraceletsI : Bracelets_PropertiesMerger
    {
        public void Bracelets_LoadPropertiesManager(string value)
        {
            Load_Bracelets_Jsons();
            LoadProperties(value);
        }
    }
}