namespace SupriyaCSharpTraining
{
    public class Program
    {
        public void Display()
        {
            Console.WriteLine("Iam from non static method display.");
        }

        public static void Print()
        {
            Console.WriteLine("Iam from static method Print.");
        }

        public static void RunProgram()
        {
            Console.WriteLine("Iam from Run Method");
            Program program = new Program();
            program.Display();
            Program.Print();
           
        }
    }

}