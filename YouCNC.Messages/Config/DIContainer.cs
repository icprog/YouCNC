using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Messages.Config
{
    public class DIContainer
    {
        private static MessageFilter filter = null;
        private static MessageInterpreter interpreter = null;
        public static MessageFilter GetMessageFilterInstance()
        {
        if(filter==null)
        {
           return new MessageFilter();
        }
          return filter;
       }
        public static MessageInterpreter GetMessageInterpreterInstance()
        {
            if (interpreter == null)
            {
                return new MessageInterpreter();
            }
            return interpreter;
        }
    }
}
