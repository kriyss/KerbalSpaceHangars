using System;
using System.IO;
using HtmlAgilityPack;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Xml.XPath;

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
