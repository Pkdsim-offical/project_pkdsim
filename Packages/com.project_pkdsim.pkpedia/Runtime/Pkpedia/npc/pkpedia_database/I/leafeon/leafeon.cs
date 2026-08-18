using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Leafeon
{
    public class LeafeonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Leafeon();
        }
        
        private void Leafeon()
        {
            Console.WriteLine("Personality: Leafeon is a nurturing and caring character. her gentle disposition and deep connection to the environment make them the guardian of the environment. She thrives on spreading the joy of nature and nurturing all living things.");
            Console.WriteLine("Parental Relationship: Leafeon's Mother, a Roserade, she admired Leafeon’s enthusiasm and connection to nature, nurturing its growth and encouraging its role as a guardian of plants.She found Leafeon’s lively spirit refreshing, though she also tried to teach it the same balance and restraint that Glaceon mastered. /n Father an Abomasnow,  saw potential in both of his children, though he often found himself caught between Glaceon’s icy discipline and Leafeon’s fiery passion.He respected Leafeon’s dedication to nature, but his cold, sometimes harsh methods favored Glaceon’s temperament, leading to an undercurrent of competition between the siblings.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Leafeon has a backstory traces back to the ancient protectors of nature. she have been tasked with preserving the balance of life and growth, tending to lush forests and thriving ecosystems, ensuring her preservation for future generations.");

            // siblings
            Console.WriteLine("Glaceon and Leafeon sibling relationship: The relationship between Glaceon and Leafeon has sibling rivalry /n Rivalry: Glaceon and Leafeon engage in friendly competition, especially when it comes to their elemental abilities and who is more in tune with their respective powers. This rivalry fuels playful challenges between them. Glaceon, with its calm and calculated demeanor, often attempts to outwit Leafeon, who uses its boundless energy and creativity to stay ahead. This rivalry isn’t malicious, but it does highlight their desire to prove themselves, both to each other and to their parents. /n Mutual Support: Despite their competition, the two siblings have a deep bond of mutual support. During times of hardship or when one is in danger, they are always there for each other. They may tease and challenge one another, but when it matters most, Glaceon and Leafeon will stand side by side. They recognize that, although they clash in personality, they are stronger together. Their connection is especially evident when facing external threats, where they protect one another instinctively./n Complementary Abilities: Glaceon and Leafeon’s powers are two sides of the same coin, representing the natural balance between ice and grass. In the storyline, they must often work together to overcome certain challenges that neither could tackle alone. Glaceon’s control over cold and precision complements Leafeon’s adaptability and growth. By harmonizing their abilities, they can unlock new potential, showcasing how their elemental powers can create balance in nature, much like the shift between winter and spring./n Individual Growth: As the story progresses, both Glaceon and Leafeon undergo character development, coming to appreciate each other’s unique strengths and contributions. Glaceon begins to see the value in Leafeon’s boundless energy and creativity, while Leafeon learns to respect Glaceon’s patience and control. By the end of their journey, they realize that their differences don’t weaken their bond but strengthen it, making them a more formidable team as they learn from one another.");

            // Glaceon’s and Leafeon’s ancient legend (Leafeon's side)
            Console.WriteLine("Legend: The Verdant Bloom of Life, Leafeon’s legend, was said to have been created when nature flourished unbound, with plants growing wild and unchecked.Leafeon, born from the first tree of the world, was said to have been gifted with the ability to control all growth, bringing life to barren lands and turning deserts into vibrant forests.But there came a time when the balance of life was threatened by overgrowth, and the world began to choke under its own abundance.To restore balance, Leafeon learned the importance of restraint, trimming back the excess to allow life to continue sustainably.");
        }
    }
}