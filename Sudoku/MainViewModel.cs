using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class MainViewModel
    {
        public List<List<Cell>> Values { get; set; }

        public MainViewModel()
        {
            Values = new List<List<Cell>>();
            for (int i = 0; i < 9; i++)
            {
                var inner = new List<Cell>();
                Values.Add(inner);

                for (int j = 0; j < 9; j++)
                {
                    var cell = new Cell();
                    cell.Value = (j + 1).ToString();
                    cell.IsLocked = (j % 2 == 0);

                    if (j == 3)
                    {
                        cell.Value = "";
                        cell.Options = "1,4,7";
                    }

                    inner.Add(cell);
                }
            }
        }
    }
}
