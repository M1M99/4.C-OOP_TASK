using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task4.OOP.Program;

namespace Task4.OOP
{
    public class CatHouse : Cat
    {
        public Cat[] Cats;
        public int CatCount;

        public CatHouse(Cat[] cats, int catCount)
        {
            Cats = cats;
            CatCount = catCount;
        }
        public CatHouse()
        {
            
        }

        public void ShowCats()
        {
            foreach (var cat in Cats)
            {
                cat.Show();
                Console.WriteLine();
            }
        }

        public void AddCat(Cat newCat)
        {
            if (CatCount < Cats.Length)
            {
                Cats[++CatCount] = newCat;
            }
            else
            {
                Console.WriteLine("Cat house is full.");
            }
        }

        public void RemoveByNickNameCat(string nickname1)
        {
            for (int i = 0; i < Cats.Length; i++)
            {
                if (Cats[i].nickname == nickname1)
                {
                    for (int j = i; j < CatCount - 1; j++)
                    {
                        Cats[j] = Cats[j + 1];
                    }
                    CatCount--;
                    return;
                }
            }
        }
    }
}
