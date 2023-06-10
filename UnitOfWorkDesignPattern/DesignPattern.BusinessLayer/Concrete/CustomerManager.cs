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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerManager(ICustomerDal customerDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerDal = customerDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TAdd(Customer entity)
        {
            _customerDal.Add(entity);
            _unitOfWorkDal.Save();
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
            _unitOfWorkDal.Save();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TMultiUpdate(List<Customer> entities)
        {
            _customerDal.MultiUpdate(entities);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
            _unitOfWorkDal.Save();
        }
    }
}
