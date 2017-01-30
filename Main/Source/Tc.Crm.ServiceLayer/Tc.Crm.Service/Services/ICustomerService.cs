﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Crm.Service.Models;

namespace Tc.Crm.Service.Services
{
    public interface ICustomerService
    {
        CustomerUpdateResponse Update(Customer customer,ICrmService crmService);
    }
}