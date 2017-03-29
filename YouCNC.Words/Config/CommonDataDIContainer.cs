using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Words.Config
{
    public class CommonDataDIContainer
    {
        private static PositionData positions = null;
        public static PositionData GetPositionDataInstance()
        {
            if (positions == null)
            {
                return new PositionData();
            }
            return positions;
        }
    }
}
