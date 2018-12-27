using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Привет_по_запросу
{
   class Program
   {
      static void Main( string[ ] args )
      {
         Console.Write( "Представьтесь - ....." );
         string str = Console.ReadLine( );
         Console.WriteLine($"Мой кумир, - {str}, ты меня покорил" );

         Console.ReadKey( );

      }
   }
}
