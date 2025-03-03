
using project_pkdsim.Assets.USys.SCMSys.HOUSES.NPC.I;

namespace project_pkdsim.Assets.USys.SCMSys.HOUSES.NPC
{
    public class SCMSys_NPC_Houses
    {
        private SCMSys_NPC_HousesI SCMSys_NPC_HouseI;
        public void SCMSys_NPC_HousesI(string family)
        {
            if (SCMSys_NPC_HouseI != null)
            {
                switch (family)
                {
                    case "Ab":
                        SCMSys_NPC_HouseI.SCMSys_AbH();
                        break;
                    case "Be":
                        SCMSys_NPC_HouseI.SCMSys_BeH();
                        break;
                    case "Bl":
                        SCMSys_NPC_HouseI.SCMSys_BlH();
                        break;
                    case "Br":
                        SCMSys_NPC_HouseI.SCMSys_BrH();
                        break;
                    case "C":
                        SCMSys_NPC_HouseI.SCMSys_CH();
                        break;
                    case "Dl":
                        SCMSys_NPC_HouseI.SCMSys_DlH();
                        break;
                    case "Dr":
                        SCMSys_NPC_HouseI.SCMSys_DrH();
                        break;
                    case "FlVpJo":
                        SCMSys_NPC_HouseI.SCMSys_FlVpJoH();
                        break;
                    case "Fr":
                        SCMSys_NPC_HouseI.SCMSys_FrH();
                        break;
                    case "Garc":
                        SCMSys_NPC_HouseI.SCMSys_GarcH();
                        break;
                    case "Gard":
                        SCMSys_NPC_HouseI.SCMSys_GardH();
                        break;
                    case "H":
                        SCMSys_NPC_HouseI.SCMSys_HH();
                        break;
                    case "LeGl":
                        SCMSys_NPC_HouseI.SCMSys_LeGlH();
                        break;
                    case "Lo":
                        SCMSys_NPC_HouseI.SCMSys_LoH();
                        break;
                    case "Luca":
                        SCMSys_NPC_HouseI.SCMSys_LucaH();
                        break;
                    case "Luna":
                        SCMSys_NPC_HouseI.SCMSys_LunaH();
                        break;
                    case "Me":
                        SCMSys_NPC_HouseI.SCMSys_MeH();
                        break;
                    case "No":
                        SCMSys_NPC_HouseI.SCMSys_NoH();
                        break;
                    case "Ph":
                        SCMSys_NPC_HouseI.SCMSys_PhH();
                        break;
                    case "Pr":
                        SCMSys_NPC_HouseI.SCMSys_PrH();
                        break;
                    case "Sa":
                        SCMSys_NPC_HouseI.SCMSys_SaH();
                        break;
                    case "Sl":
                        SCMSys_NPC_HouseI.SCMSys_SlH();
                        break;
                    case "T":
                        SCMSys_NPC_HouseI.SCMSys_TH();
                        break;
                    case "UE":
                        SCMSys_NPC_HouseI.SCMSys_UEH();
                        break;
                    case "Ve":
                        SCMSys_NPC_HouseI.SCMSys_VeH();
                        break;
                    case "Z":
                        SCMSys_NPC_HouseI.SCMSys_ZH();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
