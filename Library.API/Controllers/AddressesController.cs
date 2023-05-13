using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.AddressDTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class AddressesController : CustomBaseController
    {
        private readonly IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
           
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _addressService.GetAllAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _addressService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(AddressDto dto)
        {
            return CreateActionResult(await _addressService.AddAsync(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _addressService.RemoveAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update(AddressDto dto)
        {
            return CreateActionResult(await _addressService.UpdateAsync(dto));
        }

        [HttpGet("AddressWithUsers")]
        public async Task<IActionResult> GetAddressesWithUsers()
        {
            return CreateActionResult(await _addressService.GetAddressWithUser());
        }
    }
}
