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
                              "14.Exercicio06\n" +
                              "15.Exercicio07\n" +
                              "16.Exercicio08\n" +
                              "17.Exercicio09\n" +
                              "18.Exercicio10\n");
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
                    case 13:
                            Console.Write("Informe o primeiro número: ");
                            int n1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o segundo número: ");
                            int n2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o terceiro número: ");
                            int n3 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o quarto número: ");
                            int n4 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o quinto número: ");
                            int n5 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o sexto número: ");
                            int n6 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o sétimo número: ");
                            int n7 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o oitavo número: ");
                            int n8 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o nono número: ");
                            int n9 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o décimo número: ");
                            int n10 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Informe o número que deseja verificar: ");
                            int numeroLido = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.modelo.Exercicio05(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, numeroLido));
                            break;
                        case 14:
                        Console.WriteLine("Informe o primeiro lado: ");
                        int lado1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo lado: ");
                        int lado2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o terceiro lado: ");
                        int lado3 = Convert.ToInt32(Console.ReadLine());
                        //Mostrar triângulo
                        Console.WriteLine(this.modelo.Exercicio06(lado1, lado2, lado3));
                        break;
                    case 15:

                        Console.WriteLine(" Informe um número: ");

                        int num11 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.modelo.Exercicio07(num11));

                        break;
                    case 16:
                        Console.WriteLine(" Digite a senha de 4 dígitos: ");
                        int num12 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio08(num12));
                        break;
                    case 17:
                        Console.WriteLine("Informe o primeiro horário (ex: 10:20):");
                        string[] partes1 = Console.ReadLine().Split(':');
                        int hora1 = Convert.ToInt32(partes1[0]); // O [0] pega só a hora antes dos dois pontos

                        Console.WriteLine("Informe o segundo horário (ex: 14:30):");
                        string[] partes2 = Console.ReadLine().Split(':');
                        int hora2 = Convert.ToInt32(partes2[0]); // O [0] pega só a hora antes dos dois pontos

                        string resultado = this.modelo.Exercicio09(hora1, hora2);

                        Console.WriteLine(resultado);
                        break;
                    case 18:
                        Console.WriteLine(" Informe o primeiro número: ");
                        int num13 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Informe o segundo número: ");
                        int num14 = Convert.ToInt32(Console.ReadLine());

                        string Resultado = this.modelo.Exercicio10(num13, num14);


                        Console.WriteLine(" O maior número é: " + Resultado);
                        break;

                }//fim da escolha
            } while (GetOpcao() != 0);//fim...while
        }//fim do método executar menu


    }//fim da classe
}//fim do projeto