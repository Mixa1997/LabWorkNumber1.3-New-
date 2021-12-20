using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLabWorkNomer13
{
    public class Code
    {
        static void Main(string[] args)
        {
            Tannel auto = new Tannel("Туннель");
            Vxod auto2 = new Vxod("Вход");
            Svet auto3 = new Svet("свечение");
            Speed auto4 = new Speed("Скорость");

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", auto.name, auto.Deistvie(), auto2.name, auto2.Deistvie2(), auto3.name, auto3.Deistvie3(), auto4.name, auto4.Diestvie4());
            Console.ReadKey();
        }
    }

    public class Tannel
    {
        public string name { get; set; }
        public Tannel(string name)
        {
            this.name = name;
        }

        public string Deistvie()
        {
            return "Прошло несколько секунд,прежде чем он понял,что произошло. Они нырнули в туннель.";
        }
    }

    public class Vxod
    {
        public string name { get; set; }
        public Vxod(string name)
        {
            this.name = name;
        }

        public string Deistvie2()
        {
            return "То,что он принял за движущийся им навстречу объект,было его освещённым входом";
        }
    }

    public class Svet
    {
        public string name { get; set; }
        public Svet(string name)
        {
            this.name = name;
        }

        public string Deistvie3()
        {
            return "Серебристое свечение испускали круглые стены туннеля,";
        }
    }

    public class Speed
    {
        public string name { get; set; }
        public Speed(string name)
        {
            this.name = name;
        }

        public string Diestvie4()
        {
            return "очевидно,со скоростью несколько сот миль в час.";
        }
    }
}
