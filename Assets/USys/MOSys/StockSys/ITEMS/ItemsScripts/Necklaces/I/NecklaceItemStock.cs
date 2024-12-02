using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Bolt_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Brick_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Beam_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Cat_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Crust_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Heart_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Leaf_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Lunar_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.PunchingBag_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Sun_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.WaterDroplet_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Hypno_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Snowflake_necklace;
using project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Spark_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Necklaces.I
{
	public class NecklaceItemStock : MonoBehaviour 
	{
		private Beam_NecklaceItemStock Beam_Necklace;

		private Bolt_NecklaceItemStock Bolt_Necklace;

		private Brick_NecklaceItemStock Brick_Necklace;

		private Cat_NecklaceItemStock Cat_Necklace;

		private Crust_NecklaceItemStock Crust_Necklace;

		private Heart_NecklaceItemStock Heart_Necklace;

        private Hypno_NecklaceItemStock Hypno_Necklace;

		private Leaf_NecklaceItemStock Leaf_Necklace;

		private Lunar_NecklaceItemStock Lunar_Necklace;

		private PunchingBag_NecklaceItemStock PunchingBag_Necklace;

        private Snowflake_NecklaceItemStock Snowflake_Necklace;

		private Sun_NecklaceItemStock Sun_Necklace;

        private Soul_NecklaceItemStock Soul_Necklace;

        private Spark_NecklaceItemStock Spark_Necklace;

		private WaterDroplet_NecklaceItemStock WaterDroplet_Necklace;

		public void LoadNecklaceStocks()
		{
            GetBeam_Necklace();
            GetBolt_Necklace();
            GetBrick_Necklace();
            GetCat_Necklace();
            GetCrust_Necklace();
            GetHeart_Necklace();
            GetHypno_Necklace();
            GetLeaf_Necklace();
            GetLunar_Necklace();
            GetPunchingBag_Necklace();
            GetSnowflake_Necklace();
            GetSoul_Necklace();
            GetSpark_Necklace();
            GetSun_Necklace();
            GetWaterDroplet_Necklace();
		}
        public void GetBeam_Necklace() 
        {
            Beam_Necklace.GetPriceSys();
        }
		public void GetBolt_Necklace() 
        {
            Bolt_Necklace.GetPriceSys();
        }
		public void GetBrick_Necklace() 
        {
            Brick_Necklace.GetPriceSys();
		}
		public void GetCat_Necklace() 
        {
            Cat_Necklace.GetPriceSys();
        }
		public void GetCrust_Necklace() 
        {
            Crust_Necklace.GetPriceSys();
        }
		public void GetHeart_Necklace() 
        {
            Heart_Necklace.GetPriceSys();
        }
		public void GetHypno_Necklace() 
        {
            Hypno_Necklace.GetPriceSys();
        }
		public void GetLeaf_Necklace() 
        {
            Leaf_Necklace.GetPriceSys();
        }
		public void GetLunar_Necklace() 
        {
            Lunar_Necklace.GetPriceSys();
        }
		public void GetPunchingBag_Necklace() 
        {
            PunchingBag_Necklace.GetPriceSys();
        }
		public void GetSnowflake_Necklace() 
        {
            Snowflake_Necklace.GetPriceSys();
        }
		public void GetSoul_Necklace() 
        {
            Soul_Necklace.GetPriceSys();
        }
        public void GetSpark_Necklace() 
        {
            Spark_Necklace.GetPriceSys();
        }
		public void GetSun_Necklace() 
        {
            Sun_Necklace.GetPriceSys();
        }
        public void GetWaterDroplet_Necklace() 
        {
            WaterDroplet_Necklace.GetPriceSys();
		}
	}	
}