using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Library.Service.Services
{
    public class Service<TEntity, TDto> : IService<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;


        public Service(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<TDto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            var newDto = _mapper.Map<TDto>(entity);
            return CustomResponseDto<TDto>.Success(newDto, 200);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = await _repository.GetAll().ToListAsync();
            var newDto = _mapper.Map<IEnumerable<TDto>>(entities);
            return CustomResponseDto<IEnumerable<TDto>>.Success(newDto, 200);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _repository.Where(expression).FirstOrDefaultAsync();
            var newDto = _mapper.Map<IEnumerable<TDto>>(entity);
            return CustomResponseDto<IEnumerable<TDto>>.Success(newDto, 200);

        }

        public async Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var antEntity = await _repository.AnyAsync(predicate);
            return CustomResponseDto<bool>.Success(antEntity, 200);
        }

        public async Task<CustomResponseDto<TDto>> AddAsync(TDto entity)
        {
            var newEntity = _mapper.Map<TEntity>(entity);
            await _repository.AddAsync(newEntity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<TDto>(newEntity);
            return CustomResponseDto<TDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<TDto> entities)
        {
            var newEntities = _mapper.Map<IEnumerable<TEntity>>(entities);
            await _repository.AddRangeAsync(newEntities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<IEnumerable<TDto>>(newEntities);
            return CustomResponseDto<IEnumerable<TDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(TDto entity)
        {
            var newDto = _mapper.Map<TEntity>(entity);
            _repository.Update(newDto);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            _repository.Remove(entity);
            var newDto = _mapper.Map<TDto>(entity);
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            var entities =  await _repository.Where(x=>ids.Contains(x.Id)).ToListAsync();
            _repository.RemoveRange(entities);
            var newDto = _mapper.Map<IEnumerable<TDto>>(entities);
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
