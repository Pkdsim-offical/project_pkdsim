using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Umbreon
{
    public class UmbreonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Umbreon();
        }
        
        private void Umbreon()
        {
            Console.WriteLine("Personality: Umbreon has an enigmatic and introspective character. She is observant and has a deep connection to the night. Umbreon's personality revolves around themes of mystery, patience, and a fondness for stargazing and quiet, contemplative activities.");
            Console.WriteLine("Parental Relationship: Umbreon's Mother an Espeon, A wise and intellectual figure, she encourages insight and strategy, favoring foresight over physical strength.Her calm nature contrasts Umbreon’s protective instincts, and she admires balance but may unintentionally foster rivalry with Espeon. /n Father an Umbreon, A protective and stoic figure, who values strength and perseverance.He’s a guardian figure who teaches Umbreon the importance of duty and honor, instilling the need to shield others from harm.");
            Console.WriteLine("Backstory: Umbreon has a backstory related to its role as a guardian of a sacred nighttime place or forest. she has been chosen as the protector of her community's secrets, ensuring that the peaceful and mystical aspects of the night are preserved. This involves encounters with supernatural or mysterious phenomena.");

            // siblings
            Console.WriteLine("Umbreon and Espeon sibling relationship: The relationship between Umbreon and Espeon has sibling rivalry, but it isn't solely competitive. \n Umbreon and Espeon Sibling Relationship: \n Umbreon and Espeon, being siblings, share a complex bond. While both Pokémon are associated with celestial themes (Umbreon with the moon and Espeon with the sun), she have different personalities and strengths that complement each other. she can be split up into four parts. \n 1. Rivalry: she has friendly competition, especially when it comes to her abilities and who can be more in tune with her celestial connections. This rivalry leads to moments of playfulness and challenge. \n 2. Mutual Support: Despite her rivalry, the two siblings deeply care for each other. she are there for each other during tough times and provide support when it's needed most. she recognizes that she are stronger together. \n 3. Complementary Abilities: Emphasize how her powers are seen as two sides of the same coin, representing the balance between light and darkness. she need to work together in the storyline to solve certain challenges by harmonizing her abilities. \n 4. Individual Growth: Allow for character development where both Umbreon and Espeon come to appreciate each other's unique strengths and contributions. she learn that her differences make them stronger as a team.");

            // Umbreon’s and Espeon’s ancient legend (Umbreon's side)
            Console.WriteLine("Legend of the Eclipse Serpent: Long ago, in the heart of her community's sacred forest, an ancient legend told of the Eclipse Serpent, a mystical creature that represented the balance between light and darkness. The Eclipse Serpent had the unique ability to control the phases of the moon and bring about eclipses at will. \n The legend described how, in times of great peril, the Eclipse Serpent would emerge from the shadows, using its power to restore harmony when the world was on the brink of chaos. It was said that those who connect with the Eclipse Serpent and understand its ways would be granted wisdom and the ability to protect her community.\n The story emphasized the importance of embracing the night and understanding the interplay of light and darkness, as well as the significance of preserving the tranquility and secrets of the night. \n This legend serves as a source of inspiration and guidance for Umbreon and her sibling, helping them recognize her unique role in the community and the importance of safeguarding the night's mysteries.");
        }
    }
}