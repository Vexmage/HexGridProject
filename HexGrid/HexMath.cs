using System;

namespace HexGridProject.HexGrid
{
    public static class HexMath
    {
        // Function to calculate the pixel position of a hex tile
        public static (float x, float y) GetHexPosition(int q, int r, float size)
        {
            float width = size * (float)Math.Sqrt(3); // Horizontal distance
            float height = size * 1.5f;               // Vertical spacing for flat-top hexes


            // Apply horizontal offset for even rows
            float x = width * q + (r % 2) * (width / 2);
            float y = height * r;

            return (x, y);
        }



    }
}
