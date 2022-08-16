using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public static class UserRepository
    {
        public static User GET(string username, string password)
        {
            var users = new List<User>();
           
            return (User)users.Where((x =>
                x.Username.ToLower() == username.ToLower()
                && x.Password.ToLower() == password.ToLower()
                ));



        }

        
    }
}
