using Lab_8.DAL.Entities;

namespace Lab_8.DAL.Interfaces
{
    public interface IAnimalRepository : IRepositoty<Animals, int>
    {
        Animals Search(string query);
    }
}