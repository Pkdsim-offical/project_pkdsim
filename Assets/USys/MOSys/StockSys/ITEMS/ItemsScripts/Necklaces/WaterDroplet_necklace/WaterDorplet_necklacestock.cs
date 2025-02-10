using System;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.WaterDroplet_necklace
{
    public class WaterDroplet_NecklaceItemStock : MonoBehaviour
    {
        private DateTime DateAndTime;
        private PriceSys.PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}