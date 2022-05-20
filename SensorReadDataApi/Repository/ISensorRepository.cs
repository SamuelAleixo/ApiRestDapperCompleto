using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestDapper.Domain;

namespace ApiRestDapper.Repository
{
    public interface ISensorRepository
    {
        public IEnumerable<Sensor> ListAll();

        public int Insert(long step);
    }
}
