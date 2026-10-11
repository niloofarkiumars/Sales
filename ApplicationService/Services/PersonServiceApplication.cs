using ApplicationService.Dtos;
using ApplicationService.Dtos.Person;
using Model.DomainModels.Pipeline;
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
        #endregion

        #region [- Post() -]

        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                NationalId = postPersonDto.NationalId,
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName
            };
            _personServiceModel.Insert(person);
        }
        #endregion

        #region [- Put() -]

        public void Put(int id, PutPersonDto putPersonDto)
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
        #endregion

        #region [- Delete() -]

        public void Delete(int id)
        {
            _personServiceModel.Delete(id);
        }
        #endregion

    }
}

