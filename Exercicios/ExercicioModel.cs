using System;

using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

using System.Runtime.Remoting.Messaging;

using System.Text;

using System.Threading.Tasks;

namespace Exercicios

{

    class Exercicio_model

    {

        //Área para declaração de variáveis globais

        private int num1;

        private int num2;

        private double num3;

        private double num4;

        private int num5;

        private int num6;

        private int num7;

        private int num8;

        private int num9;

        private int num10;

        private int num11;

        private int num12;

        private int num13;

        private int num14;

        private int hora1;

        private int hora2;

        private double lado1;

        private double lado2;

        private double lado3;

        private int resultado;

        //Método Construtor: Instância as variáveis na memória

        public Exercicio_model()

        {

            Setnum1(0);

            Setnum2(0);

            SetResultado(0);

        }//fim do método construtor

        public Exercicio_model(int num1, int num2)

        {

            Setnum1(num1);

            Setnum2(num2);

            SetResultado(0);

        }//fim do construtor

        public Exercicio_model(double num3, double num4)

        {

            Setnum3(num3);

            Setnum4(num4);

        }//fim do Getnum

        //métodos GETS e SETS

        //GET = Pegar, obter, Consultar

        //SET = Alterar, Modificar, Configurar

        public int Getnum1()

        {

            return this.num1;

        }//fim do getNum1

        public void Setnum1(int num1)

        {

            this.num1 = num1;

        }//fim do setNum1

        public int Getnum2()

        {

            return this.num2;

        }//fim do getNum2

        public void Setnum2(int num2)

        {

            this.num2 = num2;

        }//fim do setNum2

        public int GetResultado()

        {

            return this.resultado;

        }//fim do método resultado

        public double Getnum3()

        {

            return this.num3;

        }//fim do getnum3

        public void Setnum3(double num3)

        {

            this.num3 = num3;

        }//fim do Setnum3

        public double Getnum4()

        {

            return this.num4;

        }//fim do Getnum 4

        public void Setnum4(double num4)

        {

            this.num4 = num4;

        }//fim do Setnum4

        public void SetResultado(int resultado)

        {

            this.resultado = resultado;

        }//fim do método resultado

        public int Soma()

        {

            return this.num1 + this.num2;

        }//fim do método somar

        public int Subtrair()

        {

            SetResultado(Getnum1() - Getnum2());

            return GetResultado();

        }//fim do método Subtrair

        public int Multiplicar()

        {

            SetResultado(Getnum1() * Getnum2());

            return GetResultado();

        }//fim do método multiplicar

        public double Dividir()

        {

            if (Getnum2() == 0)

            {

                return -1;

            }

            else

            {

                SetResultado(Getnum1() / Getnum2());

                return GetResultado();

            }//fim do if

        }//fim do método dividir

        public double Potencial(double bas, double expoente)

        {

            return Math.Pow(bas, expoente);

        }//fim da potencia

        public double Raiz(double num)

        {

            return Math.Sqrt(num);

        }//fim da raiz

        public double Potencia()

        {

            return Math.Pow(Getnum3(), Getnum4());

        }//fim da potência sem parâmetro

        public double Potencia(double bas, double expoente)

        {

            return Math.Pow(bas, expoente);

        }//fim da potência sem parâmetro


        public double Raiznum3()

        {

            return Raiz(Getnum3());

        }//fim da Raiz

        public double Raiznum4()

        {

            return Raiz(Getnum4());

        }//fim da Raiz

        public string Exercicio01(int ano)

        {

            if (ano % 4 == 0)

            {

                return ano + " o ano é bissexto";

            }

            else

            {

                return ano + " não é bissexto";

            }

        }

        public string Exercicio02(int num5)
        {
            if (num5 >= 100 && num5 <= 200)
            {
                return num5 + " Este número está entre 100 e 200. ";
            }
            else
            {
                return num5 + " Este número está entre 100 e 200. ";
            }

        } public string Exercicio03(int num6)
        {
            if (num6 < 16)
            {
                return num6 + " você não tem idade para votar. ";
            }
            else if ((num6 >= 16 && num6 < 18) || num6 >= 70)
            {
                return num6 + " Voto facultativo.";
            }
            else
            {
                return num6 + " Você pode votar.";
            }
        }//fim Exercicio03

        public string Exercicio04(int num7)
        {
            if ((num7 >= 10 && num7 <= 18))
            {
                return num7 + " O número está dentro do intervalo. ";
            }
            else
            {
                return num7 + " O número não está dentro do intervalo";
            }
        }//fim Exercicio04

        public string Exercicio05(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10, int numeroLido)
        {
            int menor = num1;

            if (num2 < menor) { menor = num2; }
            if (num3 < menor) { menor = num3; }
            if (num4 < menor) { menor = num4; }
            if (num5 < menor) { menor = num5; }
            if (num6 < menor) { menor = num6; }
            if (num7 < menor) { menor = num7; }
            if (num8 < menor) { menor = num8; }
            if (num9 < menor) { menor = num9; }
            if (num10 < menor) { menor = num10; }

            if (numeroLido >= menor)
            {
                return "O número " + numeroLido + " está entre os 10 maiores valores.";
            }
            else
            {
                return "O número " + numeroLido + " não está entre os 10 maiores valores.";
            }
        }//fim do Exercicio 5

        public string Exercicio06(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return lado1 + lado2 + lado3 + " este é um triângulo é equilátero";
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                return lado1 + lado2 + lado2 + " este é um triângulo escaleno.";
            }
            else
            {
                return " este é um triângulo isósceles.";
            }
        }// fim do Exercício 6

        public string Exercicio07(int num11)
        {
            if (num11 == 1)
            {
                return num11 + " Hoje é Domingo";
            }
            else if (num11 == 2)
            {
                return num11 + " Hoje é segunda";
            }
            else if (num11 == 3)
            {
                return num11 + " Hoje é terça";
            }
            else if (num11 == 4)
            {
                return num11 + " Hoje é quarta";
            }
            else if (num11 == 5)
            {
                return num11 + " hoje é quarta";
            }
            else if (num11 == 6)
            {
                return num11 + " hoje é quinta";
            }
            else if (num11 == 7)
            {
                return num11 + " hoje é quinta";
            }
            else
            {
                return num11 + " O número digitado não existe";
            }
        }//fim Exercicio07

        public string Exercicio08(int num12)
        {
            int senhaCorreta = 1234;

            if (num12 == senhaCorreta)
            {
                return "Senha válida!";
            }
            else
            {
                return "Senha inválida!";
            }
        }//fim Exercicio08

        public string Exercicio09(int hora1, int hora2)
        {
            if (hora1 > hora2)
            {
                return " O Srimeiro horário é mais tarde";
            }
            else if (hora1 < hora2)
            {
                return " O Segundo horário é mais tarde";
            }
            else
            {
                return " Os horários são iguais";
            }
        }//fim Exercicio09

        public string Exercicio10(int num13, int num14)
        {
            if (num13 > num14)
            {
                return num13.ToString();
            }
            else
            {
                return num14.ToString();
            }
        }//fim Exercicio10








    }//fim da classe

}//fim do projeto

