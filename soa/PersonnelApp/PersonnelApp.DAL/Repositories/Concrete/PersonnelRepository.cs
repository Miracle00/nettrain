﻿using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(PersonnelContext context):base(context)
        {
           
        }
        public List<Personnel> GetPersonnelsWithDepartments()
        {
            return PersonnelContext.Personnels.Include("Department").ToList();
        }
        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
