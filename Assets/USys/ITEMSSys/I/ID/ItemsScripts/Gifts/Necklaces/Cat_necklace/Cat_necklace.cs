using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Cat_necklace
{
    public class Cat_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Cat_Necklace_ID()
        {
            // 22228 = Cat
            // 222 = C
            // 2 = a
            // 8 = t
            CustomUUID = "22228-663322255555222233";
            Name = "Cat Necklace";
            Category = "Necklace";
        }
    }
}