using ECommerce.Database;

using AutoMapper;
namespace ECommerce.Services.Automapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<UserInformationDTO, UserInformation>().ReverseMap();
    }
}