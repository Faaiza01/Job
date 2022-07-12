using Job.Data.IDAO;
using Job.Data.Repository;
using Job.Services.IService;
using Job.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Data.Models.Domain;
using Job.Data.DAO;

namespace Job.Services.Service
{
    public class OrderService : IOrderService
    {
        private IMusicDAO musicDAO;
        private IOrderDAO orderDAO;
        private IUserDAO userDAO;
        private IOrderLineDAO orderLineDAO;

        public OrderService()
        {
            musicDAO = new MusicDAO();
            orderDAO = new OrderDAO();
            userDAO = new UserDAO();
            orderLineDAO = new OrderLineDAO();

        }

        //public void AddOrder(CheckOutUser checkOutUser)
        //{
        //    using (var context = new JobContext()) //Unit of work starts
        //    {             
        //        Order order = new Order();
        //        order.DelAddress = checkOutUser.DelAddress;            

        //        foreach (var item in checkOutUser.Cart) //Going through each item in the cart of the current user
        //        {
        //            OrderLine orderLine = new OrderLine();
        //            orderLine.Quantity = item.Quantity;

        //            orderLineDAO.AddOrderLine(context, orderLine); //Orderline added to orderlines collection
                    
        //            order.OrderLines.Add(orderLine); //Orderline added to the current order

        //            Music music = musicDAO.GetMusic(context, item.Music.ID); //Preparing the music with current item/music in the cart with ID
        //            musicDAO.AddToCollection(context, orderLine, item.Music.ID); //Orderline added to current Music's orderline collection
        //            userDAO.AddToMusicCollection(context, checkOutUser.User.Name, music); //Music added to user's music collection
        //        }
                
        //        orderDAO.AddOrder(context, order); //Order added to orders collection
        //        userDAO.AddToOrderCollection(context, checkOutUser.User.UserId, order); //Completed order is added to User's order collection
                
        //        context.SaveChanges(); //Unit of work commited
        //    }
            
        //}
    }
}
