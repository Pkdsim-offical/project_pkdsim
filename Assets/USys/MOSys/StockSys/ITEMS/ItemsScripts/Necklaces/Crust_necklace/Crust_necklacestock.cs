using project_pkdsim.Assets.USys.MONEYSys.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Crust_necklace
{
    public class Crust_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}