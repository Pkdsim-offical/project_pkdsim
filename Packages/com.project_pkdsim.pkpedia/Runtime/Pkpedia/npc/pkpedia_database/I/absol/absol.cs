using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Absol
{
    public class AbsolDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Absol();
        }
        
        private void Absol()
        {
            Console.WriteLine("Personality: Absol has a vigilant and compassionate character with a strong sense of foresight. She is known for her ability to sense danger and her unwavering commitment to protecting others. Absol's personality revolves around themes of vigilance, compassion, and a desire to prevent disasters before she occur.");
            Console.WriteLine("Parental Relationship: Mother, a Zoroark, Cunning and perceptive, she teaches Absol to read the signs of the world around them, believing in the importance of intelligence and foresight. She values secrecy and sharp thinking./n Father, a Umbreon, A dark and protective figure, he instills in Absol the importance of vigilance and courage. He teaches that true power lies in knowing when to act and when to remain in the shadows.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Absol has a backstory tied to her role as a guardian of safety and foresight within her community. She has been chosen as a protector, using her keen senses to detect impending disasters and warn others, thus preventing potential harm.");
        }
    }
}