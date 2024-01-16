namespace CleanArchitecture.Core.Interfaces
{
    public interface IDependencyInjectionUser
    {
        // 5b3c8005-a1a6-4729-8907-1426924008e7
        string GetUserSalaryByUserId(Guid UserId);
        string GetUserNameByUserId(Guid UserId);
    }

    public interface IDependencyInjectionDepartment
    {
        string GetUserDepartmentByUserId(Guid UserId);
        string GetUserDepartmentByUserIdAndUserName(Guid UserId, string UserName);
        string GetUserNameAndJobByUserId(Guid UserId);
    }

    public interface ICircularDependency
    {
        string GetUserDepartmentNameAndUserNameByUserId(Guid UserId);
    }
}
