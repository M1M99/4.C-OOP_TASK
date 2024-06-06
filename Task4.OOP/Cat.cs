namespace Task4.OOP
{
    public partial class Program
    {
        public class Cat
        {
            public string? nickname { get; set; }
            public decimal age { get; set; }
            public string? gender { get; set; }
            public decimal energy { get; set; } = 100;
            public decimal price { get; set; }
            public double mealquantity { get ; set; }


            public Cat()
            {
            }

            public Cat(string? nickname, decimal age, string? gender, /*decimal energy,*/ decimal price, double mealquantity)
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
                    energy = energy + 10;
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
                    Console.WriteLine("Not enough Meal Quantity in Stock add Quantity");
                if (mealquantity <= 0) {
                    Console.WriteLine("Not enough Meal Quantity in Stock add Quantity");
                }
                //Show();
            }
            public void Sleep() {
                Console.WriteLine($"{nickname} is Sleeping");
            }
            public void Play() {
                energy = energy - 10;
                Console.WriteLine($"{nickname} is Playing");
            }

            public void Show()
            {
                Console.WriteLine($"NickName : {nickname}\nAge : {age}\nGender : {gender}\nEnergy : {energy}\nPrice : {price}\nMealQuantity : {mealquantity}");
            }
        }
    }
}
