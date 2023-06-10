using DesignPattern.ChainOfResponsibility_.Models;

namespace DesignPattern.ChainOfResponsibility_.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel request);
    }
}
