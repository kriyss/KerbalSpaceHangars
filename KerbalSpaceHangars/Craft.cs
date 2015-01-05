using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KspFR_HangarMod.Extensions;

namespace KspFR_HangarMod
{
    public class Craft
    {

        private const String Yellow = "#ffc600";
        private const String Green = "#a7f20d";

        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public float Rate { get; set; }
        public int NbDonwload { get; set; }
        public int DonwloadId { get; set; }

        public String GetDescriptionForBtn() {
            return ("\n" + Name.Color(Yellow).ReturnLine()
                + (" Auteur : ".Color(Green) + Author).ReturnLine()
                + (" Note : ".Color(Green) + Rate).ReturnLine()
                + (" Téléchargements : ".Color(Green) + NbDonwload).ReturnLine())
                .Size(13);
        }
       
    }
}
