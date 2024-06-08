using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication11.Models;      // add
using WebApplication11.Repository;  // add

namespace WebApplication11.Service
{
    internal interface INewsGroupService : IGenericService<NewsGroup>
    {
        int NextNewsGroupId();
    }
}
