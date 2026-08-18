using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Merger;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules
{
    public class NecklacesI : Necklaces_PropertiesMerger
    {
        public void Necklaces_LoadPropertiesManager(string value)
        {
            Load_Necklaces_Jsons();
            LoadProperties(value);
        }
    }
}