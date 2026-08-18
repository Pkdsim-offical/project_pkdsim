using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.PunchingBag_necklace
{
    public class PunchingBag_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}