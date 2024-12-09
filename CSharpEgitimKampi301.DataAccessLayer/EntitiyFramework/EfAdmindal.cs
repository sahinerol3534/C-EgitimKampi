using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntitiyFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
/*Ekle, Sil, Listele ve Id'ye göre getir genel metodlardır.
// İçinde a harfi olmayan kullanıcaları listele o entity özel bir metodtur.
o yüzden IAdminDal'dan da miras alınıyor
*/
