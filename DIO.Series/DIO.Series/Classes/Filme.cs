using System;

namespace DIO.Series.Classes
{
    // Basaeada na classe Serie
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = Id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string filme = "";
            filme += "Título: " + Titulo + Environment.NewLine;
            filme += "Descrição: " + Descricao + Environment.NewLine;
            filme += "Gênero: " + Genero + Environment.NewLine;
            filme += "Ano: " + Ano + Environment.NewLine;
            filme += "Título: " + Titulo + Environment.NewLine;
            filme += "Excluido: " + Excluido + Environment.NewLine;
            return filme;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return Excluido;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
