namespace objects_n_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();  //First user

            p1.AskUserForNameAndAge();
            p1.CreateSpouseIfMarried();

            Person p2 = new Person();

            p2.AskUserForNameAndAge();
            p2.CreateSpouseIfMarried();

            System.Console.WriteLine("Average Age:" + Person.AverageAge());
            System.Console.ReadKey(); 


           


         



        }
    }
}
