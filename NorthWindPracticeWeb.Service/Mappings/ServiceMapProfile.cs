using AutoMapper;
using NorthWindPracticeWeb.Repository.Models;
using NorthWindPracticeWeb.Service.DTOs;

namespace NorthWindPracticeWeb.Service.Mappings
{
    public class ServiceMapProfile : Profile
    {
        public ServiceMapProfile()
        {
            DbModelToDto();
            DtoToDbModel();
        }
        private void DbModelToDto()
        {
            CreateMap<Customers, CustomerDto>();
        }
        private void DtoToDbModel()
        {
            CreateMap<CustomerDto, Customers>();
        }
    }
}