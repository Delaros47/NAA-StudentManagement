﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSchoolDal : EfEntityRepositoryBase<School, StudentManagementContext>, ISchoolDal
    {
        public List<SchoolDetailDto> GetSchoolDetailDto()
        {
            using (StudentManagementContext context = new StudentManagementContext())
            {
                var result = from s in context.Schools
                             join c in context.Cities
                             on s.CityId equals c.Id
                             join d in context.Districts
                             on s.DistrictId equals d.Id
                             select new SchoolDetailDto
                             {
                                 Id = s.Id,
                                 PrivateCode = s.PrivateCode,
                                 SchoolName = s.SchoolName,
                                 CityName = c.CityName,
                                 DistrictName = d.DistrictName,
                                 State = d.State,
                                 Description = s.Description
                             };
                return result.ToList();
            }
        }
    }
}
