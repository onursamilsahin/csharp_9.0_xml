using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace csharp_9._0_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki farklı uygulama arası data transferini standart hale getirmek için kullanılır.


            //Xml text writer ile belirtilen klasöre yazma işlemi yapılır yazılır iken 
            //Verilen dosyaya nasıl yazılacapı yani formatıda xmltextwriter ile birlikte verilir.
            //System.TExt.Utf8encoding.utf8 format içindir.
            XmlTextWriter xmlText=new XmlTextWriter(@"c:\XML\Personellerim.xml",System.Text.UTF8Encoding.UTF8);




            xmlText.WriteComment("Xml İşlemleri ");//Xml dosyasının üstündeki yorum olan kod bloğu için

            /*
             *xml formatı örneği
             *
             *
             *  <personellerim>        XmlText.WriteStartElement("");  ile yazılıyor.
             *
             *    <personel ID=1>      xmlText.WriteStartElement("Personel");  -xmlText.WriteAttributeString("ID","1");
             *
             *      <isim></isim>      xmlText.WriteElementString("Isim","john");
             *
             *    </personel>  
             *
             *  </personeller>
             */


            xmlText.WriteStartElement("Personellerim");

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID","1");



            xmlText.WriteElementString("Isim","john");
            xmlText.WriteElementString("soyisim","Doe");

            xmlText.WriteEndElement();

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "2");



            xmlText.WriteElementString("Isim", "john2");
            xmlText.WriteElementString("soyisim", "Doe2");

            xmlText.WriteEndElement();

            xmlText.WriteEndElement();


            xmlText.Close();

            /*****************************/
            XmlReader xread=XmlReader.Create(@"c:\xml\personellerim.xml");



            while (xread.Read())//içeride okounacak xml varmı kontrol ediyor
            {

                Console.WriteLine($"{xread.Name.ToString()}-{xread.Value.ToString()}");//burada okunan xml dosyası ekrana yazdırılıyor.



            }

            Console.ReadLine();


















        }
    }
}
