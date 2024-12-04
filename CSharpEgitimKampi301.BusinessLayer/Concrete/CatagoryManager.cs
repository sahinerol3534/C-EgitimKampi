using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CatagoryManager : ICatagoryService
    {
        private readonly ICatagoryDal _catagoryDal;

        public CatagoryManager(ICatagoryDal catagoryDal)
        {
            _catagoryDal = catagoryDal;
        }
        public void TDelete(Catagory entity)
        {
            _catagoryDal.Delete(entity);
        }
        public List<Catagory> TGetAll()
        {
            return _catagoryDal.GetAll();
        }
        public Catagory TGetById(int id)
        {
            return _catagoryDal.GetById(id);
        }
        public void TInsert(Catagory entity)
        {
            _catagoryDal.Insert(entity);
        }
        public void TUpdate(Catagory entity)
        {
           _catagoryDal.Update(entity);
        }
    }
}
