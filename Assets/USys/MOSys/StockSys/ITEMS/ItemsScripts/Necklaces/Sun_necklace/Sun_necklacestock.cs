using System;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.Sun_necklace
{
    public class Sun_NecklaceItemStock : MonoBehaviour
    {
        private DateTime DateAndTime;
        private PriceSys.PriceSys PriceSys;
        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}