using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingAPILib.Interface
{
    public interface ICyclistRepo
    {
        Task<IEnumerable<Cyclist>> GetAll();

        Task<Cyclist> GetById(int id);

        //Create
        Task<Cyclist> Create(Cyclist entity);

        //Delete
        Task<Cyclist> Delete(Cyclist entity);

        Task<Cyclist> DeleteById(int id);

        //Update
        Task<Cyclist> Update(Cyclist entity);
    }
}
