using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12
{
    public class OperaManager
    {
        private int _first;
        private int _second;
        private ExeManager executionManager;

        public OperaManager(int first, int second)
        {
            _first = first;
            _second = second;
        }

        private int Sun()
        {
            return _first + _second;
        }

        private int Sub()
        {
            return _first - _second;
        }

        private int Multiply()
        {
            return _first * _second;
        }

        public int Exe(Opera opera)
        {
            return executionManager.FuncExe[opera].Invoke();

        }
    }
}
