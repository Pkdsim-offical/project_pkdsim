using System;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.Hypno_necklace
{
    public class Hypno_NecklaceItemStock : MonoBehaviour
    {
        private DateTime DateAndTime;
        private PriceSys.PriceSys PriceSys;
        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}