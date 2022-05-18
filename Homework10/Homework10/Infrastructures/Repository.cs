using Homework10.Interfaces;
using Homework10.Models;

namespace Homework10.Infrastructures
{
    public class Repository : IRepository
    {
        private readonly HomeworkDb _context = new HomeworkDb();

        void IRepository.AddMember(Member member)
        {

            _context.Members.Add(member);
            _context.SaveChanges();
        }
        void IRepository.AddLibrary(Library library)
        {

            _context.Libraries.Add(library);
            _context.SaveChanges();
        }
        void IRepository.AddBook(Book book)
        {

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        List<Member> IRepository.GetAllMembers()
        {
            return _context.Members.ToList();
        }
        List<Library> IRepository.GetAllLibraries()
        {
            return _context.Libraries.ToList();
        }

        List<City> IRepository.GetAllCities()
        {
            return _context.Cities.ToList();
        }

        List<Book> IRepository.GetAllBooks()
        {
            return _context.Books.ToList();
        }


        Member IRepository.GetMemberDetail(int id)
        {
            return _context.Members.FirstOrDefault(x => x.Id == id);
        }



        void IRepository.DeleteMember(int id)
        {
            var member = _context.Members.FirstOrDefault(x => x.Id == id);
            _context.Remove(member);
            _context.SaveChanges();
        }




        void IRepository.UpdateMember(Member member)
        {
            _context.Update(member);
            _context.SaveChanges();

        }

    }
}
