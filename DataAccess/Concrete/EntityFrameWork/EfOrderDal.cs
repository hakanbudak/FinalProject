﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NortWindContext>,IOrderDal
    {
    }
}