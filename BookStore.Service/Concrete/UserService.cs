using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.User.Request;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Service.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepository userRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task ActivateUserAsync(int id)
        {
            var user = await _userRepository.ActivateUserByIdAsync(id);
            if (user == null)
                throw new NotFoundException($"UserId: {id} not found.");
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeactivateUserAsync(int id)
        {
            var user = await _userRepository.DeactivateUserByIdAsync(id);
            if (user == null)
                throw new NotFoundException($"UserId: {id} not found.");
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<GetUserDto> FindUserByIdAsync(int id)
        {
            var user = await _userRepository.FindUserByIdAsync(id);
            if (user == null)
                throw new NotFoundException($"UserId: {id} not found.");
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
            if (user == null)
                throw new NotFoundException($"Username: {username} not found.");
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
        }
        public async Task SoftDeleteUserAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                throw new NotFoundException($"UserId: {id} not found.");
            _userRepository.Remove(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<GetUserDto> UpdateUserAsync(int id, UpdateUserDto updateUser)
        {
            var user = await _userRepository.FindUserByIdAsync(id);
            if (user == null)
                throw new NotFoundException($"UserId: {id} not found.");

            _mapper.Map(updateUser, user);
            _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
            var userDto = _mapper.Map<GetUserDto>(user);
            return userDto;



        }

        
    }
}
