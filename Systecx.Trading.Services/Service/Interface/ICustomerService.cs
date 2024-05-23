using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Systecx.Trading.Services.Service
{
    internal interface ICustomerService
    {
        Task<int> GetCustomerCountAsync();
        Task<List<string>> GetCustomersAsync();
    }
}
