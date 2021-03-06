using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UpgradeHelpers.Helpers
{
    /// <summary>
    /// The FontHelper provides functionality for Fonts.
    /// </summary>
    public static class FontHelper
    {
        /// <summary>
        /// Gets a copy of the font, changing selected attributes.
        /// </summary>
        /// <param name="font">The font that will serve as a base for the copy.</param>
        /// <param name="name">The font's name.</param>
        /// <param name="size">The font's size.</param>
        /// <param name="gdiCharSet">The GDI character set to use.</param>
        /// <param name="bold">Indicate if the font will be bold.</param>
        /// <param name="italic">Indicate if the font will be italic.</param>
        /// <param name="underline">Indicate if the font will be underlined.</param>
        /// <param name="strikeout">Indicate if the font will be strikeout.</param>
        /// <param name="gdiVerticalFont">Indicate whether the font is derived from a GDI vertical font</param>
        /// <returns>A copy of the font, with selected attributes changed.</returns>
        public static Font Change(this Font font, string name = null, float? size = null, byte? gdiCharSet = null, bool? bold = null, bool? italic = null, bool? underline = null, bool? strikeout = null, bool? gdiVerticalFont = null)
        {
            FontStyle style = font.Style;

            if (bold.HasValue) style = bold.Value ? style | FontStyle.Bold : style & ~FontStyle.Bold;
            if (italic.HasValue) style = italic.Value ? style | FontStyle.Italic : style & ~FontStyle.Italic;
            if (underline.HasValue) style = underline.Value ? style | FontStyle.Underline : style & ~FontStyle.Underline;
            if (strikeout.HasValue) style = strikeout.Value ? style | FontStyle.Strikeout : style & ~FontStyle.Strikeout;

            return new Font(name == null ? font.Name : name,
                size.HasValue ? size.Value : font.Size, style, font.Unit,
                gdiCharSet.HasValue ? gdiCharSet.Value : font.GdiCharSet,
                gdiVerticalFont.HasValue ? gdiVerticalFont.Value : false);
        }
    }
}
