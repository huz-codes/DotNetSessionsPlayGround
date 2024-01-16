using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Services
{
    public class DependencyInjectionUser : IDependencyInjectionUser
    {
        public string GetUserNameByUserId(Guid UserId)
        {
            return $"Name of this {UserId} is ahmad";
        }

        public string GetUserSalaryByUserId(Guid UserId)
        {
            return $"salary of this user {UserId} is 1$";
        }
    }

    public class DependencyInjectionDepartment : IDependencyInjectionDepartment
    {
        private readonly IDependencyInjectionUser _user;
        public DependencyInjectionDepartment(IDependencyInjectionUser user)
        {
            _user = user;
        }

        public string GetUserDepartmentByUserId(Guid UserId)
        {
            return $"Department of this {UserId} is Financ and development";
        }

        public string GetUserDepartmentByUserIdAndUserName(Guid UserId, string UserName)
        {
            return $"Department of this User is Development name is {UserName} and id is {UserId}";
        }

        public string GetUserNameAndJobByUserId(Guid UserId)
        {
            var UserName = !string.IsNullOrEmpty(_user.GetUserNameByUserId(UserId)) ?
                                                 _user.GetUserNameByUserId(UserId):
                                                 $"user id is {UserId}";

            return $"user Job is software developer, and his/her name is {UserName}";
            
        }
    }

    public class CircularDependency : ICircularDependency
    {
        private readonly IDependencyInjectionUser _user;
        private readonly IDependencyInjectionDepartment _dependencyInjectionDepartment;
        public CircularDependency(IDependencyInjectionDepartment dependencyInjectionDepartment, IDependencyInjectionUser user)
        {
            _dependencyInjectionDepartment = dependencyInjectionDepartment;
            _user = user;
        }
        public string GetUserDepartmentNameAndUserNameByUserId(Guid UserId)
        {
            var departmentName = !string.IsNullOrEmpty(_dependencyInjectionDepartment.GetUserDepartmentByUserId(UserId)) ?
                                                       _dependencyInjectionDepartment.GetUserDepartmentByUserId(UserId) :
                                                       $"user id is {UserId}";

            var UserName = !string.IsNullOrEmpty(_user.GetUserNameByUserId(UserId)) ?
                                                 _user.GetUserNameByUserId(UserId) :
                                                 $"user id is {UserId}";

            return $"user name is {UserName} and department name is {departmentName}";
        }
    }
}
