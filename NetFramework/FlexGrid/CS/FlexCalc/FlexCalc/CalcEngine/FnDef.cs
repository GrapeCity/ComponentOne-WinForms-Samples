using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcEngine
{
    /// <summary>
    /// Function definition structure (delegate and parameter counts).
    /// </summary>
    internal class FnDef
    {
        public int ParmMin, ParmMax;
        public CalcEngineFunction Function;

        // ** ctor
        public FnDef(string name, int parmMin, int parmMax, CalcEngineFunction function)
        {
            ParmMin = parmMin;
            ParmMax = parmMax;
            Function = function;
        }
    }
}
