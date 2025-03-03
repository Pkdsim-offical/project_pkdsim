using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Beam_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Bolt_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Brick_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Cat_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Crust_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Heart_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Hypno_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Snowflake_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Soul_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Spark_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Sun_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.WaterDroplet_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Leaf_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Butterfly_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.PunchingBag_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Lunar_necklace;
using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Wings_necklace;
using UnityEngine;
using System.Collections.Generic;

namespace project_pkdsim.Assets.USys.MONEYSys.STORESys.I.Shared.LoadIDs.I.Necklace
{
	public class LoadNecklaceID_StoreLink : MonoBehaviour 
	{
		private Bolt_NecklaceItemID Bolt_NecklaceItemID;
		private Cat_NecklaceItemID Cat_NecklaceItemID;
		private Brick_NecklaceItemID Brick_NecklaceItemID;
		private Beam_NecklaceItemID Beam_NecklaceItemID;
		private Crust_NecklaceItemID Crust_NecklaceItemID;
		private Heart_NecklaceItemID Heart_NecklaceItemID;
		private Hypno_NecklaceItemID Hypno_NecklaceItemID;
		private Snowflake_NecklaceItemID Snowflake_NecklaceItemID;
		private Spark_NecklaceItemID Spark_NecklaceItemID;
		private Sun_NecklaceItemID Sun_NecklaceItemID;
		private Soul_NecklaceItemID Soul_NecklaceItemID;
		private WaterDroplet_NecklaceItemID WaterDroplet_NecklaceItemID;

		private Lunar_NecklaceItemID Lunar_NecklaceItemID;

		private Leaf_NecklaceItemID Leaf_NecklaceItemID;
		
		private PunchingBag_NecklaceItemID PunchingBag_NecklaceItemID;
		
		private Butterfly_NecklaceItemID Butterfly_NecklaceItemID;

		private Wings_NecklaceItemID Wings_NecklaceItemID;
		public Dictionary<string, int> ItemNecklacePrices = new Dictionary<string, int>();
		public void Get_Items_NecklaceIDs()
		{
			// Instantiate or get references to the items
			Bolt_NecklaceItemID = new Bolt_NecklaceItemID();
			Cat_NecklaceItemID = new Cat_NecklaceItemID();
			Brick_NecklaceItemID = new Brick_NecklaceItemID();
			Beam_NecklaceItemID = new Beam_NecklaceItemID();			
			Crust_NecklaceItemID = new Crust_NecklaceItemID();
			Heart_NecklaceItemID = new Heart_NecklaceItemID();
			Hypno_NecklaceItemID = new Hypno_NecklaceItemID();
			Snowflake_NecklaceItemID = new Snowflake_NecklaceItemID();
			Spark_NecklaceItemID = new Spark_NecklaceItemID();
			Sun_NecklaceItemID = new Sun_NecklaceItemID();
			Soul_NecklaceItemID = new Soul_NecklaceItemID();
			WaterDroplet_NecklaceItemID = new WaterDroplet_NecklaceItemID();
			Lunar_NecklaceItemID = new Lunar_NecklaceItemID();
			Leaf_NecklaceItemID = new Leaf_NecklaceItemID();
			PunchingBag_NecklaceItemID = new PunchingBag_NecklaceItemID();
			Butterfly_NecklaceItemID = new Butterfly_NecklaceItemID();
			Wings_NecklaceItemID = new Wings_NecklaceItemID();

			// Add items to the dictionary using their string property			
			ItemNecklacePrices.Add(Bolt_NecklaceItemID.CustomUUID, 100);
			ItemNecklacePrices.Add(Cat_NecklaceItemID.CustomUUID, 250);
			ItemNecklacePrices.Add(Brick_NecklaceItemID.CustomUUID, 75);
			ItemNecklacePrices.Add(Beam_NecklaceItemID.CustomUUID, 150);
			ItemNecklacePrices.Add(Crust_NecklaceItemID.CustomUUID, 100);
			ItemNecklacePrices.Add(Heart_NecklaceItemID.CustomUUID, 250);
			ItemNecklacePrices.Add(Hypno_NecklaceItemID.CustomUUID, 75);
			ItemNecklacePrices.Add(Snowflake_NecklaceItemID.CustomUUID, 150);
			ItemNecklacePrices.Add(Spark_NecklaceItemID.CustomUUID, 100);
			ItemNecklacePrices.Add(Sun_NecklaceItemID.CustomUUID, 250);
			ItemNecklacePrices.Add(Soul_NecklaceItemID.CustomUUID, 75);
			ItemNecklacePrices.Add(WaterDroplet_NecklaceItemID.CustomUUID, 150);
			ItemNecklacePrices.Add(Lunar_NecklaceItemID.CustomUUID, 100);
			ItemNecklacePrices.Add(Leaf_NecklaceItemID.CustomUUID, 250);
			ItemNecklacePrices.Add(PunchingBag_NecklaceItemID.CustomUUID, 75);
			ItemNecklacePrices.Add(Butterfly_NecklaceItemID.CustomUUID, 150);
			ItemNecklacePrices.Add(Wings_NecklaceItemID.CustomUUID, 100);
		}
	}
}