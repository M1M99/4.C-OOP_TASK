namespace Task4.OOP
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new("CatNick", 4, "Gen", 600.1M, 10);
            //Cat cat1 = new("CatNick1", 3, "Gen1", 600M, 10);
            //Cat cat2 = new("CatNick2", 2, "Gen2", 619.1M, 10);
            //Cat cat3 = new("CatNick3", 1, "Gen3", 560.5M, 10);
            //Cat cat4 = new("CatNick3", 1, "Gen3", 560.5M, 10);
            //Cat cat5 = new("CatNick3", 1, "Gen3", 560.5M, 10);
            //Cat[] catArr =
            //{
            //    cat,
            //    cat1,
            //    cat2,
            //    cat3,
            //    cat4,
            //};

            //CatHouse house = new(catArr, 9);
            //CatHouse[] Cathouses = {
            //    house
            //};
            //house.ShowCats();
            //PetShop petShop = new PetShop(Cathouses,10);
            //petShop.ShowPetShop();


            //houseShop.ShowCats();
            while (true)
            {
                Console.Write("1. Play.\n");
                Console.Write("2. Eat.\n");
                Console.Write("3. Sleep.\n");
                Console.Write("Secim Daxil Et : ");
                var choise = Console.ReadKey().Key;

                if (choise == ConsoleKey.D1)
                {
                    try
                    {
                        if (cat.energy <= 0)
                        {
                            Console.Clear();
                            throw new Exception("Energy cannot be 0");
                        };
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Console.Clear();
                    cat.Play();
                }
                else if (choise == ConsoleKey.D2)
                {
                    Console.Clear();
                    cat.Eat();
                }
                else if (choise == ConsoleKey.D3)
                {
                    Console.Clear();
                    cat.Sleep();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("False Choise ! ");
                }
            }
        }
    }
}
