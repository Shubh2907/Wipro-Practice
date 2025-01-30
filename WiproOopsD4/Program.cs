namespace WiproOopsD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empid = 11;
            emp.EmpName = "Test";

            //emp.Display();

            Department dpt = new Department(); //creating instance for the derived class
            dpt.Empid = 20;
            dpt.EmpName = "Banna"; 
            dpt.DeptName = "Developer";
            dpt.Salary = 100000;

            dpt.Display();
            //dpt.Show();


            Manager mgr = new Manager();
            mgr.Empid = 20;
            mgr.EmpName = "Banna";
            mgr.DeptName = "Developer";
            mgr.Salary = 100000;
            mgr.ManagerName = "Jaat";

            mgr.Display();


        }
    }
}