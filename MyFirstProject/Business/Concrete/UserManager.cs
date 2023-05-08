using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<User> Login(LoginDto user)
        {
            var userCheck = _userDal.GetById(X=>X.EMail.Replace(" ","")==user.EMail);

            if (userCheck is null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            var loginCheck = userCheck.Password.Replace(" ","")==user.Password?true:false;

            return loginCheck ? new SuccessDataResult<User>(userCheck, Messages.UserLogin) : new ErrorDataResult<User>(Messages.PasswordError); ;
        }

        public IDataResult<User> Register(User user)
        {
            //user.FirstName = user.FirstName.Replace(" ","");
            //user.LastName = user.LastName.Replace(" ", "");
            //user.EMail = user.EMail.Replace(" ", "");
            //user.Password = user.Password.Replace(" ", "");

            _userDal.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
    }
}
