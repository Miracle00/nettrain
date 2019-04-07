using PersonnelApp.DAL;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository
                .Add(new Department() { Name = "Bilgi İşlem", CreatedDate = new DateTime(), IsActive = true });
            unitOfWork.Complete();
        }
    }
}
