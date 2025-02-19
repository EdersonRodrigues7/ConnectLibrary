using ConnectLibrary.Application.UseCases.User.Responses;
using MediatR;

namespace ConnectLibrary.Application.UseCases.User.Requests;

public record CreateUserRequest(string Username, string Email, string Password): IRequest<DefaultUserResponse>;