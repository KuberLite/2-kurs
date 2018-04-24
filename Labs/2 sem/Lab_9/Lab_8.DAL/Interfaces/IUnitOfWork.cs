using Lab_8.DAL.EF;

namespace Lab_8.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        DBContext context { get; }

        IAnimalRepository AnimalRepository { get; }

        void SaveChanges();
    }
}