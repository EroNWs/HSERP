using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.Customer
{
    public record CustomerVM(string code, string name, string taxOffice, string taxNumber, string phone, string address, string city, string country) : IViewModel;

    public record CustomerCountryVM(string country);


    public record CustomerTaxVM(string taxNumber);


    public record CustomerOrderDateVM(DateTime orderDate);

}
