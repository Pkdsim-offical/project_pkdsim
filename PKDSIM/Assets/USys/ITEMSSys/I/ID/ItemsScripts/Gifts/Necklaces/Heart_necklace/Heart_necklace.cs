using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Heart_necklace
{
    public class Heart_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public void Heart_Necklace_ID()
        {
            // 443327778 = Heart
            // 44 = H
            // 33 = e
            // 2 = a
            // 777 = r
            // 8 = t
            CustomUUID = "443327778-663322255555222233";
            Name = "Heart Necklace";
            Category = "Necklace";
        }
    }
}