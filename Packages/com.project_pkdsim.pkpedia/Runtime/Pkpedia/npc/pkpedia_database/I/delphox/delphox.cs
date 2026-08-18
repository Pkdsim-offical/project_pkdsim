using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Delphox
{
    public class DelphoxDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Delphox();
        }
        
        private void Delphox()
        {
            Console.WriteLine("Personality: Delphox, has a wise and mystical character who possesses great knowledge and foresight. she excel in understanding the mysteries of the world and have a strong desire to share her wisdom with others.");
            Console.WriteLine("Parental Relationship: Delphox a close relationship with her grandmother, a revered oracle or wise sage, who passed down her knowledge of ancient secrets and the importance of using psychic abilities for the greater good. her grandparent could have shared tales of foretelling important events and guiding the community.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Delphox has a backstory tied to her role as a guardian of knowledge and foresight. she was chosen as the keeper of ancient scrolls, tasked with interpreting and safeguarding this valuable information for her community.");
        }
    }
}