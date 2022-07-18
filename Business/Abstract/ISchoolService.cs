﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ISchoolService
    {
        IDataResult<List<School>> GetAll();
        IDataResult<School> Get(int schoolId);
        IDataResult<SchoolDetailDto> GetSchoolDetailDto();
        IDataResult<SchoolDetailDto> GetSchoolDetailDtoActive();
        IDataResult<SchoolDetailDto> GetSchoolDetailDtoPassive();
        IResult Add(School school);
        IResult Update(School school);
        IResult Delete(School school);
    }
}
