using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Beam_necklace
{
    public class Beam_NecklaceItemID : MonoBehaviour
    {

        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }

        public void Beam_Necklace_ID()
        {
            // 223326 = Beam
            // 22 = B
            // 33 = e
            // 2 = a
            // 6 = m
            CustomUUID = "223326-663322255555222233";
            Name = "Beam Necklace";
            Category = "Necklace";
        }
    }
}