using AutoMapper;
using GerenciamentoDeTarefas.Dtos;
using GerenciamentoDeTarefas.Models;

namespace GerenciamentoDeTarefas.Helpers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<UserCreateDto, User>();
        CreateMap<User, UserCreateDto>();
        CreateMap<UserReadDto, User>();
        CreateMap<User, UserReadDto>();
        CreateMap<UserLoginDto, User>();
        CreateMap<User, UserLoginDto>();
    }
}