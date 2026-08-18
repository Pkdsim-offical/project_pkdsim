using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Frostlass
{
    public class FrostlassDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Frostlass();
        }

        private void Frostlass()
        {
            Console.WriteLine("Personality: Frostlass has a serene and mysterious character with a hint of mischievousness. She is known for her graceful movements and the chilling aura she exudes. Frostlass's personality revolves around themes of elegance, mystery, and a love for playing pranks on unsuspecting individuals.");
            Console.WriteLine("Parental Relationship: Frostlass has a close relationship with her mother, an ancient ice spirit who passed down the knowledge of ice magic and the importance of embracing the beauty of winter. This maternal figure has shared stories of her adventures in the icy realms and the significance of preserving the secrets of the ice.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Frostlass has a backstory tied to her role as a guardian of winter and the secrets of the ice. She has been chosen as the protector of a frozen landscape or a mystical ice cavern, using her powers to maintain the balance of the frozen realm.");
        }
    }
}