using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Blaziken
{
    public class BlazikenDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Blaziken();
        }
        
        private void Blaziken()
        {
            Console.WriteLine("Personality: Blaziken has a courageous and honorable character with remarkable martial arts skills. She is deeply committed to upholding justice and protecting those in need. Blaziken's personality revolves around themes of valor, bravery, and a desire to fight for what's right.");
            Console.WriteLine("Parental Relationship: Mother, a Mienshao, A strict but compassionate martial artist, she trains Blaziken in self-discipline and teaches the importance of inner peace before engaging in combat. Her strength comes from focus and agility. /n Father, an Infernape, Passionate and energetic, he teaches her to embrace their fiery nature and fight with all their strength. He values determination and encourages Blaziken to give 100% in everything.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Blaziken has a backstory connected to her role as a guardian of valor and strength within her community. She has been chosen as the protector, using her martial arts skills and sense of justice to keep her community safe.");
        }

    }
}