
using Model.DomainModels;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region [ -Insert ()- ]

        public void Insert(Person person)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Add(person);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while inserting the person.", ex);
            }
        }

        #endregion

        #region [ -Update ()- ]

        public void Update(Person person)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Update(person);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while updating the person.", ex);
            }
        }

        #endregion

        #region [ -Delete ()- ]

        public void Delete(Person person)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Remove(person);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while deleting the person.", ex);
            }
        }

        #endregion

        #region [ -SelectAll ()- ]

        public List<Person> SelectAll()
        {
            try
            {
                using var context = new ProjectDbContext();

                return context.Person.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while retrieving persons.", ex);
            }
        }

        #endregion
    }
}
