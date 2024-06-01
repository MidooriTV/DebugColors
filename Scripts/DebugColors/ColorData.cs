using UnityEngine;

namespace DebugColors
{
    [CreateAssetMenu(fileName = "ColorData", menuName = "ScriptableObjects/ColorData", order = 1)]
    public class ColorData : ScriptableObject
    {
        public Color black = HexToColor("#000000");
        public Color white = HexToColor("#FFFFFF");
        public Color darkred = HexToColor("#800000");
        public Color red = HexToColor("#FF0000");
        public Color firebrick = HexToColor("#B22222");
        public Color maroon = HexToColor("#800000");
        public Color darkgreen = HexToColor("#008000");
        public Color lime = HexToColor("#00FF00");
        public Color green = HexToColor("#00FF00");
        public Color forestgreen = HexToColor("#228B22");
        public Color limegreen = HexToColor("#32CD32");
        public Color seagreen = HexToColor("#2E8B57");
        public Color springgreen = HexToColor("#00FF7F");
        public Color yellowgreen = HexToColor("#9ACD32");
        public Color darkblue = HexToColor("#00008B");
        public Color blue = HexToColor("#0000FF");
        public Color royalblue = HexToColor("#4169E1");
        public Color dodgerblue = HexToColor("#1E90FF");
        public Color deepskyblue = HexToColor("#00BFFF");
        public Color lightsteelblue = HexToColor("#B0C4DE");
        public Color slateblue = HexToColor("#6A5ACD");
        public Color mediumorchid = HexToColor("#BA55D3");
        public Color mediumblue = HexToColor("#0000CD");
        public Color midnightblue = HexToColor("#191970");
        public Color yellow = HexToColor("#FFFF00");
        public Color gold = HexToColor("#FFD700");
        public Color lightyellow = HexToColor("#FFFFE0");
        public Color lemonchiffon = HexToColor("#FFFACD");
        public Color lightgoldenrodyellow = HexToColor("#FAFAD2");
        public Color papayawhip = HexToColor("#FFEFD5");
        public Color moccasin = HexToColor("#FFE4B5");
        public Color peachpuff = HexToColor("#FFDAB9");
        public Color palegoldenrod = HexToColor("#EEE8AA");
        public Color khaki = HexToColor("#F0E68C");
        public Color darkkhaki = HexToColor("#BDB76B");
        public Color darkorange = HexToColor("#FF8C00");
        public Color orange = HexToColor("#FFA500");
        public Color sandybrown = HexToColor("#F4A460");
        public Color peru = HexToColor("#CD853F");
        public Color tomato = HexToColor("#FF6347");
        public Color orangeRed = HexToColor("#FF4500");
        public Color darkcyan = HexToColor("#008B8B");
        public Color cyan = HexToColor("#00FFFF");
        public Color aquamarine = HexToColor("#7FFFD4");
        public Color teal = HexToColor("#008080");
        public Color lightcyan = HexToColor("#E0FFFF");
        public Color darkmagenta = HexToColor("#8B008B");
        public Color magenta = HexToColor("#FF00FF");
        public Color fuchsia = HexToColor("#FF00FF");
        public Color purple = HexToColor("#800080");
        public Color plum = HexToColor("#DDA0DD");
        public Color violet = HexToColor("#EE82EE");
        public Color gray = HexToColor("#808080");
        public Color silver = HexToColor("#C0C0C0");
        public Color dimgray = HexToColor("#696969");
        public Color slategray = HexToColor("#708090");
        public Color lightgray = HexToColor("#D3D3D3");
        public Color lavender = HexToColor("#E6E6FA");
        public Color lightcoral = HexToColor("#F08080");
        public Color pink = HexToColor("#FFC0CB");
        public Color lightpink = HexToColor("#FFB6C1");
        public Color palevioletred = HexToColor("#DB7093");
        public Color mistyrose = HexToColor("#FFE4E1");

        private static Color HexToColor(string hex)
        {
            ColorUtility.TryParseHtmlString(hex, out var color);
            return color;
        }
    }
}