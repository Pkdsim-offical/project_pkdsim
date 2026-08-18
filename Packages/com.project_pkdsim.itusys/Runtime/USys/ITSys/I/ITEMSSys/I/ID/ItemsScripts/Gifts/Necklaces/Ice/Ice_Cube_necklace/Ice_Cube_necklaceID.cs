using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Ice_Cube_necklace
{
    public class Ice_Cube_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Ice_Cube_Necklace_ID()
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
            Name = "Ice Cube Necklace";
            Category = "Necklace";
        }
    }
}