namespace HexGridProject.HexGrid
{
    public class Hex
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public bool IsOccupied { get; set; }

        public Hex(int col, int row, bool isOccupied = false)
        {
            Col = col;
            Row = row;
            IsOccupied = isOccupied;
        }
    }
}
