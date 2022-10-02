using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebApplication1.Models;

namespace DataAccessEF.Type_Repository
{
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PeopleContext context) : base(context) { }
        public new IEnumerable<User> Find(Expression<Func<User, bool>> expression)
        {
            return context.User.Include(u => u.Certifications).Where(expression);
        }


    }
}
