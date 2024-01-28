using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioParse
{
    internal class Cerchio
    {
        public float r { get; set; } 

        public Cerchio() 
        {
        }
        public Cerchio(float r)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return string.Format("Cerchio R={0}", r);
        }
        public static Cerchio Parse(String s)
        {           
            float r = float.Parse(s);
            return new Cerchio(r);
        }


    }
}
