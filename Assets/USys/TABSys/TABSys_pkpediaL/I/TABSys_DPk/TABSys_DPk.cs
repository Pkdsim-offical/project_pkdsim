using UnityEngine;
using TMPro;
using System;
using System.Text;
using System.IO;
namespace project_pkdsim.Assets.USys.TABSys.TSys_DPk
{
    public class TABSys_DPk : MonoBehaviour
    {
        public TMP_Text contentText; // Reference to the TextMeshPro UI element
        private Pkpedia_database pkpDatabase;

        private void Start()
        {
            pkpDatabase = GetComponent<Pkpedia_database>();
            if (pkpDatabase == null)
            {
                Debug.LogError("Pkpedia_database component not found on GameObject.");
                return;
            }
            DisplayIntroduction(); // Display introduction on start
        }

        public void DisplayIntroduction()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Introduction());
        }

        public void DisplayVaporeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Vaporeon());
        }

        public void DisplayFlareon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Flareon());
        }

        public void DisplayJolteon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Jolteon());
        }

        public void DisplayEspeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Espeon());
        }

        public void DisplayUmbreon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Umbreon());
        }

        public void DisplayGlaceon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Glaceon());
        }

        public void DisplayLeafeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Leafeon());
        }

        public void DisplaySylveon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Sylveon());
        }

        public void DisplayAbsol()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Absol());
        }

        public void DisplayBeedrill()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Beedrill());
        }

        public void DisplayBlaziken()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Blaziken());
        }

        public void DisplayBraixen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Braixen());
        }

        public void DisplayCinderace()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Cinderace());
        }

        public void DisplayDelphox()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Delphox());
        }

        public void DisplayDragapult()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Dragapult());
        }

        public void DisplayFrostlass()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Frostlass());
        }

        public void DisplayGarchomp()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Garchomp());
        }

        public void DisplayGardevoir()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Gardevoir());
        }

        public void DisplayLopunny()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Lopunny());
        }

        public void DisplayLucario()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Lucario());
        }

        public void DisplayLunala()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Lunala());
        }

        public void DisplayMeowscarada()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Meowscarada());
        }

        public void DisplayNoivern()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Noivern());
        }

        public void DisplayPheromosa()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Pheromosa());
        }

        public void DisplayPrimarina()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Primarina());
        }

        public void DisplaySalazzle()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Salazzle());
        }

        public void DisplayTsareena()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Tsareena());
        }

        public void DisplayZoroark()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Zoroark());
        }
        public void DisplayHatterene()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Hatterene());
        }

        public void DisplayVespiquen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpDatabase.Vespiquen());
        }

        private string CaptureConsoleOutput(Action action)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            TextWriter originalOut = Console.Out;
            Console.SetOut(sw);
            action();
            Console.SetOut(originalOut);
            return sb.ToString();
        }
        public void DisplayPokemon(Action displayMethod)
        {
            if (contentText != null && pkpDatabase != null)
            {
                contentText.text = CaptureConsoleOutput(displayMethod);
            }
            else
            {
                Debug.LogError("contentText or pkpDatabase is null.");
            }
        }
    }
}