using project_pkdsim.Assets.USys.MoneySys.I.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Spark_necklace
{
    public class Spark_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}