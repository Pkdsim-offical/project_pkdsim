using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Merger;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I
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