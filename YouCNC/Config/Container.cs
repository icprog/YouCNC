using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Service;
using YouCNC.Service.Interfaces;

namespace YouCNC.Config
{
    public class DIContainer
    {
        private static CncService messager = null;
        public static CncService GetServiceInstance()
        {
            if (messager == null)
            {
                return new CncService();
            }
            return messager;
        }
    }
}
