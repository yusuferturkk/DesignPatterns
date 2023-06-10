using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Message message = new Message();
            message.MessageContent = "Bu bir Content mesajıdır.";
            message.MessageSender = "Admin İK";
            message.MessageReceiver = "Herkes";
            message.MessageSubject = "Deneme yapıyoruz.";
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }

        public IActionResult Index2()
        {
            Message message = new Message();
            message.MessageSender = "Bu bir Subject mesajıdır.";
            message.MessageReceiver = "Team Lead";
            message.MessageContent = "Herkes.";
            message.MessageSubject = "Merhaba";

            CreateNewMessage createNewMessage = new CreateNewMessage();
            EncryptoBySubjectDecorator encryptoBySubjectDecorator = new EncryptoBySubjectDecorator(createNewMessage); encryptoBySubjectDecorator.SendMessageByEncryptoSubject(message);
            return View();
        }
    }
}
