using System.Collections.Generic;

namespace KspFR_HangarMod.Service
{
    public class KspFrCraftInformation : ICraftInformation
    {
        List<string> ICraftInformation.RetrieveCrafts()
        {
            string urlAddress = "http://hangar.kerbalspaceprogram.fr";
            return new List<string>();
        }
    }
}
