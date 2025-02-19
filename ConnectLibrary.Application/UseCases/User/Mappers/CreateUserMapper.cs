using AutoMapper;
using ConnectLibrary.Application.UseCases.User.Requests;
using ConnectLibrary.Application.UseCases.User.Responses;

namespace ConnectLibrary.Application.UseCases.User.Mappers;

public class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, Domain.Entities.User>();
        CreateMap<Domain.Entities.User, DefaultUserResponse>();
    }
}