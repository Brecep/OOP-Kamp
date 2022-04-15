using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void Bilgilendir()
        {
            Console.WriteLine("Taşıt kredisi faiz tutarı : %1.2");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı");
        }
    }
}
