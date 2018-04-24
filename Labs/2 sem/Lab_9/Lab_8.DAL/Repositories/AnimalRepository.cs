using Lab_8.DAL.EF;
using Lab_8.DAL.Entities;
using Lab_8.DAL.Interfaces;
using System.Linq;

namespace Lab_8.DAL.Repositories
{
    public class AnimalRepository : Repository<Animals, string>, IAnimalRepository
    {
        public AnimalRepository(DBContext context) : base(context) { }

        public Animals Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Animals GetAnimalById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Animals Search(string query)
        {
            return _context.Animals.FirstOrDefault(a => a.nameAnimal.Contains(query));
        }
    }
}