using Projeto.Context;
using Projeto.Models;
using Projeto.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Repositories
{
    public class ItemReposittory : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemReposittory(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Itens => _context.Itens.Include(c =>
        c.Categoria);
        public IEnumerable<Item> ItensEmDestaque =>
        _context.Itens.Where(m => m.Destaque).Include(c => c.Categoria);

        


        public Item GetItemById(int itemId)
        {
            return _context.Itens.FirstOrDefault(m => m.ItemId == itemId);
        }

        public Item GetItemById()
        {
            throw new NotImplementedException();
        }

    }

  
}