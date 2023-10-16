using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStoreAPI.DTO.User.Request;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Service.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepository userRepository, IMapper mapper,IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task ActivateUserAsync(int id)
        {
            var user = await _userRepository.ActivateUserByIdAsync(id);
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeactivateUserAsync(int id)
        {
            var user = await _userRepository.DeactivateUserByIdAsync(id);
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<GetUserDto> FindUserByIdAsync(int id)
        {
            var user = await _userRepository.FindUserByIdAsync(id);
            var userDto = _mapper.Map<GetUserDto>(user);
            return userDto;
        }

        public async Task<List<GetUserDto>> GetAllUsersAsync()
        {
            var user = _userRepository.GetAll().ToList();
            var userDto = _mapper.Map<List<GetUserDto>>(user);
            return userDto;
        }
        public async Task AddUserAsync(AddUserDto addUser)
        {
            var user = _mapper.Map<User>(addUser);
            await _userRepository.AddAsync(user);
            await _unitOfWork.CommitAsync();
        }
        public async Task MakeAdminUserAsync(string username)
        {
            var user = await _userRepository.MakeAdminAsync(username);
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }
        public async Task SoftDeleteUserAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            _userRepository.Remove(user);
            await _unitOfWork.CommitAsync();
        }
    }
}
