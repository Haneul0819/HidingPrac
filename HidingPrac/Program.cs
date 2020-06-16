using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingPrac
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
            public virtual void Method()
            {
                Console.WriteLine("부모메서드입니다.");
            }
        }

        class Child : Parent
        {
            public new string variable = "shadowing";
            public override void Method()
            {
                Console.WriteLine("자식메서드입니다.");
            }
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(" c = " + c.variable);
            c.Method();
            Console.WriteLine(" 부모취급 c = " + ((Parent)c).variable);
            ((Parent)c).Method();
        }
    }
}
