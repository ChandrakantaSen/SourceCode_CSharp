using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_GetSet
{
    class PropertyDefine
    {
        private int MyNo;

        public int MyNoProperty
        {
            get
            {
                return MyNo;
            }
            set
            {
                MyNo = value;
            }

        }

        public int MyNoProperty2
        {
            get
            {
                return MyNo;
            }
            set
            {
                MyNo = value + 10;
            }

        }

    }

    class SingleProperty
    {
        static void Main(string[] agrs)
        {
            PropertyDefine pd = new PropertyDefine();
            pd.MyNoProperty=23;

            PropertyDefine pd2 = new PropertyDefine();
            pd2.MyNoProperty2 = 30;
            Console.WriteLine("Value of MyNo is " + pd.MyNoProperty + ", " + pd2.MyNoProperty2);
            Console.ReadKey(true);

        }
    }

}
