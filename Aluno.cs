using System;
using System.Collections.Generic;

namespace desafio
{
    class Aluno
    {
        public string Nome{get;set;}
        public string Matricula {get;set;}
        private List<double> notas;

        public List<double>Notas {
            /* Aqui utilizamos o metodo complexo pois ao inicarmos essa lista ela retornará nula e por ser uma lista 
            do tipo double isso quebrará nossa aplicação. Logo,
            utilizamos uma lógica para que se ela estiver nula criamos uma nova lista*/
            get{
                if(this.notas==null) this.notas = new List<double>();
                return this.notas;


            }set{
                this.notas = value;
            }
            }

        public double CalcularMedia(){
            double somaNotas =0.0;
            foreach(var nota in this.Notas){
                somaNotas+=nota;
            }
            return somaNotas/this.Notas.Count;
        }

        public string Situacao(){
            return this.CalcularMedia()>7? "Aprovado":"Reprovado";

        }


    }
}