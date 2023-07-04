// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Tear the road");

Console.WriteLine("Name is :"+look);
havana xol =new havana();
Console.WriteLine("Enter Name?");
xol.Name= Console.ReadLine();
Console.WriteLine("Enter Age");
xol.Age = Convert.Tobase32(Console.ReadLine());

public class havana
    {
        //This is a model we will use later
        public int Age { get; set; }
        public string? Name{ get; set; }    
        public string? Email { get; set; }
        
        
        }