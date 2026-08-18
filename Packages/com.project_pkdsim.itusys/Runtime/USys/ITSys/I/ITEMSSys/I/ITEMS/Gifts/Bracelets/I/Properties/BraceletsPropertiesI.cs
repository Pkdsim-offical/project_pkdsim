using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Base_Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Properties
{
	public class BraceletsPropertiesI : MonoBehaviour
	{
		private BraceletsLoveEffectPropertiesBase Base_Properties;
		public void Bracelets_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}