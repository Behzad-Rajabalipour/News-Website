using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;
using WebApplication11.Repository;
using WebApplication11.Service;
/*
    GenericService<User> : Parent classesh GenericRepository<T> hast ke method hasho be UserService mide.
    IUserSevice : Parent Interface hast, ke age methode parent jadid khasti unja benevisi
*/
/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Service
{
    // age db(context) private bud az in rah mirim
    public class UserService : GenericService<User>, IUserService
    {
        // chon private hast pas db leak nemishe to farzandash
        private IUserRepository _userRepository;          // Interface. Valed = new Farzand(). 
        public UserService(DbNewsContextEntity context) : base(context)
        {
            _userRepository = new UserRepository(context);          // class. age Interface method dasht inja bayad Anonymous mineveshtimesh
        }

        public int GetUserId(string MobileNumber)
        {
            User user = _userRepository.GetAll().FirstOrDefault(t => t.MobileNumber == MobileNumber);
            return user.UserId;
        }
    }
}