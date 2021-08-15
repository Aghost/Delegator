using System;

namespace Delegator.Lib
{
    public static class FuncLib {
        public static Func<float, float, float, float> ConvertUnit = (x, y, val) => x * (val / y);
    }
}
