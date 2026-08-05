using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variáveis globais
        private int num1;
        private int num2;
        private int resultado;

        //Método Construtor: Instância as variáveis na memória
        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);
        }//fim do método construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        }//fim do construtor

        //Métodos GETS E SETS
        //GET = Pegar, Obter, Consultar
        //SET = Alterar, Modificar, Configurar
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
            if(GetNum2() <= 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do if
        }//fim do dividir



    }//fim da classe
}//fim do projeto
