﻿using Mzl.DomainModel.Flight;
using Mzl.Framework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.IBLL.Flight.DomesticRetMod
{
    public interface IGetFltDomesticModApplyViewServiceBll : IBaseServiceBll
    {
        GetModApplyModel GetModApplyView(GetModApplyQueryModel query);
    }
}