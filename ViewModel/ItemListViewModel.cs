using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.ViewModel
{
    public class ItemListViewModel 
    {
        public IEnumerable<Item> Itens {get;set;}
        public string CategoriaAtual {get;set;}
    }
}