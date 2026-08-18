using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Hypno_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Brain_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Levitate_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Telepathy_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Foresight_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic
{
	public class Psychic_necklace : MonoBehaviour
	{
		private Hypno_NecklaceItem Hypno_NecklaceItem;
		private Telepathy_NecklaceItem Telepathy_NecklaceItem;
		private Brain_NecklaceItem Brain_NecklaceItem;
		private Levitate_NecklaceItem Levitate_NecklaceItem;
		private Foresight_NecklaceItem Foresight_NecklaceItem;

		public void Get_HypnoNecklace()
		{
			Hypno_NecklaceItem.GetBuilder();
		}

		public void Get_TelepathyNecklace()
		{
			Telepathy_NecklaceItem.GetBuilder();
		}

		public void Get_BrainNecklace()
		{
			Brain_NecklaceItem.GetBuilder();
		}

		public void Get_LevitateNecklace()
		{
			Levitate_NecklaceItem.GetBuilder();
		}

		public void Get_ForesightNecklace()
		{
			Foresight_NecklaceItem.GetBuilder();
		}
	}
}