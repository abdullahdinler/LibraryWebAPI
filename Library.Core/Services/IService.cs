using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IService<TEntity , TDto> where TEntity : BaseEntity where TDto : class
    {
        Task<CustomResponseDto<TDto>> GetByIdAsync(int id);
       Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync();
        Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<CustomResponseDto<TDto>> AddAsync(TDto entity);
        Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<TDto> entities);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(TDto entity);
        Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
        Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids);
    }
}
