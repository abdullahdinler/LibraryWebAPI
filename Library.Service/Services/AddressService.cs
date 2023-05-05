using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.AddressDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class AddressService : Service<Address, AddressDto>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IGenericRepository<Address> repository, IUnitOfWork unitOfWork, IMapper mapper, IAddressRepository addressRepository) : base(repository, unitOfWork, mapper)
        {
            _addressRepository = addressRepository;
        }

        public async Task<CustomResponseDto<List<AddressWithUserDto>>> GetAddressWithUser()
        {
            var entities = await _addressRepository.GetAddressWithUserAsync();
            var newDto = _mapper.Map<List<AddressWithUserDto>>(entities);
            return CustomResponseDto<List<AddressWithUserDto>>.Success(newDto, 200);

        }

        public async Task<CustomResponseDto<AddressDto>> AddAsync(AddressCreateDto createDto)
        {
            var entity = _mapper.Map<Address>(createDto);
            await _addressRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<AddressDto>(entity);
            return CustomResponseDto<AddressDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<AddressDto>>> AddRangeAsync(List<AddressCreateDto> createDtos)
        {
            var entities = _mapper.Map<List<Address>>(createDtos);
            await _addressRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<AddressDto>>(entities);
            return CustomResponseDto<List<AddressDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(AddressUpdateDto updateDto)
        {
            var entity = _mapper.Map<Address>(updateDto);
            _addressRepository.Update(entity);
            await _unitOfWork.CommitAsync();
          
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
