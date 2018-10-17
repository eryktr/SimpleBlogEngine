using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.DAL
{
    interface IBlogRepository
    {
        IEnumerable<IEntity> ListAll(IEntity obj);
        void Add(IEntity obj);
    }
}
