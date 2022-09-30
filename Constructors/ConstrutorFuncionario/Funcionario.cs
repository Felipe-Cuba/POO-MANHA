using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        private static int codigo;
        private string nome;
        private double salario;

        private static int contador;

        
        static Funcionario() {
            Codigo = 100;
            Contador = 0;
        }

        public Funcionario() {
            Codigo++;
            Contador++;
        }

        public static int Contador {
            get { return contador; }
            set {
                contador = value;
            }
        }

        public static int Codigo{
            get { return codigo; }
            private set { codigo = Codigo; }
        }

        public string Nome {
            get { return nome; }
            set {
                nome = value;
            }
        }

        public double Salario {
            get { return salario; }
            set {
                if (value > 0){
                    salario = value;
                } else {
                    Console.WriteLine("Salario invalido!!!");
                }
            }
        }

        public void MostrarProdutos(){
            Console.WriteLine($"\nCódigo: {codigo}\tNome do funcionário: {nome}\tSalário: {salario:c}\n");
        }

        public void CalcularAumento(double perCent){

            double aumento;
            aumento = perCent/100;
            Console.WriteLine($"Porcentagem: {perCent}\tAumento: {aumento}");
            salario = salario + (aumento*salario);

        }
    }
}