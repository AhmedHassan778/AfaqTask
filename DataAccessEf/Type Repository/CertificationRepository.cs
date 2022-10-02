using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace DataAccessEF.Type_Repository
{
    class CertificationRepository : GenericRepository<Certification>, ICertificationRepository
    {
        public CertificationRepository(PeopleContext context) : base(context) { }
    }
}
