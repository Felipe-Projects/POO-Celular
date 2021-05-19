using System;

namespace Poo_celular
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool contatovalido = true;




            Console.WriteLine("Digite 'On' para ligar o celular!");
            string ligar = Console.ReadLine().ToUpper();
            if (ligar == "ON")
            {
                DateTime dataEntrada = DateTime.Now;

                Console.WriteLine($@"
           
            ____________________________________
           | 4G+   {dataEntrada}    100%  |
           |____________________________________|
           |                                    |
           |  1- Fazer Ligação                  |
           |                                    |                    
           |  2- Enviar Mensagem                |
           |                                    |
           |  3- Desligar                       |
           |                                    |
           |                                    |
           |                                    |
           |====================================|
 
                ");
                String Resposta = Console.ReadLine();

                switch (Resposta)
                {
                    case "1":

                        Console.WriteLine($@"
           
                ____________________________________
            | 4G+   {dataEntrada}    100%  |
            |____________________________________|
            |                                    |
            |    Escolha um contato:             |
            |                                    |                    
            |   1- Odirlei                       |
            |   2- Thiago                        |
            |                                    |
            |                                    |
            |                                    |
            |                                    |
            |====================================|
    
                    ");
                        break;

                    default:
                        Console.WriteLine("Contato Inválido!");
                        break;
                }

                string respostaligacao = Console.ReadLine();

                if (respostaligacao == "1")
                {
                    Console.WriteLine($@"
           
            ____________________________________
           | 4G+   {dataEntrada}    100%  |
           |____________________________________|
           |                                    |
           |     Ligando para Odirlei...        |
           |                                    |                    
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |====================================|
 
                ");

                    Console.WriteLine($@"
           
            ____________________________________
           | 4G+   {dataEntrada}    100%  |
           |____________________________________|
           |                                    |
           |        Chamada Encerrada!          |
           |                                    |                    
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |====================================|
 
                ");


                }
                else if (respostaligacao == "2")
                {
                    Console.WriteLine($@"
           
            ____________________________________
           | 4G+   {dataEntrada}    100%  |
           |____________________________________|
           |                                    |
           |     Ligando para Thiago...         |
           |                                    |                    
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |====================================|
 
                ");

                    Console.WriteLine($@"
           
            ____________________________________
           | 4G+   {dataEntrada}    100%  |
           |____________________________________|
           |                                    |
           |        Chamada Encerrada!          |
           |                                    |                    
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |                                    |
           |====================================|
 
                ");
                }


            }

        }

    }
}