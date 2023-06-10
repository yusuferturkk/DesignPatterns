using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        void TAdd(TEntity entity);
        void TDelete(TEntity entity);
        void TUpdate(TEntity entity);
        TEntity TGetById(int id);
        List<TEntity> TGetList();
        void TMultiUpdate(List<TEntity> entities);
    }
}
