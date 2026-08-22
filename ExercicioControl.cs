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
                              " 0. Sair\n" +
                              " 1. soma\n" +
                              " 2. Subtração\n" +
                              " 3. Divisão\n" +
                              " 4. Multiplicação\n" +
                              " 5. Potência\n" +
                              " 6.Potência com Parâmetros\n" +
                              " 7.Raiz\n" +
                              " 8. Raiz com Parâmetros\n" +
                              " 9. Exercicio 01\n" +
                              " 10. Exercicio 02\n" +
                              " 11. Exercicio 03\n" +
                              " 12. Exercicio 04\n" +
                              " 13. Exercicio 05\n" +
                              " 14.Contar números pares e ímpares\n" +
                              " 15.Contar múltiplos\n" +
                              " 16.Números palindromos\n" +
                              " 17.Contar digitos \n" +
                              " 18.Validar senha \n" +
                              " 19.Ler idades \n" +
                              " 20.Número negativo \n" +
                              " 21.Pares quadrados \n" +
                              " 22.De Celsius para Fahrenheit \n" +
                              " 23. Conta números entre 20 e 50 \n" +
                              " 24. Conta pares de 'N' \n" +
                              " 25. Fatorial de um número \n" +
                              " 26. Faixa etária \n");


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
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A raiz do primeiro número é:" + this.modelo.RaizNum3());
                        Console.WriteLine("A raiz do segundo número é:" + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo numero: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("A raiz do primeiro numero é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo numero é: " + this.modelo.Raiz(num2));
                        break;
                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe um número:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio02(num));

                    break;

                    case 11:
                        Console.WriteLine("Informe sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio03(idade));
                    break;

                    case 12:
                        Console.WriteLine("Informe o primeiro número do paramêtro:");
                        int interv1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número do paramêtro:");
                        int interv2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o número que deseja comparar:");
                        int numComp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio04(interv1,interv2, numComp));
                        break;
                    case 13:
                        Console.WriteLine(this.modelo.Exercicio05());
                    break;
                    case 14:
                        this.modelo.ContarParImpar();
                    break;
                    case 15:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(this.modelo.multiploFor(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número: ");
                        string palin = Console.ReadLine();
                        if (this.modelo.EhPalindromo(palin) == false)
                        {
                            Console.WriteLine("Não é Palíndromo");
                        }
                        else
                        {
                            Console.WriteLine("É Palíndromo");
                        }
                    break;
                    case 17:
                        Console.WriteLine("Informe um número");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O número possui: " + this.modelo.contarDigitos(numero) + " digitos.");
                    break;
                    case 18:
                        this.modelo.validarSenha();
                    break;
                    case 19:
                        this.modelo.lerIdades();
                    break;
                    case 20:
                        this.modelo.exRep07();
                    break;
                    case 21:
                        this.modelo.paresQuadrados();
                    break;
                    case 22:
                        this.modelo.CelsiusFh();
                    break;
                    case 23:
                        this.modelo.conta2050();
                    break;
                    case 24:
                        this.modelo.contaN();
                    break;
                    case 25:
                        this.modelo.Fatorial();
                    break;
                    case 26:
                        this.modelo.faixaEtaria();
                    break;






                }//fim escolha
            } while (GetOpcao() != 0); //fim do do...while








        }//fim do método executar menu



    }//fim da classe
}//fim do projeto
