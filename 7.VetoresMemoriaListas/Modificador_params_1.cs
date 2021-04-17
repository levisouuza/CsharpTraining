//Modificador de parametros : params

//Utilizados para quando for necessário passar uma quantidade parâmetros indefinidos.

//Solucao_1

namespace Course{
    class Calculator{
        public static int Sum(int[] numbers){

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            return sum;
        }
    }
}


int  result = Calculator.Sum(new int[] {10, 20, 30, 40});


//Solucao_2


namespace Course{
    class Calculator{
        public static int Sum(params int[] numbers){

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            return sum;
        }
    }
}


int  result = Calculator.Sum(10, 20, 30, 40);