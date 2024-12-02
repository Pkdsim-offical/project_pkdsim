using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Leaf_necklace
{
    public class Leaf_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Leaf_Necklace_ID()
        {
            // 555332333 = Leaf
            // 555 = l
            // 33 = e
            // 2 = a
            // 333 =  f
            CustomUUID = "555332333-663322255555222233";
            Name = "Leaf Necklace";
            Category = "Necklace";
        }
    }
}