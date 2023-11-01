namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            DoSomething(out valor);

            Console.WriteLine(valor);
            
            void DoSomething(out int number) //daqui o valor sobe para variavel valor
            {
                number = 123;
            }


            void Increment(ref int number)
            {
                number++;
            }

            int number = 1;
            Increment(ref number);
            Console.WriteLine(number);



            static void UseParams(params int[] items)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}