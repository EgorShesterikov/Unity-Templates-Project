namespace SpatialPartition
{
    public class Unit
    {
        public int X, Y;

        public Unit Prev;
        public Unit Next;

        private CustomGrid _grid;

        public Unit(CustomGrid grid, int x, int y)
        {
            _grid = grid;

            _grid.Add(this);

            X = x;
            Y = y;
        }

        public void Move(int x, int y) 
            => _grid.Move(this, x, y);
    }
}