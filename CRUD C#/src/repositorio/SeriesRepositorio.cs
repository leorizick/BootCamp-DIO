
using Dioflix.src.entities;

namespace Dioflix.src.Repositorio;

internal class SeriesRepositorio : MidiaRepositorio<Serie>
{

    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
        listaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
        listaSerie[id].Exclui();
    }

    public void Insere(Serie objeto)
    {
        listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
        return listaSerie;
    }

    public int ProximoId()
    {
        return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
        return listaSerie[id];
    }
}
