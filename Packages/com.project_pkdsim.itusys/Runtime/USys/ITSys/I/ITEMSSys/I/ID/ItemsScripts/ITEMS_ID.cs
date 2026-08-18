using project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts
{
    public class ITEMS_ID : MonoBehaviour
    {
        private GiftsID GiftsID;
        protected void ITEM_GIFTS_ID()
        {
            GiftsID.LoadGiftsID();
        }
    }
}