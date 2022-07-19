using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(MyMessage.GetMessage("City",Process.Add));
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(MyMessage.GetMessage("City", Process.Delete));
        }

        public IDataResult<City> Get(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.Id==cityId));
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<List<City>> GetAllActive()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(c=>c.State==true));
        }

        public IDataResult<List<City>> GetAllPassive()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(c => c.State == false));
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(MyMessage.GetMessage("City", Process.Update));
        }
    }
}
