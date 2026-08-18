using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Cinderace
{
    public class CinderaceDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Cinderace();
        }

        private void Cinderace()
        {
            Console.WriteLine("Personality: Cinderace has a competitive and energetic character with a strong sense of sportsmanship. She is known for her determination and drive to succeed, as well as her ability to inspire others with her passion for athletics. Cinderace's personality revolves around themes of competitiveness, athleticism, and a desire to always give her best effort.");
            Console.WriteLine("Parental Relationship: Cinderace has close relationship with her coach, a former athlete who trained them in the ways of her sport and instilled the values of sportsmanship and perseverance. her parental figure has shared stories of her own athletic achievements and the importance of never giving up on her dreams.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Cinderace has a backstory tied to her role as a guardian of sportsmanship and perseverance within her community. She has risen through the ranks of sports competitions, facing challenges and setbacks along the way, but always maintaining her spirit and determination.");
        }
    }
}