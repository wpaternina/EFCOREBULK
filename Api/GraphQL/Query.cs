using Api.Models;
using Api.Persistences;
using System.Linq;

namespace Api.GraphQL
{
    public class Query
    {
        private readonly AppDbContext _appDbContext;

        public Query(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Empleado> Empleados => _appDbContext.Empleado;
    }
}
