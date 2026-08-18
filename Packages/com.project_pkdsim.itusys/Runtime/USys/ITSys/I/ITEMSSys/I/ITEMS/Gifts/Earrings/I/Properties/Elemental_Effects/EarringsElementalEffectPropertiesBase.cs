using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Elemental_Effect
{
    public class EarringsElementalEffectPropertiesBase : MonoBehaviour
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
