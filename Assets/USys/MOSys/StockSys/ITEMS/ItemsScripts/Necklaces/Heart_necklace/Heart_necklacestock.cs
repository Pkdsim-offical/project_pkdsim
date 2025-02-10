using System;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.Heart_necklace
{
    public class Heart_NecklaceItemStock : MonoBehaviour
    {
        private DateTime DateAndTime;
        private PriceSys.PriceSys PriceSys;
        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}