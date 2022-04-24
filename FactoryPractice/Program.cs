using Factory;

do
{
    Console.Clear();
    Console.WriteLine(@"Enter the diet : 
        vn : Vegan diet
        vt : Vegetarian diet
        lf : Light food
        q : quit
        ");
    string input = Console.ReadLine();
    if (input == "q")
        break;
    DietBase diet = DietFactory.GetDiet(input);
    if (diet != null)
        diet.PrintAllowedItems();
    else
        Console.WriteLine("Unknow diet name");
    Console.WriteLine("Enter any key to recieve another diet menu");
    Console.ReadLine();

} while (true);