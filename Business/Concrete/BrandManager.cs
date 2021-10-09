using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2 )
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand.Id+" 'li "+brand.Name+ " markasi sisteme basariyla eklendi!\n");
            }
            else
                Console.WriteLine("Marka ismi en az iki harfli olmalidir!\n");
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand.Id + " 'li " + brand.Name + " markasi sistemden silindi!\n");
        }
        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine(brand.Id + " 'li marka bilgileri guncellendi!\n");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
        public List<Brand> GetById(int Id)
        {
            return _brandDal.GetAll(b => b.Id == Id);
        }
    }
}
