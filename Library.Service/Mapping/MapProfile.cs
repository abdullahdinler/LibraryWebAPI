using AutoMapper;
using Library.Core.DTOs.AddressDTOs;
using Library.Core.DTOs.AuthorDTOs;
using Library.Core.DTOs.BookDTOs;
using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.DTOs.UserDTOs;
using Library.Core.Models;

namespace Library.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            // -------------------Address Mapping-------------------------------
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressCreateDto, Address>().ReverseMap();
            CreateMap<AddressUpdateDto, Address>().ReverseMap();
            CreateMap<Address, AddressWithUserDto>();
            

            // -------------------Author Mapping-------------------------------
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<Author, AuthorWithBookDto>();

            // -------------------Book Mapping-------------------------------
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book, BookWithAuthorDto>();

            // -------------------Borrowed Record Mapping---------------------------
            CreateMap<BorrowedRecord, BorrowedRecordDto>().ReverseMap();
            CreateMap<BorrowedRecordCreateDto, BorrowedRecord>().ReverseMap();
            CreateMap<BorrowedRecordUpdateDto, BorrowedRecord>().ReverseMap();
            CreateMap<BorrowedRecord, BorrowedRecordWithBookDto>();

            // -------------------Genre Mapping-------------------------------
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<GenreCreateDto, Genre>().ReverseMap();
            CreateMap<GenreUpdateDto, Genre>().ReverseMap();
            CreateMap<Genre, GenreWithBookDto>();

            // -------------------Returned Record Mapping-------------------------------
            CreateMap<ReturnedRecord, ReturnedRecordDto>().ReverseMap();
            CreateMap<ReturnedRecordCreateDto, ReturnedRecord>().ReverseMap();
            CreateMap<ReturnedRecordUpdateDto, ReturnedRecord>().ReverseMap();
            CreateMap<ReturnedRecord, ReturnedRecordWithBook>();
            CreateMap<ReturnedRecord, ReturnedRecordWithUser>();

            // -------------------User Mapping-------------------------------
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserCreateDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
            CreateMap<User, UserWithAddressDto>();
        }
    }
}
