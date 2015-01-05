using System;

namespace KerbalSpaceHangars.Extensions
{
    public static class RichTextExtension {

        public static String Color(this String str, String color) {
            return "<color=" + color + ">" + str + "</color>";
        }
        
        public static String Bold(this String str) {
            return "<b>" + str + "</b>";
        }

        public static String Size(this String str, int size) {
            return "<size=" + size + ">" + str + "</size>";
        }

        public static String ReturnLine(this String str) {
            return str + "\n";
        } 
    }
}
