using AutoMapper;
using GerenciamentoDeTarefas.Data;
using GerenciamentoDeTarefas.Dtos;
using GerenciamentoDeTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeTarefas.Controllers;

[Route("user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [Route("register")]
    [HttpPost]
    public ActionResult<UserCreateDto> RegisterUser([FromBody] UserCreateDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        user.CreatedAt = DateTime.Now;
        user.SetPasswordHash();
        _repository.RegisterUser(user);
        _repository.SaveChanges();
        return Ok(user);
    }

    [Route("login")]
    [HttpPost]
    public ActionResult Login([FromBody] UserLoginDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        user.SetPasswordHash();
        var userFinded = _repository.Login(user);
        var userFindDto = _mapper.Map<UserLoginDto>(userFinded);
        return Ok(userFindDto);
    }

    [HttpGet]
    public ActionResult<UserReadDto> GetUsers()
    {
        var users = _repository.GetUsers();
        var userDto = _mapper.Map<List<UserReadDto>>(users);
        return Ok(userDto);
    }

    [Route("{id:int}")]
    [HttpGet]
    public ActionResult<UserReadDto> GetUser([FromRoute] int id)
    {
        var user = _repository.GetUser(id);
        var userDto = _mapper.Map<UserReadDto>(user);
        return Ok(userDto);
    }


}