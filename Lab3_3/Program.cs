using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    class CatIsNotGoodException : Exception
    {
        public CatIsNotGoodException() { }

        public CatIsNotGoodException(string cat) : base(String.Format("Cat is... Errored?", cat))
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            void PatCat(string cat)
            {
                if (cat == null)
                {
                    throw new ArgumentNullException("Cat is... Gone...");
                }
                else if(cat == "error")
                {
                    throw new CatIsNotGoodException("Cat is... Errored?");
                }
                else 
                {
                    Console.WriteLine($"Good boy, {cat}!");
                    Console.WriteLine("");
                }
            }
            string cat_1 = "Vognezir";
            string cat_2 = null;
            string cat_3 = "Paporotelapka";
            string cat_4 = "error";
            try {
                PatCat(cat_1);
                PatCat(cat_2);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }

            try
            {
                PatCat(cat_3);
                PatCat(cat_4);
            }
            catch (CatIsNotGoodException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }
            finally
            {
                Console.WriteLine("We did amazing job!!!");
                Console.ReadKey();
            }
        }
    }
}
