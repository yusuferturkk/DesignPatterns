using DesignPattern.ChainOfResponsibility_.DataAccessLayer;
using DesignPattern.ChainOfResponsibility_.Models;

namespace DesignPattern.ChainOfResponsibility_.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü Yardımcısı - Melike Öztürk";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutarı Şube Müdürü Yardımcısı tarafından ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü Yardımcısı - Melike Öztürk";
                customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımcısının limitini aştığı için işlem Şube Müdürüne yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
