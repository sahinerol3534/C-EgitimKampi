using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Catagory
    {
        /* 
         * field    ---> Bir değişken direkt olarak sınıfın içinde tanımlanırsa
         * variable ---> Bir değişken bir metod içinde tanımlanıyorsa
         * Property ---> Değişken yapısında sonuna {get; set;} yapısı alıyorsa
         */

        public int CatagoryId { get; set; }
        /* birincil anahtar ve otomatik olarak artması için class'ın ismi aynı yazılıp sonuna 'Id' yazısı 
         * konmalıdır
        */
        public string CatogoryName { get; set; }
        /* 
         * get veriyi alırken kısıt getirmek Örnek: CatogoryName i büyük harf olarak çekmek gibi
         * set veri formunu ayarlamak için. örnek: verinin karakter uzunluğunu 5 karakterden küçük
         * se kullanıcıya uyarı verilmesi.
         */
        public bool CatagoryStatus { get; set; }
        public List<Product> Products { get; set; }


    }
}
