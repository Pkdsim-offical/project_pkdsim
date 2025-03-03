using project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC
{
    public class UHTPSys_NPC_FamilyTeleporter : MonoBehaviour 
    {
        private UHTPSys_NPC_FamilyTeleporterI UHTPSys_NPC_FamilyTeleporterI;
        public void UHTPSys_NPC_FamilySceneTeleporter(string family)
        {
            if (UHTPSys_NPC_FamilyTeleporterI != null)
            {
                switch (family)
                {
                    case "Ab":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_AbH();
                        break;
                    case "Be":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_BeH();
                        break;
                    case "Bl":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_BlH();
                        break;
                    case "Br":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_BrH();
                        break;
                    case "C":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_CH();
                        break;
                    case "Dl":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_DlH();
                        break;
                    case "Dr":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_DrH();
                        break;
                    case "FlVpJo":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_FlVpJoH();
                        break;
                    case "Fr":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_FrH();
                        break;
                    case "Garc":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_GarcH();
                        break;
                    case "Gard":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_GardH();
                        break;
                    case "H":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_HH();
                        break;
                    case "LeGl":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_LeGlH();
                        break;
                    case "Lo":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_LoH();
                        break;
                    case "Luca":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_LucaH();
                        break;
                    case "Luna":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_LunaH();
                        break;
                    case "Me":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_MeH();
                        break;
                    case "No":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_NoH();
                        break;
                    case "Ph":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_PhH();
                        break;
                    case "Pr":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_PrH();
                        break;
                    case "Sa":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_SaH();
                        break;
                    case "Syl":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_SYLH();
                        break;
                    case "T":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_TH();
                        break;
                    case "UE":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_UEH();
                        break;
                    case "Ve":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_VeH();
                        break;
                    case "Z":
                        UHTPSys_NPC_FamilyTeleporterI.UHTPSys_ZH();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
