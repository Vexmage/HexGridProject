using System;

namespace HexGridProject.HexGrid
{
    public static class HexMath
    {
        /// <summary>
        /// Calculate the pixel position of a hex in doubled coordinates.
        /// </summary>
        /// <param name="col">Doubled column of the hex.</param>
        /// <param name="row">Row of the hex.</param>
        /// <param name="size">Size (radius) of the hex.</param>
        /// <returns>Pixel coordinates (x, y).</returns>
        public static (float x, float y) GetDoubledHexPosition(int col, int row, float size)
        {
            float width = size * (float)Math.Sqrt(3); // Horizontal spacing
            float height = size * 1.5f;               // Vertical spacing for flat-top hexes

            // Correct doubled coordinate calculation
            float x = col * (width / 2);  // Adjust for doubled-column layout
            float y = row * height;

            return (x, y);
        }


    }
}
