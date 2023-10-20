using Projeto.Models;

namespace Projeto.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias{get;}
    }
}