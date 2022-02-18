using System;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
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
            string serie = "";
            serie += "Título: " + Titulo + Environment.NewLine;
            serie += "Descrição: " + Descricao + Environment.NewLine;
            serie += "Gênero: " + Genero + Environment.NewLine;
            serie += "Ano: " + Ano + Environment.NewLine;
            serie += "Título: " + Titulo + Environment.NewLine;
            serie += "Excluido: " + Excluido + Environment.NewLine;
            return serie;
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
