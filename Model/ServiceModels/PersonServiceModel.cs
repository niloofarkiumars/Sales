using Model.DomainModels;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region [ -Insert ()- ]
        public void Insert(Person person)
        {
            using (var context = new ProjectDbContext())
            {
                    context.Add(person);
                    context.SaveChanges();
            }
        }
        #endregion

        #region [ -Update ()- ]
        public void Update(Person person)
        {
            using var context = new ProjectDbContext();
            context.Update(person);
            context.SaveChanges();
        }
        #endregion

        #region [ -Delete ()- ]
        public void Delete(Person person)
        {
            using var context = new ProjectDbContext();
            context.Remove(person);
            context.SaveChanges();
        }
        #endregion

        #region [ -SelectAll ()- ]
        public List<Person> SelectAll()
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it)
                    throw new Exception("An error occurred while retrieving persons.", ex);
                }
                finally
                {
                    // Ensure the context is disposed of properly
                    context.Dispose();
                }
            }
        }
        #endregion
    }
}