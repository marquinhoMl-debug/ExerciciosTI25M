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

        public ExercicioControl()
        {
            this.modelo = new ExercicioModel(); 
        }//Construtor Padrão

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



    }//fim da classe
}//fim do projeto
