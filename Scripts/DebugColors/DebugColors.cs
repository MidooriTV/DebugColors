using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace DebugColors
{
    public static class FontStyle
    {
        private static readonly string[] Styles = { "b", "i" };
        
        private static string ConvertToHtml(string format) => $"<{format}>";

        public static string GetStyledText(string text, string style)
        {
            if (string.IsNullOrEmpty(style) || !Styles.Contains(style))
                return text;

            var prefix = ConvertToHtml(style);
            var suffix = $"</{style}>";
            return $"{prefix}{text}{suffix}";
        }
    }


    public static class Emoji
    {
        private static readonly Dictionary<string, string> Emojis = new Dictionary<string, string>
        {
            { "love", "\u2764" },
            { "sniper", "(　-_･) ︻デ═一 ▸" },
            { "bug", @"¯\_(ツ)_/¯" },
            { "acid", @"⊂(◉‿◉)つ" },
            { "bearflip", @"ʕノ•ᴥ•ʔノ ︵ ┻━┻" },
            { "blubby", "( 0 _ 0 )" },
            { "cry", @"(╥﹏╥)" },
            { "doubletableflip", @"┻━┻ ︵ヽ(`Д´)ﾉ︵ ┻━┻" },
            { "execution", @"(⌐■_■)︻╦╤─ ▸ (╥﹏╥)" },
            { "fly", @"─=≡Σ((( つ◕ل͜◕)つ" },
            { "screwit", "t(-_-t)" }
        };

        public static string GetEmoji(string text, string emoji)
        {
            emoji = emoji.Trim();
            if (!Emojis.TryGetValue(emoji, out var emojiValue)) return text;

            var spaces = Regex.Replace(text, "[^ ]", "");
            return spaces + emojiValue;
        }
    }

    public static class FontColor
    {
        private static Dictionary<string, Color> _colors;
        
        private static void InitializeColors(ColorData colorData)
        {
            _colors = new Dictionary<string, Color>
            {
                { "black", colorData.black },
                { "white", colorData.white },
                { "darkred", colorData.darkred },
                { "red", colorData.red },
                { "firebrick", colorData.firebrick },
                { "maroon", colorData.maroon },
                { "darkgreen", colorData.darkgreen },
                { "lime", colorData.lime },
                { "green", colorData.green },
                { "forestgreen", colorData.forestgreen },
                { "limegreen", colorData.limegreen },
                { "seagreen", colorData.seagreen },
                { "springgreen", colorData.springgreen },
                { "yellowgreen", colorData.yellowgreen },
                { "darkblue", colorData.darkblue },
                { "blue", colorData.blue },
                { "royalblue", colorData.royalblue },
                { "dodgerblue", colorData.dodgerblue },
                { "deepskyblue", colorData.deepskyblue },
                { "lightsteelblue", colorData.lightsteelblue },
                { "slateblue", colorData.slateblue },
                { "mediumorchid", colorData.mediumorchid },
                { "mediumblue", colorData.mediumblue },
                { "midnightblue", colorData.midnightblue },
                { "yellow", colorData.yellow },
                { "gold", colorData.gold },
                { "lightyellow", colorData.lightyellow },
                { "lemonchiffon", colorData.lemonchiffon },
                { "lightgoldenrodyellow", colorData.lightgoldenrodyellow },
                { "papayawhip", colorData.papayawhip },
                { "moccasin", colorData.moccasin },
                { "peachpuff", colorData.peachpuff },
                { "palegoldenrod", colorData.palegoldenrod },
                { "khaki", colorData.khaki },
                { "darkkhaki", colorData.darkkhaki },
                { "darkorange", colorData.darkorange },
                { "orange", colorData.orange },
                { "sandybrown", colorData.sandybrown },
                { "peru", colorData.peru },
                { "tomato", colorData.tomato },
                { "orangered", colorData.orangeRed },
                { "darkcyan", colorData.darkcyan },
                { "cyan", colorData.cyan },
                { "aquamarine", colorData.aquamarine },
                { "teal", colorData.teal },
                { "lightcyan", colorData.lightcyan },
                { "darkmagenta", colorData.darkmagenta },
                { "magenta", colorData.magenta },
                { "fuchsia", colorData.fuchsia },
                { "purple", colorData.purple },
                { "plum", colorData.plum },
                { "violet", colorData.violet },
                { "gray", colorData.gray },
                { "silver", colorData.silver },
                { "dimgray", colorData.dimgray },
                { "slategray", colorData.slategray },
                { "lightgray", colorData.lightgray },
                { "lavender", colorData.lavender },
                { "lightcoral", colorData.lightcoral },
                { "pink", colorData.pink },
                { "lightpink", colorData.lightpink },
                { "palevioletred", colorData.palevioletred },
                { "mistyrose", colorData.mistyrose },
            };
        }

        private static readonly Dictionary<string, Color> RainbowColors = new Dictionary<string, Color>
        {
            { "red", Color.red },
            { "orange", "#FFA500".ToColor() },
            { "yellow", Color.yellow },
            { "green", Color.green },
            { "lightblue", "#0000FF".ToColor() },
            { "violet", "#8B00FF".ToColor() }
        };

        private static string ConvertToHtml(Color color) => $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>";

        public static string GetColorfulText(string text, string style, ColorData colorData)
        {
            if (string.IsNullOrEmpty(style))
                return text;

            if (style == "rainbow")
            {
                return GetRainbowText(text);
            }

            if (_colors == null)
                InitializeColors(colorData);

            if (!_colors!.TryGetValue(style, out var color))
                return text;

            var prefix = ConvertToHtml(color);
            const string suffix = "</color>";
            return $"{prefix}{text}{suffix}";
        }

        private static string GetRainbowText(string text)
        {
            var message = string.Empty;
            var counter = 0;

            foreach (var c in text)
            {
                if (counter >= RainbowColors.Count) counter = 0;
                var colorKey = RainbowColors.ElementAt(counter).Key;
                var prefix = ConvertToHtml(RainbowColors[colorKey]);
                message += $"{prefix}{c}</color>";
                counter++;
            }

            return message;
        }
    }
    
    public static class DebugX
    {
        public static void Log(string input, ColorData colorData)
        {
            var parts = input.Split(';');

            var formattedText = "";

            foreach (var part in parts)
            {
                var colonIndex = part.IndexOf(':');
                if (colonIndex == -1)
                {
                    // No colon found, just append the text
                    formattedText += part + " ";
                    continue;
                }

                var emojiText = Emoji.GetEmoji(part.Substring(0, colonIndex), part.Substring(0, colonIndex));
                var groups = part.Substring(colonIndex + 1).Split(':');
            
                var style = groups.Length > 0 ? groups[0] : null;
                var colorfulText = FontColor.GetColorfulText(emojiText, groups[0], colorData); // Pass ColorData here
                var styledText = FontStyle.GetStyledText(colorfulText, style);

                formattedText += styledText + " ";
            }

            Debug.Log(formattedText.Trim());
        }
    }

    
    public static class ColorExtensions
    {
        public static Color ToColor(this string color)
        {
            if (color.StartsWith("#", StringComparison.InvariantCulture))
            {
                color = color[1..];
            }

            if (color.Length == 6)
            {
                color += "FF";
            }

            if (color.Length != 8)
            {
                throw new ArgumentException($"Invalid color format: {color}. Expected 6 or 8 hex characters.");
            }

            var hex = Convert.ToUInt32(color, 16);

            var r = ((hex >> 24) & 0xFF) / 255f;
            var g = ((hex >> 16) & 0xFF) / 255f;
            var b = ((hex >> 8) & 0xFF) / 255f;
            var a = (hex & 0xFF) / 255f;

            return new Color(r, g, b, a);
        }
    }
}