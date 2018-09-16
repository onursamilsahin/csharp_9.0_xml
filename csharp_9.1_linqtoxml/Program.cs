using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_9._1_linqtoxml
{
    class Program
    {
        static void Main(string[] args)
        {
            //<?xml version="1.0" standalone="yes"?>

            //    <veritabanim>
                    
            //        <personellerim>
                    
            //            <isim></isim>
            //        </personellerim>
            //    </veritabanim>


            //linq ile xml dosyası oluşturma 
            XDocument xdoc=new XDocument(
                new XDeclaration("1.0","UTF-8","yes"),
                new XElement("Veritabanım",
                    new XElement("personellerim",new XAttribute("ID","1"),
                        new XElement("isim","john"),
                        new XElement("soysiim","doe")
                        )
                    )
                );


            xdoc.Save(@"c:\XMl\Ornek1.xml");//save metodu ile yazdığımız xml örneğini kaydettik, burada klasörden sonrasını kendisi oluşturdu.
    


        }
    }
}
