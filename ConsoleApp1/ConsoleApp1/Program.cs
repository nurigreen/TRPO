using System;

namespace ConsoleApp1
{
    class Program
    {
        public class A
        {

        }

        public class B : A
        {
            public object a;
        }

        public class C : B
        {
            public object b;
            public object c;
        }

        public static void Main(String[] ars)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            B b4 = new B();
            b4.a = a1;

            C c5 = new C();
            c5.a = a2;
            c5.b = b4;
            c5.c = a3;
        }
    }
}