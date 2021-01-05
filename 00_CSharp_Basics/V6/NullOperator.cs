using System;
using System.Linq;

namespace CSharp_Basics.V6
{
    public class NullOperator
    {
        void Demo(Nullable<int> id)
        {
            if(id!=null)
            {
                //logica 
            }
        }

        void DemoV6(int? id)
        {
            if(id.HasValue)
            {
                //logica                 
            }
        }

        void ArrayNull()
        {
            var ss = new string[] { "Foo", null };
            var length0 = ss [0]?.Length; 
            var length1 = ss [1]?.Length; 
            var lengths = ss.Select(s => s?.Length ?? 0);
        }
    }
}