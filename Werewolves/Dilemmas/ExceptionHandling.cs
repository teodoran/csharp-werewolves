using System;
using System.Collections.Generic;
using System.Text;

namespace Werewolves.Dilemmas
{
    class Class2
    {
        private dynamic _logger;

        public Class2(dynamic logger){
            _logger = logger;
        }
        public dynamic ThisCouldFail()
        {
            throw new Exception();
        }

        public dynamic HandleException1()
        {
            return ThisCouldFail();
        }

        public dynamic HandleException2()
        {
            try
            {
                return ThisCouldFail();
            }
            catch (Exception e)
            {
                _logger.Log(e);
                throw new Exception("MyException", e);
            }
        }

        public dynamic HandleException3()
        {
            try
            {
                return ThisCouldFail();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
