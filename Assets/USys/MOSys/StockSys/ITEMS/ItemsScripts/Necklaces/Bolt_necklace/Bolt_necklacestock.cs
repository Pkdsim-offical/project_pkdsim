using project_pkdsim.Assets.USys.MONEYSys.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Bolt_necklace
{
    public class Bolt_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}