using UnityEngine;

namespace SpatialPartition
{
    public class CustomGrid
    {
        private const int ATTACK_DISTANCE = 3;

        private const int NUM_CELLS = 10;
        private const int CELL_SIZE = 20;

        private Unit[,] _cells = new Unit[NUM_CELLS, CELL_SIZE];

        public CustomGrid()
        {
            for (int x = 0; x < NUM_CELLS; x++)
            {
                for (int y = 0; y < NUM_CELLS; y++)
                {
                    _cells[x, y] = null;
                }
            }
        }

        public void Add(Unit unit)
        {
            int cellX = (int)(unit.X / CELL_SIZE);
            int cellY = (int)(unit.Y / CELL_SIZE);

            unit.Prev = null;
            unit.Next = _cells[cellX, cellY];
            _cells[cellX, cellY] = unit;

            if(unit.Next != null)
                unit.Next.Prev = unit;
        }

        public void Move(Unit unit, int x, int y)
        {
            int oldCellX = (int)(unit.X / CELL_SIZE);
            int oldCellY = (int)(unit.Y / CELL_SIZE);

            int cellX = (int)(x / CELL_SIZE);
            int cellY = (int)(y / CELL_SIZE);

            unit.X = x;
            unit.Y = y;

            if (oldCellX == cellX && oldCellY == cellY)
                return;

            if (unit.Prev != null)
                unit.Prev.Next = unit.Next;

            if (unit.Next != null)
                unit.Next.Prev = unit.Prev;

            if (_cells[oldCellX, oldCellY] == unit)
                _cells[oldCellX, oldCellY] = unit.Next;

            Add(unit);
        }

        public void HandleMelle()
        {
            for (int y = 0; y < NUM_CELLS; y++)
            {
                for (int x = 0; x < NUM_CELLS; x++)
                {
                    HandleCell(x, y);
                }
            }
        }

        private void HandleUnit(Unit unit, Unit other)
        {
            while(other != null)
            {
                if(Vector2.Distance(new Vector2(unit.X, unit.Y), new Vector2(other.X, other.Y)) < ATTACK_DISTANCE)
                    HandleAttack(unit, other);

                other = other.Next;
            }
        }

        private void HandleAttack(Unit unit, Unit other)
            => Debug.Log($"{unit} attacked {other}!");

        private void HandleCell(int x, int y)
        {
            Unit unit = _cells[x, y];

            while(unit != null)
            {
                HandleUnit(unit, unit.Next);

                if(x > 0 && y > 0)
                    HandleUnit(unit, _cells[x -1, y - 1]);

                if(x > 0)
                    HandleUnit(unit, _cells[x - 1, y]);

                if(y > 0) 
                    HandleUnit(unit, _cells[x, y - 1]);

                if(x > 0 && y < NUM_CELLS - 1) 
                    HandleUnit(unit, _cells[x - 1, y + 1]);

                unit = unit.Next;
            }
        }
    }
}