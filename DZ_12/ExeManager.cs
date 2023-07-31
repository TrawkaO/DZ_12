using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12
{
    public class ExeManager
    {
        public Dictionary<Opera, Func<int>> FuncExe { get; set; }
        private Func<int> sumDelegate;
        private Func<int> subtractDelegate;
        private Func<int> MultiplyDelegate;

        public void PopulateFunctions(Func<int> sun, Func<int> multiply, Func<int> sub)
        {
            sumDelegate = sun;
            subtractDelegate = multiply;
            MultiplyDelegate = sub;
            PrepareExecution();
        }

        public void PrepareExecution()
        {
            FuncExe = new Dictionary<Opera, Func<int>>();

            FuncExe.Add(Opera.Sun, sumDelegate);
            FuncExe.Add(Opera.Multiply, subtractDelegate);
            FuncExe.Add(Opera.Sub, MultiplyDelegate);

        }
    }
}
