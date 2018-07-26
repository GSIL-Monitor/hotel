﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.Framework.Base;
using Mzl.UIModel.Customer.CorpAduit;

namespace Mzl.IApplication.Customer
{
    public interface IGetAduitOrderApplication : IBaseApplication
    {
        GetAduitOrderResponseViewModel GetAuditOrder(GetAduitOrderRequestViewModel request);
    }
}