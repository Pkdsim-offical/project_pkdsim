using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Espeon
{
    public class EspeonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
    
        public void Pkpedia_link()
        {
            Espeon();
        }
    
        private void Espeon()
        {
            Console.WriteLine("Personality: Espeon has a determined and driven character. She is fiercely competitive, always striving to prove themselves and demonstrate her abilities. While she has a sunny and positive disposition, her competitive nature can occasionally border on stubbornness.");
            Console.WriteLine("Parental Relationship: Espeon's Mother, a Espeon, A role model and mentor, she nurtures Espeon’s intelligence and psychic prowess, emphasizing intellect over raw power.She instills a sense of calm and wisdom, believing knowledge is the greatest strength. /n Father an Umbreon, Though protective of Espeon, his values differ from the mother's. He appreciates Espeon’s strengths but doesn’t fully understand the reliance on foresight and strategy over physical strength. This difference often adds subtle friction within the family dynamics.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Espeon has a backstory that revolves around her intense desire to excel and stand out in her community. She has grown up with high expectations placed on them due to her association with the sun and light. Espeon has faced challenges in living up to these expectations, which would motivate her competitive spirit.");

            // siblings
            Console.WriteLine("Umbreon and Espeon sibling relationship: The relationship between Glaceon and Leafeon has sibling rivalry, but it isn't solely competitive. \n Umbreon and Espeon Sibling Relationship: \n Umbreon and Espeon, being siblings, share a complex bond. While both Pokémon are associated with celestial themes (Umbreon with the moon and Espeon with the sun), she have different personalities and strengths that complement each other. she can be split up into four parts. \n 1. Rivalry: she has friendly competition, especially when it comes to her abilities and who can be more in tune with her celestial connections. This rivalry leads to moments of playfulness and challenge. \n 2. Mutual Support: Despite her rivalry, the two siblings deeply care for each other. she are there for each other during tough times and provide support when it's needed most. she recognizes that she are stronger together. \n 3. Complementary Abilities: Emphasize how her powers are seen as two sides of the same coin, representing the balance between light and darkness. she need to work together in the storyline to solve certain challenges by harmonizing her abilities. \n 4. Individual Growth: Allow for character development where both Umbreon and Espeon come to appreciate each other's unique strengths and contributions. she learn that her differences make them stronger as a team.");

            // Umbreon’s and Espeon’s ancient legend (Espeon's side)
            Console.WriteLine("Luminary Phoenix legend. In this legend, it has been said that during moments of intense sunlight, a rare and majestic Luminary Phoenix appears. \n Espeon is considered the guardian of this phoenix, and it's her responsibility to ensure the safety of the Luminary Phoenix and harness its energy to protect her community during the day. \n This legend emphasizes Espeon's connection to daylight and her role in safeguarding the community from harsh sunlight and heat.");
        }
    }
}