using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Braixen
{
    public class BraixenDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Braixen();
        }

        private void Braixen()
        {
            Console.WriteLine("Personality: Braixen, has a spirited and resourceful character with a love for magic and learning. she is known for her creativity and quick thinking, as well as her determination to overcome challenges. Braixen's personality revolve around themes of intelligence, charm, and a desire to uncover new mysteries.");
            Console.WriteLine("Parental Relationship: Braixen's Mother, a Ninetales, she, with her ancient knowledge and ethereal presence, taught Braixen the importance of restraint and caution with fire.She instilled in Braixen the need for balance and spiritual growth, emphasizing that power without wisdom is dangerous.Ninetales’s nurturing side made Braixen feel valued and encouraged, especially in understanding the mystical side of its abilities.She often guided Braixen to listen to the world’s hidden energies, which developed Braixen’s natural intuition and foresight. /n Father, a Delphox, he, a wise and powerful seer, encouraged Braixen to pursue greater knowledge and strength.He was more focused on pushing Braixen toward mastery of its flame powers and honing its magical abilities.While he was stern, he deeply respected Braixen’s potential, often sharing his own visions and guiding Braixen toward becoming a powerful seer in its own right.However, his drive for Braixen’s advancement sometimes made Braixen feel pressure to live up to his high expectations.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Braixen has a backstory tied to her role as a guardian of knowledge and ingenuity. she has been chosen as a protector, using her magical abilities and cleverness to solve problems and unlock hidden secrets.");
        }
    }    
}