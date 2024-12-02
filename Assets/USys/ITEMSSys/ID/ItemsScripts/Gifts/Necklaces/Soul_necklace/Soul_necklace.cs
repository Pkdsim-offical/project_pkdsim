using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Soul_necklace
{
    public class Soul_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Soul_Necklace_ID()
        {
            // 777766688555 = Soul
            // 777 = s
            // 666 = o
            // 88 = u
            // 555 = l
            CustomUUID = "777766688555-663322255555222233";
            Name = "Soul Necklace";
            Category = "Necklace";
        }
    }
}