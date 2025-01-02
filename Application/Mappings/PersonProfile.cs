using AutoMapper;
using VamBlazor.Client.Domain.Entities;
using VamBlazor.Client.Application.Dtos;


namespace VamBlazor.Client.Application.Mappings
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            
        }
    }
}