using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.UserDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;
using Library.Repository.UnitOfWorks;

namespace Library.Service.Services
{
    public class UserService : Service<User, UserDto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository) : base(repository, unitOfWork, mapper)
        {
            _userRepository = userRepository;
        }

        public async Task<CustomResponseDto<List<UserWithAddressDto>>> GetUserWithAddress()
        {
            var entities = await _userRepository.GetUserWithAddress();
            var newDto = _mapper.Map<List<UserWithAddressDto>>(entities);
            return CustomResponseDto<List<UserWithAddressDto>>.Success(newDto,200);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UserUpdateDto updateDto)
        {
            var entity = _mapper.Map<User>(updateDto);
            _userRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<UserDto>> AddAsync(UserCreateDto addDto)
        {
            var entity = _mapper.Map<User>(addDto);
            await _userRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<UserDto>(entity);
            return CustomResponseDto<UserDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<UserDto>>> AddRangeAsync(List<UserCreateDto> addDtos)
        {
            var entities = _mapper.Map<List<User>>(addDtos);
            await _userRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<UserDto>>(entities);
            return CustomResponseDto<List<UserDto>>.Success(newDto, 201);
        }
    }
}
