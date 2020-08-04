﻿using SoftNews.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftNews.Service.Interfaces
{
   public  interface ICategoryService
    {
        Task<List<Category>> GetCategories();
    }
}
