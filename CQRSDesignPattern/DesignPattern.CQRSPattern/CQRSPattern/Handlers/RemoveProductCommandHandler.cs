﻿using DesignPattern.CQRSPattern.CQRSPattern.Commands;
using DesignPattern.CQRSPattern.DataAccessLayer;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
