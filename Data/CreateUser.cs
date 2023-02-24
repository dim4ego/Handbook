namespace Handbook.Data

{
    public class CreateUser
    {
        public void createUser(string name, string cityNumber, string localNumber, string department, string email, string login, string passwordWin, string passwordPsi, string passwordEmail, string anotherInformation) { 
        ApplicationContext db = new ApplicationContext();
        User newUser = new User { Name = name, CityNumber = cityNumber, LocalNumber = localNumber, Department = department, Email = email, Login = login, PasswordWin = passwordWin, PasswordPsi = passwordPsi, PasswordEmail = passwordEmail, AnotherInformation=anotherInformation };
            db.Users.Add(newUser);
            db.SaveChanges();
        }
    }
}
