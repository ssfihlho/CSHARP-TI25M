using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel //CONTROLA AS REGRAS
    {
        //Área para declaração de variáveis globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;

        //Método Construtor: Instância as variáveis na memória
        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);
        }//fim do método construtor


        
        public ExercicioModel(int num1, int num2)  // contrutor de inteiro
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        }//fim do construtor

        public ExercicioModel(double num1, double num2) //contrutor real
        {
            SetNum3(num1);
            SetNum4(num2);

        }// fim do construtor

        //Métodos GETS E SETS
        //GET = Pegar, Obter, Consultar
        //SET = Alterar, Modificar, Configurar
        
        
        //publico pq vai ser acessado por todos,
        //ele vai servir pra pessoas de fora ver as variaveis privadas
        public int GetNum1() 
        {
            return this.num1;
        }//fim do getNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do setNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do getNum2

        public void SetNum2(int num2)
        {
            this.num2 = num2;
        }//fim do setNum2

        public int GetResultado()
        {
            return this.resultado;
        }//fim do método

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;
        }//fim do método setResultado

        public double GetNum3()
        {
            return this.num3;
        }// fim do Getnum3

        public void SetNum3(double num3)
        {
            this.num3 = num3;
        }// fim do Setnum3

        public double GetNum4()
        {
            return this.num4;
        }// fim do Getnum4

        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }//fim do Setnum4




        public int Somar()
        {
            return this.num1 + this.num2;
        }//fim do método somar

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }//fim do método subtrair

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }//fim do multiplicar

        public double Dividir()
        {
            if (GetNum2() <= 0)
            {
                return -2;
            }
            else if (GetNum2() == 0)
            {
                return 1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do if
        }//fim do dividir

        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }//fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//fim da raiz
        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());

        }// fim do potencia parametro   

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }



        public string Exercicio01(int ano)// Declaração de variavel
        {
            if (ano % 4 == 0)
            { return ano + " é bissexto!"; }
            else { return ano + " não é bissexto!"; }
        }//Fim método ano bissexto


        public string Exercicio02(int num)
        {
            if ((num >= 100) && (num <= 200)) //&& significa "e", || significa "ou"
                { return num + " está entre 100 e 200!"; }
            else
                { return num + " não está entre 100 e 200!"; }
        }

        public string Exercicio03(int idade)
        {
            if ((idade >= 16) && (idade < 18) || (idade > 70))
            { return "Voto facultativo, você pode votar! "; }

            else if (idade>=18) 
                { return "Voto obrigatório!"; }
            else { return "Não pode votar ainda!"; }
        }


        public string Exercicio04(int interv1, int interv2, int numComp)
        {
            if ((numComp >= interv1) && (numComp <= interv2))
            { return numComp + " Está dentro do intervalo!"; }
            else { return numComp + " Não está dentro do intervalo!"; }
        }


        public string Exercicio05()
        {
            int num1, num2;
            bool achou = false;

            Console.Write("Informe um número que deseja procurar: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor " + (i + 1) + ": ");
                num2 = Convert.ToInt32(Console.ReadLine());


                if (num1 == num2)
                {
                    achou = true;
                }
            }//fim for

            if (achou)
            {
                return "'" + num1 + "'" + " O número está entre os valores informados";
            }
            else
            {
                return "'" + num1 + "'" + " O número não está dentro";
            }//fim if
        }//fim do metodo Ex05

        public void ContarParImpar()
        {
            int contarPar = 0;
            int contarImpar = 0;


            for (int i= 0; i<10; i++)
             {
                Console.Write(i + 1 + "° número ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if (num % 2 == 0)
                { contarPar++; }
                else { contarImpar++; }
             }
            Console.WriteLine("A quantidade de pares é: " + contarPar + " A quantidade de ímpares é: " + contarImpar);
        }
        public string multiploFor(int numero)
        {
            string resultado = "";
            for (int i = 1; i < 100; i++)
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";
                }//fim do if
            }//fim do for
            return resultado;
        }//fim do método

        //Leia um número e verifique se ele é palíndromo(ex: 121, 1331, 1441, 0660)
        public bool EhPalindromo(string palin)
        {
            int fim = palin.Length - 1;//Meço o tamanho de um conjunto de caracteres
            int inicio = 0;

            while (inicio < fim)
            {
                if (palin.Substring(inicio, 1) != palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;
            }//fim do while
            return true;
        }//fim do método
        public int contarDigitos(int numero)
        {
            int contador = 0;

            // Trata número negativo
            numero = Math.Abs(numero);

            // Caso o número seja 0, tem 1 dígito
            if (numero == 0)
            {
                contador = 1;
            }
            else
            {
                // Divide o número por 10 até que vire 0, contando os dígitos
                while (numero > 0)
                {
                    numero = numero / 10;
                    contador++;
                }
            }
            return contador;
        }


        public void validarSenha()
        {
            string senhaV = "1234";
            int i = 0;
            bool acesso = false;


            while (i<3)
            { Console.WriteLine("Digite a senha: ");
               string senha = Console.ReadLine();
             
                if (senha.Equals(senhaV))
                { Console.WriteLine("Login efetuado!");
                    acesso = true;
                    break;
                }

                else { 
                    i++;
                    Console.WriteLine("Senha incorreta!");
                }
            
            }

            if (!acesso)
            { Console.WriteLine("Número de tentativas excedidas!"); }

        }


        public void lerIdades()
        {
            int idadeM = 0;
            int soma = 0;
            for (int i =0 ; i<5 ;i++) 
            { Console.WriteLine("Informe a " + i + "° idade:");
               int idade = Convert.ToInt32(Console.ReadLine());
                


                if (idade >= 18)
                { soma = soma + idade;
                   idadeM = idadeM + 1;
                }
            }
            if (idadeM == 0)
            { Console.WriteLine("Nenhuma idade maior ou igual a 18 foi informada!"); }
            else { Console.WriteLine("A média das idades maiores que 18 é: " + soma / idadeM); }

        }

        public void exRep07()
        {
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32 (Console.ReadLine());

            while (num >= 0)
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                 { Console.WriteLine("Número negativo encontrado!"); }
            }

        } public void paresQuadrados()
        {
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i += 2)
            { Console.WriteLine(i * i); }
            
        }


        public void CelsiusFh()
        {
            double celsius;

            do
            {
                Console.Write("Celsius: ");
                celsius = double.Parse(Console.ReadLine());

                if (celsius != 0)
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Fahrenheit: " + fahrenheit);
                }

            } while (celsius != 0);
        }

        public void conta2050()
        {
            int contanum = 0;
            int i = 0;
            int num = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"{"Informe o "} {i} {" número:"}");
                num = int.Parse(Console.ReadLine());
                
                
                if ((num > 20) && (num < 50))
                { contanum++; }
             
            }

            Console.WriteLine($"{"Tem "} {contanum} {" números dentro do intervalo."} ");

        }

        public void contaN()
        {
            int i = 2;
            int contador = 0;   

             Console.WriteLine("Informe o valor de N: ");
             int N = int.Parse(Console.ReadLine());
            for (i = 2; contador < N; i += 2)
            {
                contador++;
                Console.WriteLine(i); }
        }

        public void Fatorial()
        {
           
       
            int resultado = 1;

            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }

            Console.WriteLine($"O fatorial de {num} é {resultado}.");

        }

        public void faixaEtaria()
        { 
        
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine("Criança");
            }

                else if ((idade >= 12) && (idade <= 17))
                { Console.WriteLine("Adolescente"); }
                    
                    else if ((idade >= 18) && (idade <= 59))
                    { Console.WriteLine("Adulto"); }
                        else 
                        { Console.WriteLine("Idoso"); }
        
        }
        public void Soma500()

        {
        
            
        
        }


}//fim da classe
}//fim do projeto
