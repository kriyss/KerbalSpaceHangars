using System.Collections.Generic;

namespace KerbalSpaceHangars.Service
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
