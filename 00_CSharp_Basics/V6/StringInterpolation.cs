using System;

namespace CSharp_Basics.V6
{
    public class StringInterpolation
    {
        void OldVersion()
        {
            var demo = string.Format("Esta es una demo: {0}", DateTime.Now);
        }

        void V6()
        {
            var demo = $"Esta es una demo: {DateTime.Now}";
        }
    }
}