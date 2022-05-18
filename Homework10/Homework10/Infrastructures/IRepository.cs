using Homework10.Models;

namespace Homework10.Infrastructures
{
    public interface IRepository
    {
        void AddMember(Member product);
        void AddLibrary(Library library);
        void AddBook(Book book);
        void DeleteMember(int id);
        void UpdateMember(Member product);
        Member GetMemberDetail(int id);
        List<Member> GetAllMembers();
        List<Library> GetAllLibraries();
        List<City> GetAllCities();
        List<Book> GetAllBooks();
       

    }
}
