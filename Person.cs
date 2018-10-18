namespace objects_n_classes
{
    class Person
    {
        public string FirstName;

        public string LastName;

        public int age;

        public Person Spouse;

        public static double Sumofallages;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge ()
        {
            System.Console.WriteLine ("Hi my name is " + this.GetFullName() + "!");
            System.Console.WriteLine("And I am " + this.age + ".");
        }



      

       

        
        

        
    }
}






