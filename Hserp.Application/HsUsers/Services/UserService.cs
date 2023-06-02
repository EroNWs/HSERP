using Hserp.Application.Contracts;
using Hserp.Application.Contracts.Mappers;
using Hserp.Application.Contracts.Persistence;
using Hserp.Application.Contracts.Services;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Services;

public class UserService : IUserService
{
    private readonly IUserRepository repository;
    private readonly IUserValidator validator;
    private readonly IUserMapper userMapper;

    public UserService(IUserRepository repository,IUserValidator validator,IUserMapper userMapper)
    {
        this.repository = repository;
        this.validator = validator;
        this.userMapper = userMapper;
    }


    public async Task<UserVM> LoginAsync(UserLoginVM loginVM)
    {
        validator.Validate(loginVM);
        var entity = await repository.GetUserAsync(loginVM.userName, loginVM.password);
        return userMapper.ToViewModel(entity);
    }

    public async Task RegisterAsync(UserRegisterVM model)
    {
        validator.Validate(model);        

        await repository.AddAsync(userMapper.ToEntity(model));        

    }

    public async Task SaveAsync(UserRegisterVM model)
    {
        validator.Validate(model);
        await repository.SaveAsync(userMapper.ToEntity(model));
    }
}
