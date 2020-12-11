using System;
using POO_POLIMORFISMO.Classes;

namespace POO_POLIMORFISMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);


            
        }
    }
}
