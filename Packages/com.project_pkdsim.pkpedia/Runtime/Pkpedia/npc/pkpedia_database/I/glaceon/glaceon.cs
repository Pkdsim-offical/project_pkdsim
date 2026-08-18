using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Glaceon
{
    public class GlaceonDex : MonoBehaviour
    {

        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Glaceon();
        }

        private void Glaceon()
        {
            Console.WriteLine("Personality: Glaceon has a calm and nurturing character who enjoys helping others. She can be a bit introverted but is always there to offer a listening ear and support to her friends. Glaceon's personality revolves around themes of wisdom, empathy, and a love for wintery activities like snowboarding or ice skating");
            Console.WriteLine("Parental Relationship: Glaceon's Mother, a Roserade, she taught both Glaceon and Leafeon about the balance between strength and beauty in nature.Though she favored Leafeon’s natural alignment with her own love for plants, she respected Glaceon’s patience and calm demeanor, helping Glaceon understand the importance of balance even in icy environments./n Father, a Abomasnow was a powerful influence on Glaceon, showing it how to master the cold and embrace its frosty abilities.Abomasnow encouraged Glaceon’s independence and taught it the value of endurance in harsh conditions, but he also had a soft spot for Leafeon, enjoying its more cheerful nature, which occasionally caused tension between the siblings.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Glaceon has a backstory is related to her affinity for the cold. She grew up in a snowy mountain town, honing her species' ice powers and learning from the older generations. Her species has a strong sense of duty to protect her home from environmental threats or wild Pokémon that disrupt the peace of her community.");

            // siblings
            Console.WriteLine("Glaceon and Leafeon sibling relationship: The relationship between Glaceon and Leafeon has sibling rivalry /n Rivalry: Glaceon and Leafeon engage in friendly competition, especially when it comes to their elemental abilities and who is more in tune with their respective powers. This rivalry fuels playful challenges between them. Glaceon, with its calm and calculated demeanor, often attempts to outwit Leafeon, who uses its boundless energy and creativity to stay ahead. This rivalry isn’t malicious, but it does highlight their desire to prove themselves, both to each other and to their parents. /n Mutual Support: Despite their competition, the two siblings have a deep bond of mutual support. During times of hardship or when one is in danger, they are always there for each other. They may tease and challenge one another, but when it matters most, Glaceon and Leafeon will stand side by side. They recognize that, although they clash in personality, they are stronger together. Their connection is especially evident when facing external threats, where they protect one another instinctively./n Complementary Abilities: Glaceon and Leafeon’s powers are two sides of the same coin, representing the natural balance between ice and grass. In the storyline, they must often work together to overcome certain challenges that neither could tackle alone. Glaceon’s control over cold and precision complements Leafeon’s adaptability and growth. By harmonizing their abilities, they can unlock new potential, showcasing how their elemental powers can create balance in nature, much like the shift between winter and spring./n Individual Growth: As the story progresses, both Glaceon and Leafeon undergo character development, coming to appreciate each other’s unique strengths and contributions. Glaceon begins to see the value in Leafeon’s boundless energy and creativity, while Leafeon learns to respect Glaceon’s patience and control. By the end of their journey, they realize that their differences don’t weaken their bond but strengthen it, making them a more formidable team as they learn from one another.");

            // Glaceon’s and Leafeon’s ancient legend (glaceon's side)
            Console.WriteLine("Legend: The Frozen Veil of Winter: Once, in the age of endless seasons, there was a time when the world was consumed by unrelenting cold. Glaceon, born from the northern winds, was said to be the child of winter itself, tasked with shielding the land from the ravages of endless frost.According to legend, Glaceon held the power to command the cold and cover the earth in a protective veil of ice to preserve life beneath.Yet, its heart was torn, for the chill that safeguarded the world could also threaten to smother it.Glaceon’s eternal battle was to balance frost’s protection with nature’s life, always ensuring that winter would come but never last forever.");
        }
    }
}