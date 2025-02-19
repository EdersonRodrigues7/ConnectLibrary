using AutoMapper;
using ConnectLibrary.Application.UseCases.User.Requests;
using ConnectLibrary.Application.UseCases.User.Responses;
using ConnectLibrary.Domain.Interfaces;
using MediatR;

namespace ConnectLibrary.Application.UseCases.User;

public sealed class CreateUserUseCase : IRequestHandler<CreateUserRequest, DefaultUserResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserUseCase(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<DefaultUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<Domain.Entities.User>(request);
        _userRepository.Create(user);
        await _unitOfWork.Commit(cancellationToken);
        
        return _mapper.Map<DefaultUserResponse>(user);
    }
}