﻿using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class SchoolManager : ISchoolService
    {
        private readonly ISchoolDal _schoolDal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }

        public IResult Add(School school)
        {
            _schoolDal.Add(school);
            return new SuccessResult(MyMessage.GetMessage("School",Process.Add));
        }

        public IResult Delete(School school)
        {
            _schoolDal.Delete(school);
            return new SuccessResult(MyMessage.GetMessage("School", Process.Delete));
        }

        public IDataResult<School> Get(int schoolId)
        {
            return new SuccessDataResult<School>(_schoolDal.Get(s=>s.Id==schoolId));
        }

        public IDataResult<List<School>> GetAll()
        {
            return new SuccessDataResult<List<School>>(_schoolDal.GetAll());
        }

        public IDataResult<SchoolDetailDto> GetSchoolDetailDto()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SchoolDetailDto> GetSchoolDetailDtoActive()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SchoolDetailDto> GetSchoolDetailDtoPassive()
        {
            throw new NotImplementedException();
        }

        public IResult Update(School school)
        {
            _schoolDal.Update(school);
            return new SuccessResult(MyMessage.GetMessage("School", Process.Update));
        }
    }
}
