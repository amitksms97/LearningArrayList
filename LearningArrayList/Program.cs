using System;
using System.Collections;

namespace LearningArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("Some String");
            
            int i = 123;
            object o = i;
            i = (int)o;

            String s = (String)list[0];

        }
    }
}
