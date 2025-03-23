using project_pkdsim.Assets.USys.MoneySys.I.PRICESys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Snowflake_necklace
{
    public class Snowflake_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}