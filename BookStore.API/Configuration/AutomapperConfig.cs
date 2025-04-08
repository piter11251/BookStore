using AutoMapper;
using BookStore.API.DTOs.Book;
using BookStore.API.DTOs.Category;
using BookStore.Domain.Models;

namespace BookStore.API.Configuration
{
    public class AutomapperConfig: Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryEditDto>().ReverseMap();
            CreateMap<Category, CategoryResultDto>().ReverseMap();

            CreateMap<Book, BookAddDto>().ReverseMap();
            CreateMap<Book, BookEditDto>().ReverseMap();
            CreateMap<Book, BookResultDto>().ReverseMap();
        }
    }
}
