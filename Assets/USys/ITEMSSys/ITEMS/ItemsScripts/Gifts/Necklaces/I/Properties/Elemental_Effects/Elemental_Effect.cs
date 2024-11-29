using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.I.Elemental_Effect
{
    public class Elemental_Effect : MonoBehaviour
    {
        public string SuperEffective { get; private set; } = "";
        public string Effective { get; private set; } = "";
        public string NotVeryEffective { get; private set; } = "";

        public void LoadElementalEffect(string value)
        {
            LoadSuperEffective(value);
            LoadEffective(value);
            LoadNotVeryEffective(value);
        }

        public void LoadSuperEffective(string value)
        {
            SuperEffective = value + SuperEffective;
            Debug.Log("SuperEffective value updated to: " + SuperEffective);
        }

        public void LoadEffective(string value)
        {
            Effective = value + Effective;
            Debug.Log("Effective value updated to: " + Effective);
        }

        public void LoadNotVeryEffective(string value)
        {
            NotVeryEffective = value + NotVeryEffective;
            Debug.Log("NotVeryEffective value updated to: " + NotVeryEffective);
        }
    }
}
