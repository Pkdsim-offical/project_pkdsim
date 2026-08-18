using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ID.ItemsScripts.Gifts.Necklaces.Ghost.Shadow_necklace
{
    public class Shadow_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Shadow_Necklace_ID()
        {
            // 7777 = s
            // 66 = n
            // 666 = o
            // 9 = w
            // 333 = f
            // 555 = l
            // 2 = a
            // 55 = k
            // 33 = e
            CustomUUID = "7777666669333555-663322255555222233";
            Name = "Shadow Necklace";
            Category = "Necklace";
        }
    }
}