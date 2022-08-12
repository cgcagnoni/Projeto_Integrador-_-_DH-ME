using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public static class UserRepository
    {
        public static User GET(string username, string password) 
        {
            var users = new List<User>();
            return users
                .FirstOrDefault(x => 
                x.Username == username
                && x.Password == password);

        }
    }
}
