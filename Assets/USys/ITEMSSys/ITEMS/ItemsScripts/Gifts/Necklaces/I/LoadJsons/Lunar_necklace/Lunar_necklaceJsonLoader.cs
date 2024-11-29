using System.IO;
using Newtonsoft.Json;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.Lunar_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Properties.LoadJson.Lunar_necklace
{
    public class Lunar_necklaceJsonLoader : MonoBehaviour
    {
         private Lunar_NecklaceItem necklaceData;

        public void LoadJson()
        {
            string filePath = Path.Combine(Application.dataPath, "Resources", "Lunar_necklace.json");
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                necklaceData = JsonConvert.DeserializeObject<Lunar_NecklaceItem>(jsonContent);
                Debug.Log("Loaded Lunar_necklace data successfully.");
            }
            else
            {
                Debug.LogError("Lunar_necklace.json file not found.");
            }
        }

        // Accessing an instance of SYS_properties and LoveEffectPropertiesBase
        private int LoveSys_Normal_States(string relationshipType)
        {
            if (necklaceData == null)
            {
                Debug.LogError("Necklace data not loaded.");
                return 0;
            }

            // Ensure SYS_properties and LoveEffectPropertiesBase are correctly accessed as instances
            var properties = necklaceData.SYS_properties[0].SYS_properties;


            var effectProperty = properties.GetType().GetProperty(relationshipType);
            if (effectProperty != null)
            {
                var effectValue = effectProperty.GetValue(properties) as LoveEffectPropertiesBase;
                return effectValue != null ? int.Parse(effectValue.Positive) : 0;
            }
            if (effectProperty != null)
            {
                if (effectProperty.GetValue(properties) is LoveEffectPropertiesBase effectValue)
                {
                    return int.Parse(effectValue.Positive); // Ensure Positive is numeric
                }
                else
                {
                    Debug.LogError("Effect property is not of type LoveEffectPropertiesBase.");
                }
            }
            else
            {
                Debug.LogError($"Property '{relationshipType}' not found.");
            }

            return 0;
        }

        // Method to handle special effects
        private int LoveSys_Special_States(string pokemonType)
        {
            if (necklaceData == null)
            {
                Debug.LogError("Necklace data not loaded.");
                return 0;
            }

            if (necklaceData.SYS_properties[0].SYS_properties.LoveSpecialEffect.TryGetValue(pokemonType, out string effectValue))
            {
                return int.Parse(effectValue); // Returns the special love effect for the specified Pokemon type
            }

            return 0; // Neutral if no special effect for the type
        }

        public void LunarNecklace_LoveSys_Stager()
        {
            LoadJson();

            // Test cases to see effects applied
            int NormalExp = LoveSys_Normal_States("Love_Effect_Stranger");
            Debug.Log($"Love_EXP change for Stranger: {NormalExp}");
            int FriendExp = LoveSys_Normal_States("Love_Effect_Friend");
            Debug.Log($"Love_EXP change for Friend: {FriendExp}");
            int BestFriendExp = LoveSys_Normal_States("Love_Effect_BestFriend");
            Debug.Log($"Love_EXP change for BestFriend: {BestFriendExp}");
            int LoverExp = LoveSys_Normal_States("Love_Effect_Lover");
            Debug.Log($"Love_EXP change for Lover: {LoverExp}");
            int PartnerExp = LoveSys_Normal_States("Love_Effect_Partner");
            Debug.Log($"Love_EXP change for Lover: {PartnerExp}");
            int specialExp = LoveSys_Special_States("Zoroark");
            Debug.Log($"EXP change for Zoroark: {specialExp}");
        }
    }
}