using System;

namespace POO_POLIMORFISMO.Classes
{
    public class Funcionario
    {
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        } 
        
        
        // Alternativa com sintaxe reduzida
        public string Name {get ; set; }

        public string[] lista = {"Paulo", "Tsukamoto", "Prinscila", "Fernanda"};
        
        public void Mostrar(){

            foreach (var item in  lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice){

            Console.WriteLine("Busca por índice : " + lista[indice] );
        }

        public void Mostrar(string busca){

            foreach (var item in  lista)
            {
                if(item == busca){
                Console.WriteLine("Resultado da busca : " + item);
            }
        }   


       // Realizar Pagamento
       // RealizarPagamentoSemCartao(){}
       // RealizarPagamentoComCartao(string carão){}

    }  
}
}