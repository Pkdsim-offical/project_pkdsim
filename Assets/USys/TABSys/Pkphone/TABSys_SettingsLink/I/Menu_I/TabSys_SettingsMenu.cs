using System;
using System.IO;
using System.Text;
using TMPro;
namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink.I.Menu_I
{
    public class TABSys_SettingsMenu
    {
        private TMP_Text contentText;

        public void DisplayGeneralMenu()
        {
            contentText.text = CaptureConsoleOutput(() => DisplayGeneralMenu());
        }

        public void DisplayControlsMenu()
        {
            contentText.text = CaptureConsoleOutput(() => DisplayControlsMenu());
        }
        public void DisplayAudioMenu()
        {
            contentText.text = CaptureConsoleOutput(() => DisplayAudioMenu());
        }

        public void DisplayMenu()
        {
            contentText.text = CaptureConsoleOutput(() => DisplayMenu());
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
    }
}