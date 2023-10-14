using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Service.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<GetUserDto> FindUserByIdAsync(int id)
        {
            var user = await _userRepository.FindUserByIdAsync(id);
            var userDto = _mapper.Map<GetUserDto>(user);
            return userDto;
        }
    }
}
