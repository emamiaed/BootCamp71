namespace AhmadEmami_hw008_maktab71.Models
{
    public class PersonRepository
    {
        private static List<PersonModel> _persons = new List<PersonModel>
        {
            new PersonModel
            {
                Id = 10001,
                FName = "Ahmad",
                LName = "Emami"
            },
            new PersonModel
            {
                Id = 10002,
                FName = "Ali",
                LName = "Khalili"
            },

            new PersonModel
            {
                Id = 10003,
                FName = "Mohammad",
                LName = "Shahsavari"
            },

            new PersonModel
            {
                Id = 10004,
                FName = "Hamed",
                LName = "Abedini"
            },

            new PersonModel
            {
                Id = 10005,
                FName = "Samaneh",
                LName = "Soltani"
            }
        };

        public static List<PersonModel> GetAllPersons()
        {
            return _persons;
        }
        public PersonModel GetPersonDetails(int PersonId)
        {
            return _persons.Where(a => a.Id == PersonId).FirstOrDefault();
        }
        public PersonModel DeletePerson(int personId)
        {
            var person =GetPersonDetails (personId);
            _persons.Remove(person);
            return person;

        }
    }
}
