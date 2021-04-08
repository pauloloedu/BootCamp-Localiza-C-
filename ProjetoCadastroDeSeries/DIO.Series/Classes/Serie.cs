using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Método construtor da classe
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0#System_Environment_NewLine
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine; //Environment.NewLine pega como o sistema entende a quebra de liha e gera ela sem precisar ficar digitando /n
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornarTitulo()
        {
            return this.Titulo;
        }

        public int retonrarId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}