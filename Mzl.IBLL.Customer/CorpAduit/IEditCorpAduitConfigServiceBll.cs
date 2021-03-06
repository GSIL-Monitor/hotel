﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Customer.CorpAduit;
using Mzl.Framework.Base;

namespace Mzl.IBLL.Customer.CorpAduit
{
    public interface IEditCorpAduitConfigServiceBll : IBaseServiceBll
    {
        bool EditCorpAduitConfig(CorpAduitConfigModel model);
        bool DeleteCorpAduitConfig(List<int> configIdList);
    }
}
