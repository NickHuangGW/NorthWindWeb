using AutoMapper;
using NorthWindPracticeWeb.Models;
using NorthWindPracticeWeb.Service.DTOs;

namespace NorthWindPracticeWeb.Mappings
{
    public class WebMapProfile : Profile
    {
        public WebMapProfile()
        {
            ViewModelToDto();
            DtoToViewModel();
        }
        /// <summary>
        /// Views the model to dto.
        /// </summary>
        private void ViewModelToDto()
        {
            CreateMap<CustomerViewModel, CustomerDto>();
        }
        /// <summary>
        /// Dtoes to view model.
        /// </summary>
        private void DtoToViewModel()
        {
            CreateMap<CustomerDto, CustomerViewModel>();
        }
    }
}