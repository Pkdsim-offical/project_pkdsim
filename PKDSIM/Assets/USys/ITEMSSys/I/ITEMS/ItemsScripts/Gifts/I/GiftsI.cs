using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.I
{
public class GiftsI : MonoBehaviour 
{
		private NecklacesGiftType Necklaces;
	
		public void LoadNecklaces(string value)
		{
			Necklaces.LoadNecklaces(value);
		}
	}
}