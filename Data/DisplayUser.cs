namespace Handbook.Data
{
    public class DisplayUser
    {
       
       
        

        public List<string> displayUser()
        {
            List<string> listUsers = new List<string>();
            ApplicationContext db = new ApplicationContext();
            var users = db.Users.ToList();

            foreach (User u in users)
            {
                listUsers.Add($"{u.Id}.{u.Name} {u.Email}");
                Console.WriteLine($"{u.Id}.{u.Name} {u.Email}");

            }
            return listUsers;
        }

        public void test()
        {

        }
    }
}
