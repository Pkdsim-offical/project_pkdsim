using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Fire;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Water;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Bug;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Flying;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Grass;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Dark;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Steel;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Rock;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Normal;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Ground;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Fairy;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Fighting;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Electric;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson
{
	public class LoadNecklacesJson : MonoBehaviour
	{
		private SteelnecklaceJsonLoader Steel_necklace;

		private ElectricnecklaceJsonLoader Electric_necklace;

		private RocknecklaceJsonLoader Rock_necklace;

		private NormalnecklaceJsonLoader Normal_necklace;

		private GroundnecklaceJsonLoader Ground_necklace;

		private FairynecklaceJsonLoader Fairy_necklace;

		private GrassnecklaceJsonLoader Grass_necklace;

		private DarknecklaceJsonLoader Dark_necklace;

		private FightingnecklaceJsonLoader Fighting_necklace;

		private FirenecklaceJsonLoader Fire_necklace;

		private WaternecklaceJsonLoader Water_necklace;

		private BugnecklaceJsonLoader Bug_necklace;

		private FlyingnecklaceJsonLoader Flying_necklace;

		public void LoadNecklacesJsons()
		{
			Steel_necklace = new SteelnecklaceJsonLoader();
			Electric_necklace = new ElectricnecklaceJsonLoader();
			Rock_necklace = new RocknecklaceJsonLoader();
			Normal_necklace = new NormalnecklaceJsonLoader();
			Ground_necklace = new GroundnecklaceJsonLoader();
			Fairy_necklace = new FairynecklaceJsonLoader();
			Grass_necklace = new GrassnecklaceJsonLoader();
			Dark_necklace = new DarknecklaceJsonLoader();
			Fighting_necklace = new FightingnecklaceJsonLoader();
			Fire_necklace = new FirenecklaceJsonLoader();
			Water_necklace = new WaternecklaceJsonLoader();
			Bug_necklace = new BugnecklaceJsonLoader();
			Flying_necklace = new FlyingnecklaceJsonLoader();
		}
	}
}