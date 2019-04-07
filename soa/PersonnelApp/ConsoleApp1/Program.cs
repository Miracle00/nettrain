using PersonnelApp.DAL;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository
                .Add(new Department() { Name = "Bilgi İşlem", CreatedDate = DateTime.Now, IsActive = true });
            unitOfWork.Complete();
        }
    }
}
