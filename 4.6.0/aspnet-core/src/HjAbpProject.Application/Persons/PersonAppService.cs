using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using HjAbpProject.Peron;
using HjAbpProject.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Persons
{
    public class PersonAppService: HjAbpProjectAppServiceBase
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public int CreatePerson(PersonDtoInput input)
        {
            var person = Mapper.Map<Peron.Person>(input);

            var result= _personRepository.InsertAndGetId(person);
            return result;
        }

        public List<PersonDto> GetAll()
        {
            var query = _personRepository.GetAll();
            
            return Mapper.Map<List<PersonDto>>(query);
        }

        public PersonDto GetPersonById(int id)
        {
            var person = _personRepository.Get(id);

            return person.MapTo<PersonDto>();
        }

        public void UpdatePerson(PersonDto input)
        {
            var person = Mapper.Map<Peron.Person>(input);

            _personRepository.Update(person);
        }

        public void DeletePerson(EntityDto<int> input)
        {
            _personRepository.Delete(input.Id);
        }
    }
}
