using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Crust_necklace
{
    public class Crust_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Crust_Necklace_ID()
        {
            // 2227778877778 = Crust
            // 22 = C
            // 777 = r
            // 88 = u
            // 7777 = s
            // 8 = t
            CustomUUID = "2227778877778-663322255555222233";
            Name = "Crust Necklace";
            Category = "Necklace";
        }
    }
}