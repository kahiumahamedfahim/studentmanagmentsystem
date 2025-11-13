using studentManagmentSystem.DataAccess;
using studentManagmentSystem.Entity;
using studentManagmentSystem.Repository.Interfaces;

namespace studentManagmentSystem.Repository
{
    public class DepartmentRepository: GenericRepository<Department>,IDeparmentRepository
    {

        public DepartmentRepository(AppDbContext context):base(context)
        {
        }
    }
}
