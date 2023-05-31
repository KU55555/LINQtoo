using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ töö");
            Console.WriteLine("WhereLINQ ja ThenByLINQ");

            //kutsume WhereLINQ meetodi välja
            WhereLINQ();
            ThenByLINQ();
        }

        public static void WhereLINQ()
            
        {
            //WhereLINQ laseb teatud kriteeriumide alusel kogumit filtreerida
            //Võtab PeopleListist inimesed vanusega 20 kuni 23 ja printib need konsooli
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);
            //Siin votab vanuse järgi nimed
            foreach (var item in peopleAge)
            {
                //Siin printib iga selle inimese nime konsooli
                Console.WriteLine(item.Name);
            }
        }

        
        public static void ThenByLINQ()
        {
            //ThenBy kasutatakse andmete sortimiseks kasvavas järjekorras
            Console.WriteLine("ThenBy järgi reastamine");
            //Võtab peoplelistist kõik inimesed
            var thenByResult = PeopleList.peoples
                //siin järjestab nimede järgi ja siis vanuse järgi
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            foreach (var people in thenByResult)
            {
                //Siin prindib konsooli inimese nime ja siis vanuse
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }       
    }
}