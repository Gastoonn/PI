﻿using Domain.Entities;
using ServicePatern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService : IService<Product>
    {
    }
}
