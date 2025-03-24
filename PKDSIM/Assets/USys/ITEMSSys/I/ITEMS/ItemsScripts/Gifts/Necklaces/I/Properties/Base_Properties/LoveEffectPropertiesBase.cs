using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties
{
    public class LoveEffectPropertiesBase : MonoBehaviour
    {
        public string Positive { get; private set; } = "";
        public string Negative { get; private set; } = "";
        public string Neutral { get; private set; } = "";

		public Dictionary<string, string> LoveSpecialEffect { get; set; } = new Dictionary<string, string>();


        public void LoadPositiveValue(string value)
        {
            Positive = value + Positive;
            Debug.Log("Positive value updated to: " + Positive);
        }

        public void LoadNegativeValue(string value)
        {
            Negative = value + Negative;
            Debug.Log("Negative value updated to: " + Negative);
        }

        public void LoadNeutralValue(string value)
        {
            Neutral = value + Neutral;
            Debug.Log("Neutral value updated to: " + Neutral);
        }

        public void LoadValues(string value)
        {
            LoadNeutralValue(value);
            LoadPositiveValue(value);
            LoadNegativeValue(value);
        }

        public void LoveSysEffect_BaseProperties(string value)
        {
            LoadValues(value);
        }
    }
}
