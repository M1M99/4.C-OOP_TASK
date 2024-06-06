using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task4.OOP.Program;

namespace Task4.OOP
{
    internal class PetShop : CatHouse
    {
        public CatHouse[] CatHouses;
        public int CatHouseCount;
        public PetShop(CatHouse[] CatHouses, int CatHouseCount) {
            this.CatHouses = CatHouses;
            this.CatHouseCount = CatHouseCount;
        }
        public PetShop(int capacity)
        {
            CatHouses = new CatHouse[capacity];
            CatHouseCount = 0;
        }

        public void ShowPetShop()
        {
            foreach (var catHouse in CatHouses)
            {
                if (catHouse != null)
                {
                    catHouse.ShowCats();
                    Console.WriteLine();
                }
            }
        }
    }
}
