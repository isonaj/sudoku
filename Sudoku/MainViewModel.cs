using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class MainViewModel
    {
        public List<List<int>> Values { get; set; }

        public MainViewModel()
        {
            Values = new List<List<int>> {
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 },
                new List<int> { 1, 3, 4, 5, 2, 8, 7, 6, 9 }
            };
        }
    }
}
