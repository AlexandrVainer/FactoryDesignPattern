using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class DietFactory
    {
        public static DietBase GetDiet(string id)
        {
            if (id == "vn")
                return new VeganDiet();
            if (id == "vt")
                return new VegetarianDiet();
            if (id == "lf")
                return new LightFood();
            return null;
        }
    }

    public abstract class DietBase
    {
        public abstract void PrintAllowedItems();
    }
    public class VeganDiet : DietBase
    {
        public override void PrintAllowedItems()
        {
            foreach (var item in "Fruits,Grains,Vegetables".Split(','))
            {
                Console.WriteLine(item);
            }
        }
    }
    public class VegetarianDiet : VeganDiet
    {
        public override void PrintAllowedItems()
        {
            base.PrintAllowedItems();
            foreach (var item in "Eggs,Dairy products".Split(','))
            {
                Console.WriteLine(item);
            }
        }
    }

    public class LightFood : VegetarianDiet
    {
        public override void PrintAllowedItems()
        {
            base.PrintAllowedItems();
            foreach (var item in "Meat,Fish".Split(','))
            {
                Console.WriteLine(item);
            }
        }
    }

}
