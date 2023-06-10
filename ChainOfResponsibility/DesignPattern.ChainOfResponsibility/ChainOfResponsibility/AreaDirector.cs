using DesignPattern.ChainOfResponsibility_.DataAccessLayer;
using DesignPattern.ChainOfResponsibility_.Models;

namespace DesignPattern.ChainOfResponsibility_.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutarı Bölge Müdürü tarafından ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı Bölge Müdürünün limitini aştığı için işlem gerçekleştirilemedi. Müşterinin günlük maksimum çekebileceği tutar 400.000 TL'dir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
