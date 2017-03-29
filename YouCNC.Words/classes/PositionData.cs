using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Words
{
    public class PositionData : EventArgs, IPositionData
    {
        public string xPopsition { get; set; }
        public string yPosition { get; set; }
        public string zPosition { get; set; }
    }
}
