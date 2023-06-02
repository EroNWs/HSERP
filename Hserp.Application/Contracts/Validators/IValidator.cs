using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hserp.Application.Contracts.ViewModels;

namespace Hserp.Application.Contracts.Validator;

public interface IValidator<T> where T : IViewModel
{
    void Validate(T viewModel);

}
