namespace Handbook.Data
{
    public class CreateDepart
    {
        public void createDepart(string depart)
        {
            ApplicationContext db = new ApplicationContext();
            Department newDepart = new Department { Depart = depart };
            db.Departments.Add(newDepart);
            
            db.SaveChanges();
        }

        public void delDepart(string depart)
        {
            ApplicationContext db = new ApplicationContext();
            db.Remove(depart);

            db.SaveChanges();
        }
    }
}
