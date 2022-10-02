using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICertificationRepository Certification
        {
            get;
        }
        IUserRepository User
        {
            get;
        }

        bool Save();

        /*int hello()
        {

            return 9;
        }*/

    }
}
