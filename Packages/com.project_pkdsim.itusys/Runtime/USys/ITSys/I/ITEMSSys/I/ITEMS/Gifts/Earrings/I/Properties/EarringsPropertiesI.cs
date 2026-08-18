using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Base_Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Properties
{
	public class EarringsPropertiesI : MonoBehaviour
	{
		private EarringsLoveEffectPropertiesBase Base_Properties;
		public void Earrings_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}