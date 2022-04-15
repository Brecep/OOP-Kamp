using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Bilgilendir()
        {
            Console.WriteLine("İhtiyac kredisi faiz tutarı : %1.1");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }
    }
}
