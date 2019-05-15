using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HjAbpProject.Persons.Dtos;

namespace HjAbpProject.Persons
{
    public class PersonDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            mapperConfig.CreateMap<Persons.Dtos.PersonDto, Peron.Person>();
            mapperConfig.CreateMap<PersonDtoInput, Peron.Person>();
        }
    }
}
