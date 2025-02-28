namespace Lab5
{
    public class Program
    {
        static void MakeCircle(double radius)
        {
            try
            {
                Circle circ = new Circle(radius);
                Console.WriteLine(circ.ToString());
                
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
        static void Main()
        {
            MakeCircle(25);
            MakeCircle(-20);
            MakeCircle(20);
            MakeCircle(10);
            MakeCircle(0);
        }
    }
}

