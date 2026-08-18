using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.LoadJson;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Merger
{
	public class Earrings_PropertiesMerger : MonoBehaviour
	{
		private EarringsPropertiesI EarringsPropertiesI;

		private LoadEarringsJson LoadEarringsJsons;

		public void LoadProperties(string value)
		{
			EarringsPropertiesI.Earrings_LoadPropertiesBase(value);
		}
		public void Load_Earrings_Jsons()
		{
			LoadEarringsJsons.LoadEarringsJsons();
		}
	}
}