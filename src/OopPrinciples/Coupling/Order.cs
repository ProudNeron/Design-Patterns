using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class Order 
    {
        private readonly INotificationService _notificationService;
        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            //Place order logic

            _notificationService.SendNotification("Order placed successfully");
        }
    }
}