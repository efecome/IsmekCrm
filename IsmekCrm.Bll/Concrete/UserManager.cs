using IsmekCrm.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Dal.Abstract;

namespace IsmekCrm.Bll.Concrete
{
    public class UserManager : IUserService
    {
        IUserRepository _userService;

        public UserManager(IUserRepository userService)
        {
            _userService = userService;
        } 

        public void Add(User entity)
        {
            _userService.Add(entity);
        }

        public void Delete(int id)
        {
            _userService.Delete(new User { Id=id });
        }

        public List<User> GetAll()
        {
            return _userService.GetList().ToList();
        }

        public User GetById(int id)
        {
            return _userService.Get(x=>x.Id ==id);
        }

        public void Update(User entity)
        {
            _userService.Update(entity);
        }
    }
}
