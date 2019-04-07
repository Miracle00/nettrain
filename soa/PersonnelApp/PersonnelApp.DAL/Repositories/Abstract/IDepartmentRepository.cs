using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        List<Department> GetTopDepartments(int count);

        List<Department> GetDepartmentsWithPersonnels();
    }
}
