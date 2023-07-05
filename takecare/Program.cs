
internal class Program
{

  
    public static List<havana> babu =new List<havana>();
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Tear the road");

        Console.WriteLine("Name is :" );
        havana xol = new havana();
        Console.WriteLine("Enter Name?");
        xol.Name = Console.ReadLine();
       
        Console.WriteLine("Enter Age");
        xol.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Email");
        xol.Email = Console.ReadLine();
        havana xpo=new havana();
      babu.Add(new havana{Age=20,Name="Waithera",Email="wam@gmail.com"});
      babu.Add(new havana{Age=10,Name="Wambui",Email="mbui@gmail.com"});
      babu.Add(new havana{Age=40,Name="Wamere",Email="mere@gmail.com"});
      babu.Add(new havana{Age=90,Name="Drek",Email="drek@gmail.com"});
       
        foreach(var drek in babu)
        {
            Console.WriteLine(drek.Age+"|--|"+drek.Email+"|--|"+drek.Name);
        }
    }
}

public class havana
    {
        //This is a model uwe will use later
        public int Age { get; set; }
        public string? Name{ get; set; }    
        public string? Email { get; set; }
        
        
        }