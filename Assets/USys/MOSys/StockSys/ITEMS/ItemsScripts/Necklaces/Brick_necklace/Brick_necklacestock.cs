using System;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.Brick_necklace
{
    public class Brick_NecklaceItemStock : MonoBehaviour
    {
        private DateTime DateAndTime;
        private PriceSys.PriceSys PriceSys;
        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}