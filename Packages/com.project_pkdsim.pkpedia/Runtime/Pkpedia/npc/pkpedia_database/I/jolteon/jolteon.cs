using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Jolteon
{
    public class JolteonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Jolteon();
        }

        private void Jolteon()
        {
            Console.WriteLine("Personality: Jolteon has an inventive and high-energy character. She is quick-thinking and always looking for new ideas and solutions. Jolteon's personality revolves around themes of energy, innovation, and a passion for pushing the boundaries of what's possible.");
            Console.WriteLine("Parental Relationship: Jolteon's Mother, a Ampharos, Calm and nurturing despite her electrical nature, she encourages control and understanding of one’s energy.She teaches Jolteon to think before acting, emphasizing patience even when dealing with volatile power. /n Father a Manectric, Fierce and energetic, he encourages Jolteon to embrace its lightning - fast speed and power.He believes in striking fast and decisively, pushing Jolteon to trust its instincts and act quickly.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Jolteon has a backstory that is connected to her role as a protector of technology and innovation. she’s been entrusted with safeguarding advanced technology within her community, ensuring that it was used for the betterment of all.");
        }
    }
}