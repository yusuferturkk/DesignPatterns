﻿using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        Context context = new Context();
        private readonly INotifier _notifier;

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotifier(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "GMail - Outlook";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }

        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotifier(notifier);
        }
    }
}
