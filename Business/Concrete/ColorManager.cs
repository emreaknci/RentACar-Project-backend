using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.Name.Length >= 2)
            {
                _colorDal.Add(color);
                Console.WriteLine(color.Id + " 'li " + color.Name + " markasi sisteme basariyla eklendi!\n");
            }
            else
                Console.WriteLine("Renk ismi en az iki harfli olmalidir!\n");
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine(color.Id + " 'li " + color.Name + " rengi sistemden silindi!\n");
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine(color.Id + " 'li rengin bilgileri guncellendi!\n");
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();
        }
        public List<Color> GetById(int Id)
        {
            return _colorDal.GetAll(c => c.Id == Id);
        }        
    }
}
