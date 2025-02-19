﻿using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context):base(context)
        {
            
        }
        public List<Department> GetDepartmentsWithPersonnels()
        {
            return PersonnelContext.Departments.Include("Personnels").ToList();
        }

        public List<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Departments.Take(count).ToList();
        }

        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
