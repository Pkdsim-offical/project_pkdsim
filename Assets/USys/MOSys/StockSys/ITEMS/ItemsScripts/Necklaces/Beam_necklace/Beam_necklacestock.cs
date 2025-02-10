using System;
using UnityEngine;
using project_pkdsim.Assets.USys.MoneySys.PriceSys;

namespace project_pkdsim.Assets.USys.MoneySys.StockSys.ITEMS.ItemsScripts.Gifts.Necklaces.Beam_necklace
{
    public class Beam_NecklaceItemStock : MonoBehaviour
    {
        public DateTime dateandtime;
        private PriceSys.PriceSys PriceSys;

        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}