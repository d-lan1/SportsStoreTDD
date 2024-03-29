﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsStore.Domain.Entities;
using System.Threading.Tasks;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
