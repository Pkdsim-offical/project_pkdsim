using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Bolt_necklace
{
    public class Bolt_NecklaceItemID : MonoBehaviour
    {
        
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }

        public void Bolt_Necklace_ID()
        {
                        // 226665558 = Bolt
            // 22 = B
            // 666 = o
            // 555 = l
            // 8 = t
            CustomUUID = "226665558-663322255555222233";
            Name = "Bolt Necklace";
            Category = "Necklace";    
        }
    }
}