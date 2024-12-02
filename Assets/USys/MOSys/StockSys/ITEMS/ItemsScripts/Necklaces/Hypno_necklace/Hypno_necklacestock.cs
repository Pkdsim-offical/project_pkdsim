using project_pkdsim.Assets.USys.MONEYSys.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Hypno_necklace
{
    public class Hypno_NecklaceItemStock : MonoBehaviour
    {

        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}