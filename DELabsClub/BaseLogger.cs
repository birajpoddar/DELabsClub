using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using NUnit.Framework;
using System.Diagnostics;

namespace DELabsClub
{ 
    public class BaseLogger
    {
        private StackTrace stack = new StackTrace();
        protected readonly ILog log;

        public string pubStr;
        internal string intStr;
        protected internal string piStr;
        protected string proStr;
    
        public BaseLogger()
        {
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure();
            log = LogManager.GetLogger(stack.GetFrame(1).GetMethod().ReflectedType.ToString());
        }
    }
}
