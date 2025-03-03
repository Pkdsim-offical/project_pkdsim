using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Butterfly_necklace
{
    public class Butterfly_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Butterfly_Necklace_ID()
        {
            // 22888833777 = Butter
            // 22 = b
            // 88 = u
            // 8 = t
            // 8 = t
            // 33 = e
            // 777 = r
            CustomUUID = "2288883377-663322255555222233";
            Name = "Butter Necklace";
            Category = "Necklace";
        }
    }
}