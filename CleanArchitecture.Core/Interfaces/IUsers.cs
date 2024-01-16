namespace CleanArchitecture.Core.Interfaces
{
    // solid
    public interface IUsers
    {
        void AddUser();
        void GetUserById();
        void GetListOfUsers();
    }

    public interface IMailServices
    {
        void SendEmail();
        void RetriveEmails();
    }

    public class MailServices : IMailServices
    {
        public void RetriveEmails()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }

    public class TEst : IUsers
    {
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void GetListOfUsers()
        {
            throw new NotImplementedException();
        }

        public void GetUserById()
        {
            throw new NotImplementedException();
        }
    }
}
