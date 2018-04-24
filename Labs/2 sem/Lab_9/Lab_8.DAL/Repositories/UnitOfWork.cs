using Lab_8.DAL.EF;
using Lab_8.DAL.Interfaces;

namespace Lab_8.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;
        private readonly IAnimalRepository _animalRepository;

        public UnitOfWork(DBContext context)
        {
            _context = context;
            _animalRepository = new AnimalRepository(_context);
        }

        public DBContext context => _context;

        public IAnimalRepository AnimalRepository => _animalRepository;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}