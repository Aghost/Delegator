using System;

namespace Delegator.Lib
{
    public static class ActionLib {
        public static Action<int> PrintI= i => Console.WriteLine(i);
    }
}
