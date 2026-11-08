using ApplicationService.Dtos.Person;
using Model.DomainModels;
using Model.ServiceModels;

namespace ApplicationService.Services
{
    public class PersonServiceApplication
    {

        private readonly PersonServiceModel _personServiceModel;
        public PersonServiceApplication()
        {
            _personServiceModel = new PersonServiceModel();
        }

        #region [- GetAll() -]

        public List<GetPersonDto> GetAll()
        {
            try
            {
                var persons = _personServiceModel.SelectAll();
                var getPersonDtos = new List<GetPersonDto>();
                foreach (var person in persons)
                {
                    var getPersonDto = new GetPersonDto
                    {
                        Id = person.Id,
                        NationalId = person.NationalId,
                        FirstName = person.FirstName,
                        LastName = person.LastName
                    };
                    getPersonDtos.Add(getPersonDto);
                }
                return getPersonDtos;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while loading the persons.", ex);
            }
            finally
            {
                // Nothing to dispose here (the DbContext is disposed in PersonServiceModel).
                // A good place for logging or cleanup later.
            }
        }
        #endregion

        #region [- Post() -]

        public void Post(PostPersonDto postPersonDto)
        {
            try
            {
                var person = new Person()
                {
                    NationalId = postPersonDto.NationalId,
                    FirstName = postPersonDto.FirstName,
                    LastName = postPersonDto.LastName
                };
                _personServiceModel.Insert(person);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while saving the person.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

        #region [- Put() -]

        public void Put(int id, PutPersonDto putPersonDto)
        {
            try
            {
                var person = new Person()
                {
                    Id = id,
                    NationalId = putPersonDto.NationalId,
                    FirstName = putPersonDto.FirstName,
                    LastName = putPersonDto.LastName
                };
                _personServiceModel.Update(person);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the person.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

        #region [- Delete() -]

        public void Delete(DeletePersonDto deletePersonDto)
        {
            try
            {
                var person = new Person()
                {
                    Id = deletePersonDto.Id
                };
                _personServiceModel.Delete(person);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the person.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

    }
}