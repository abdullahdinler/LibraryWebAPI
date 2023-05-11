using Azure;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Library.API.Filters
{
    public class NotFoundFilter<TEntity , TDto> : IAsyncActionFilter where TEntity : BaseEntity where TDto : class
    {
        private readonly IService<TEntity, TDto> _service;

        public NotFoundFilter(IService<TEntity, TDto> service)
        {
            _service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idValue = context.ActionArguments.Values.FirstOrDefault();
            if (idValue is null)
            {
               await next.Invoke();
               return;
            }
            var id = (int)idValue;
            var response = await _service.AnyAsync(x=>x.Id == id);
            if (response != null)
            {
                await next.Invoke();
                return;
            }
            context.Result = new NotFoundObjectResult(CustomResponseDto<NoContentDto>.Fail($"{typeof(TEntity).Name}({id}) not found", 404));
        }
    }
}
