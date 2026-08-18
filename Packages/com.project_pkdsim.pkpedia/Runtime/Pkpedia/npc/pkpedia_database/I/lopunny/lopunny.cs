using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Lopunny
{
    public class LopunnyDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Lopunny();
        }

        private void Lopunny()
        {
            Console.WriteLine("Personality: Lopunny has a sociable and graceful character who enjoys socializing and bringing people together. She is known for her charm and the ability to make others feel at ease. Lopunny's personality revolves around themes of elegance, charm, and a love for hosting events and gatherings.");
            Console.WriteLine("Parental Relationship: Lopunny's Mother, a Gothitelle, A refined and disciplined figure, she emphasizes elegance, self-control, and responsibility. She instills in Lopunny the value of grace under pressure and emotional resilience, balancing outer beauty with inner strength. /n Father, a Lucario, Strong and dependable, he teaches Lopunny the importance of balance between inner calm and physical strength. He encourages discipline and endurance, ensuring that Lopunny doesn’t just rely on appearance but on true skill.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Lopunny has a backstory tied to her role as a host or hostess of social events within her community. she has a talent for making people feel welcome and have been entrusted with organizing and ensuring the success of various social gatherings.");
        }
    }
}