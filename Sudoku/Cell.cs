using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Cell
    {
        public string Value { get; set; }
        public bool IsLocked { get; set; }
        public string Options { get; set; }
    }
}
