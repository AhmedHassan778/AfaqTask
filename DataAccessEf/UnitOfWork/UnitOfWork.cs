using DataAccessEF.Type_Repository;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace DataAccessEF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private PeopleContext context;
        public UnitOfWork(PeopleContext context)
        {
            this.context = context;
            Certification = new CertificationRepository(this.context);
            User = new UserRepository(this.context);

        }
        public ICertificationRepository Certification
        {
            get;
            private set;
        }

        public IUserRepository User

        {
            get;
            private set;
        }


        public void Dispose()
        {
            context.Dispose();
        }
        public bool Save()
        {
            return context.SaveChanges() > 0;
        }
    }
}
