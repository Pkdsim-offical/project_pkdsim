using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.PunchingBag_necklace
{
    public class PunchingBag_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void PunchingBag_Necklace_ID()
        {
            // 78866222444446643324 = PunchingBag
            // 7 = p
            // 88 = u
            // 66 = n
            // 222 = c
            // 44 = h
            // 444 = i
            // 66 = n
            // 4 = g
            // 22 = b
            // 2 = a
            // 4 = g
            CustomUUID = "78866222444446643324-663322255555222233";
            Name = "PunchingBag Necklace";
            Category = "Necklace";
        }
    }
}
