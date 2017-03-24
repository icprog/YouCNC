using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Service;

namespace YouCNC.Config
{
    public static class DIContainer
    {
        private static SerialMessager messager = null;
        public static SerialMessager GetServiceInstance()
        {
            if (messager == null)
            {
                return new SerialMessager();
            }
            return messager;
        }
    }
}
