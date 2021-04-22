//Modificador de parametros : ref e out

namespace Course{
    class Calculator{
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}

/////////////////////////////////////////////////////////

using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

        }
    }
}

//REF obriga a variavel ser iniciada


//////////////////////////////////////////////////////////////


namespace Course{
    class Calculator{
        public static void Triple(int origin, out int result) {
            result  = origin * 3;
        }
    }
}


///////////////////////////////////////////////////////

using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

        }
    }
}