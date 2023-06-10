using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public ProcessManager(IProcessDal processDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _processDal = processDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TAdd(Process entity)
        {
            _processDal.Add(entity);
            _unitOfWorkDal.Save();
        }

        public void TDelete(Process entity)
        {
            _processDal.Delete(entity);
            _unitOfWorkDal.Save();
        }

        public Process TGetById(int id)
        {
            return _processDal.GetById(id);
        }

        public List<Process> TGetList()
        {
            return _processDal.GetList();
        }

        public void TMultiUpdate(List<Process> entities)
        {
            _processDal.MultiUpdate(entities);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Process entity)
        {
            _processDal.Update(entity);
            _unitOfWorkDal.Save();
        }
    }
}
