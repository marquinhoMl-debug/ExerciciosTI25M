using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioControl
    {
        Exercicio_model modelo;//Conectando a Classe Model e Control
        private int opcao;

        public ExercicioControl()
        {
            this.modelo = new Exercicio_model();
            SetOpcao(0);
        }//Conastrutor Padrão


        private int GetOpcao()
        {
            return this.opcao;
        }//fim do GetOpção
        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }//fim do SetOpção

        public void Coletar()
        {
            //Pegue os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para o reconstrutor com parâmetro
            this.modelo = new Exercicio_model(num1, num2);
        }//fim do coletar = Pega os dois números digitados

        public void ColetarReal()
        {
            //Pegar dois números
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar o construtor que recebe reais 
            this.modelo = new Exercicio_model(num1, num2);
            //fim do coletar real
        }

        //Mostrar as opções de operação na tela
        public void menu()
        {
            Console.WriteLine("\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Soma\n" +
                              "2. Subtração\n" +
                              "3. Divisão\n" +
                              "4. Multiplicação\n" +
                              "5. Potência\n" +
                              "6. Potência com Parâmetros\n" +
                              "7. Raiz\n" +
                              "8. Raiz com Parâmetros\n" +
                              "9. Exercício 01\n" +
                              "10.Exercicio02\n" +
                              "11.Exercicio03\n" +
                              "12.Exercicio04\n" +
                              "13.Exercicio05\n" +
                              "14.Exercicio06");

            SetOpcao(Convert.ToInt32(Console.ReadLine()));
        }//fim do menu

        //Executar o menu

        public void Executarmenu()
        {
            do
            {
                menu();//mostrar as opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Coletar();//Coletar os dois números
                        Console.WriteLine("A soma é " + this.modelo.Soma());//Fazer a operação de soma
                        break;//Finalizar o case
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração é " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //Validação
                        if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel de dividir!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("A potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A Raiz do primeiro número é: " + this.modelo.Raiznum3());
                        Console.WriteLine("A Raiz do segundo número é: " + this.modelo.Raiznum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar o método que calcula a Raiz
                        Console.WriteLine("A Raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida!");
                        break;
                    case 9:
                        Console.WriteLine(" Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar resultado
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                        Console.WriteLine(" informe um numero ");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        //mostrar número
                        Console.WriteLine(this.modelo.Exercicio02(num5));
                        break;
                    case 11:
                        Console.WriteLine(" informe sua idade: ");
                        int num6 = Convert.ToInt32(Console.ReadLine());
                        //mostrar resultado
                        Console.WriteLine(this.modelo.Exercicio03(num6));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número: ");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio04(num7));
                        break;
                }//fim da escolha
            } while (GetOpcao() != 0);//fim...while
        }//fim do método executar menu


    }//fim da classe
}//fim do projeto