using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class EsnafKrediManager : IKrediManager
    {
        public void Bilgilendir()
        {
            Console.WriteLine("Esnaf kredisi faiz tutarı : %1.4");
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }
}
