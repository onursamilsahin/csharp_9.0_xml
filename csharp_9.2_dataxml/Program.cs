using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_9._2_dataxml
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Ogrenci>  Ogrencilerim=new List<Ogrenci>();

            ////generci list oluşturuldu ve bunun içerisine fakedata ile datalar eklendi 
            //for (int i = 0; i < 100; i++)
            //{
                
            //    Ogrenci temp=new Ogrenci();

            //    temp.ID=new Guid();
            //    temp.soyIsim = FakeData.NameData.GetSurname();
            //    temp.Isim = FakeData.NameData.GetSurname();
            //    temp.Numara = FakeData.NumberData.GetNumber(10, 50);
            //    Ogrencilerim.Add(temp);




            //}

            //xml formatı verildi list in içerisinde bulunan değerler xml formatın yazıldı .

            //XDocument xdoc=new XDocument(new XDeclaration("1.1","UTF-8","yes"),
            //    new XElement("Ogrencilerim",Ogrencilerim.Select(I=> 
            //        new  XElement("Ogrenci",
            //            new XElement("ID",I.ID),
            //            new XElement("isim",I.Isim),
            //            new XElement("Soyisim",I.soyIsim),
            //            new XElement("numara",I.Numara)))));


            //xdoc.Save(@"c:\xml\Ornek2.xml");




            List<Ogrenci> Okunandata=new List<Ogrenci>();//okunacak değerleri eklemek için liste oluşturduk

           

            
            XDocument xoku=XDocument.Load(@"c:\xml\Ornek2.xml");//okunacak bölgeyi belirttik


         List<XElement> OkunanElement=xoku.Descendants("Ogrenci").ToList();//xml içerisinde okunması gerken element belirtildi.

            foreach (var item in OkunanElement)
            {
                
                Ogrenci temp=new Ogrenci();  //geçici bir nesne örneklendi .Değerler buraya eklenerek oluşturlan listeye gönderiliyor.

                temp.ID = Guid.Parse(item.Element("ID")?.Value ?? throw new InvalidOperationException());   
                temp.Isim = item.Element("isim")?.Value;
                temp.soyIsim = item.Element("Soyisim")?.Value;
                temp.Numara =int.Parse(item.Element("numara")?.Value ?? throw new InvalidOperationException());


                Okunandata.Add(temp);

            }

            foreach (var item in Okunandata)
            {

                Console.WriteLine(item.Isim);

            }
 

            Console.ReadLine();
        }
    }
}
