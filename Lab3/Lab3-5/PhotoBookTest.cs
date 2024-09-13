using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    internal class PhotoBookTest
    {
        static void Main(string[] args)
        {
            // Test
            PhotoBook book = new PhotoBook();
            Console.WriteLine(String.Format("Default photobook object has these properties:\n\tName: {0}\n\tOwner: {1}\n\tNumber of pages: {2}",
                book.Name, 
                book.Owner, 
                book.NumPages));

            book = new PhotoBook("Ayutthaya Trip","Jirat S", 24);
            Console.WriteLine(String.Format("New photobook object has these properties:\n\tName: {0}\n\tOwner: {1}\n\tNumber of pages: {2}",
               book.Name,
               book.Owner,
               book.NumPages));
            Console.WriteLine(String.Format("Adding 12 \"pages\" to the object, now has {0} pages", book.AddPages(12)));
            Console.ReadLine();

        }
    }
}
