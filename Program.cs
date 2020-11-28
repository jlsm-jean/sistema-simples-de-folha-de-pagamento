using System;

namespace Cap._02_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            double ht, vh, dd, pd, sb, td, sl;

            /// ht = Horas trabalhadas
            /// vh = Valor da hora
            /// dd = Desconto
            /// pd = Desconto em Percentual
            /// sb = Salario base
            /// td = total de desconto
            /// sl = salario liquido

            Console.WriteLine("Bem-Vindo ao Sistema JLSM - Folha de Pagamento");

            Console.WriteLine("Para Calcular a sua Folha de Pagamento, Preenchar as Informações Abaixo: ");

            Console.Write("Horas trabalhadas:    ");
            ht = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora:       ");
            vh = float.Parse(Console.ReadLine());
            Console.Write("Percentual de desconto:       ");
            dd = float.Parse(Console.ReadLine());

            sb = ht * vh;
            pd = dd / 100;
            td = pd * sb;
            sl = (sb - td);

            Console.WriteLine();
            Console.Write("Salario Liquido:  ");
            Console.WriteLine(sl.ToString("F2"));

        }
    }
}
