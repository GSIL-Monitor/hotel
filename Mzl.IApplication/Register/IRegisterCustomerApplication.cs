﻿using Mzl.UIModel.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.IApplication.Register
{
    public interface IRegisterCustomerApplication
    {
        bool RegisterCustomer(RegisterViewModel model);
    }
}