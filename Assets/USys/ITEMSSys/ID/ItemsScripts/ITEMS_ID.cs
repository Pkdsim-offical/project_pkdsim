using project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts
{
    public class ITEMS_ID : MonoBehaviour
    {
        private GIftsID GiftsID;
        protected void ITEM_GIFTS_ID()
        {
            GiftsID.LoadGiftsID();
        }
    }
}