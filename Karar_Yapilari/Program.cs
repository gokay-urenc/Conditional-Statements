using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dışarıdan girilen 2 farklı sayının karşılaştırılması ve büyüklük küçüklük durumları.
            Console.Write("1. Sayıyı Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2)
            {
                Console.WriteLine(s1 + ", " + s2 + "'den daha büyüktür.");
            }
            else
            {
                Console.WriteLine(s1 + ", " + s2 + "'den daha küçüktür.");
            }
            Console.ReadKey();
        }
    }
}
/* Bir uygulamada koşul veya koşulların kontrolünü sağlayan deyim karar yapılarıdır.
   if (eğer) deyimi: Bu yapıda if ile herhangi bir koşul kontrol edilir. 
   Eğer koşul sağlanıyorsa if yapısı içindeki kodlar çalışır.
   Eğer koşul sağlanmıyorsa if içerisindeki kodlar çalıştırılmadan if'ten sonraki kod satırları çalışır.
   else (değilse) deyimi: if bloğa bağlıdır. Yani if bloğu olmadan kullanılamaz.
   Bağlı olduğu if bloğundaki koşul sağlanmıyorsa else bloğunun içerisindeki kodlar çalışır.
   Else bloğunda koşul kontrol edemeyiz.
*/