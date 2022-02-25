using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList team1 = new ArrayList();
            ArrayList team2 = new ArrayList();
            ArrayList team3 = new ArrayList();

            team1.addAtTail("Rita");
            team1.addAtTail("Antonio");
            team1.addAtTail("Santiago");
            team1.addAtTail("Diego");
            team1.addAtTail("Najera");

            team2.addAtFront("Aldo");
            team2.addAtFront("Ignacio");
            team2.addAtFront("Arturo");
            team2.addAtFront("Teresa");
            team2.addAtFront("Rebeca");

            team3.addAtFront("Miguel");
            team3.addAtFront("Angel");
            team3.addAtFront("Citlalli");
            team3.addAtFront("Paco");
            team3.addAtFront("Adrian");
            team3.addAtFront("Ronaldo");

            ArrayListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes"); 

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0);

            team3.addAtTail("Isai");
            team3.addAtFront("Tadeo");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1).Equals("Salomón"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }
        }
    }
}
