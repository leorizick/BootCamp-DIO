using Dioflix.src.enums;

namespace Dioflix.src.entities
{
    internal class Serie
    {

        private int id { get; set; }
        private int episodios { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }
        private string plataforma { get; set; }
        private Genero genero { get; set; }
        private bool excluido { get; set; }

        public Serie(int id, int episodios, string nome, string descricao, string plataforma, Genero genero)
        {
            this.id = id;
            this.episodios = episodios;
            this.nome = nome;
            this.descricao = descricao;
            this.plataforma = plataforma;
            this.genero = genero;
            this.excluido = excluido;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.nome + Environment.NewLine;
            retorno += "Descricao:  " + this.descricao + Environment.NewLine;
            retorno += "Plataforma:  " + this.plataforma + Environment.NewLine;
            return retorno;

        }
        public string retornaTitulo()
        {
            return this.nome;
        }

        public int retornaId()
        {
            return this.id;
        }

        public void Exclui()
        {
            this.excluido = true;
        }
    
    public bool retornaExcluido()
    {
        return this.excluido;
    }








}
}
