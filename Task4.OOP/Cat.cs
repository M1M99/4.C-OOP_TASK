namespace Task4.OOP
{
    public partial class Program
    {
        public class Cat
        {
            public string? nickname { get; set; }
            public decimal age { get; set; }
            public string? gender { get; set; }
            public byte energy { get; set; } = 100;
            public decimal price { get; set; }
            public double mealquantity { get ; set; }


            public Cat()
            {
            }

            public Cat(string? nickname, decimal age, string? gender, decimal price, double mealquantity)
            {
                this.nickname = nickname;
                this.age = age;
                this.gender = gender;
                this.energy = energy;
                this.price = price;
                this.mealquantity = mealquantity;
            }

            public void Eat() {
                if (mealquantity > 0)
                {
                    price = price + 0.1M;
                    energy = Convert.ToByte(energy + 10);
                    Console.WriteLine($"{nickname} is Eating");
                }
                else
                {
                    Console.WriteLine("Not enough Meal Quantity in Stock For Increase");
                }
                Console.WriteLine();
                if (mealquantity > 0)
                {
                    mealquantity = mealquantity - 1;
                }
                else
                    Console.WriteLine("Not enough Meal Quantity in Stock");
                if (mealquantity <= 0) {
                    Console.WriteLine("Not enough Meal Quantity in Stock");
                }

                try
                {
                    if (energy >= 200)
                    {
                        throw new Exception("Energy Max 200 Ola Biler");
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                Show();
            }
            public virtual void Show()
            {
                Console.WriteLine($"NickName : {nickname}\nAge : {age}\nGender : {gender}\nEnergy : {energy}\nPrice : {price}\nMealQuantity : {mealquantity}");
            }

            

            public void Sleep() {
                try
                {
                    if(energy >= 200) {
                        throw new Exception("Energy Max 200 Ola Biler");
                    }
                    energy = Convert.ToByte(energy + 20);
                    Console.WriteLine($"{nickname} is Sleeping");
                    Show();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            public void Play() {
                energy = Convert.ToByte(energy - 10);
                Console.WriteLine($"{nickname} is Playing");
                Show();

            }

        }
    }
}
