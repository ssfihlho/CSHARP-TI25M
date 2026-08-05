using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioControl
    {
        ExercicioModel modelo;//Conectando a Classe Model e Control
        private int opcao;

        public ExercicioControl()
        {
            this.modelo = new ExercicioModel();
            this.opcao = 0;
            SetOpcao(0);

        }//Construtor Padrão

        public int GetOpcao()
        {
            return this.opcao;
        }//fim do GetOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }//fim do set
        public void Coletar()
        {
            //Peguei os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para o construtor com parâmetro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletar = Pega os dois números digitados
        // mostrar as opçoes de operação na tela

        public void ColetarReal()
        {   // pegar dois números
            Console.WriteLine("Informe o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            this.modelo = new ExercicioModel(num1, num2);
        }
        public void Menu()
        {
            Console.WriteLine("\n escolha uma das opções abaixo: \n" +
                              " 0. Sair\n"                           +
                              " 1. soma\n"                           +
                              " 2. Subtração\n"                      +
                              " 3. Divisão\n"                        +
                              " 4. Multiplicação\n"                  +
                              " 5. Potência\n"                       +
                              " 6.Potência com Parâmetros\n"         +
                              " 7.Raiz\n"                            +
                              " 8. Raiz com Parâmetros\n");
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//limpa console
        }//fim do menu



        //executar o menu
        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostrar as opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine(" Obrigado!");
                        break;
                    case 1:
                        Coletar();//pegar os dois numeros
                        Console.WriteLine(" A soma é: " + this.modelo.Somar());//Fazer a operação de soma
                        break;// finalizar o case
                    case 2:
                        Coletar();
                        Console.WriteLine(" A Subtração é: " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //Validação
                        if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine(" Imposssivel Dividir por número negativo!");
                        }
                        else
                        {
                            Console.WriteLine(" A Divisão é: " + this.modelo.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine(" A Multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("A Potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas,expoente));
                        break;
                    default:
                        Console.WriteLine(" Opção escolhida não é valida!");
                        break;

                    

                }//fim escolha
            } while (GetOpcao() != 0); //fim do do...while








        }//fim do método executar menu



    }//fim da classe
}//fim do projeto
