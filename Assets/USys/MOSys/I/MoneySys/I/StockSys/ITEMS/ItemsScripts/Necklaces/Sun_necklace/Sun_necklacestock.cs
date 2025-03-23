using project_pkdsim.Assets.USys.MoneySys.I.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Sun_necklace
{
    public class Sun_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}