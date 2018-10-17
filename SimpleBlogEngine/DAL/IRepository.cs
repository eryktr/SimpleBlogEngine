using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.DAL
{
    public interface IBlogRepository
    {
        IEnumerable<IEntity> ListAll<T>() where T:IEntity;
        void Add(IEntity obj);
    }
}
