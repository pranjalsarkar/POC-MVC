using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chat.Models;
using Newtonsoft.Json;

namespace Chat.Controllers
{
    public class ChatController : Controller
    {
        private static List<OrderList> dataModel;

        // GET: Chat
        public ActionResult Index()
        {
            dataModel = new List<OrderList>{
                new OrderList() {CustomerName="ABC", OrderNo="161afec7-380a-43e6-9bf7-614d5210dbd9", TotalCost=150},
                new OrderList() {CustomerName="XYZ", OrderNo="f8d4068e-e81f-4231-b623-6e64cf996b01", TotalCost=250}
            };

            return View(dataModel);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
         
            if (dataModel == null)
            {
                dataModel = new List<OrderList>{
                new OrderList() {CustomerName="ABC", OrderNo="161afec7-380a-43e6-9bf7-614d5210dbd9", TotalCost=150},
                new OrderList() {CustomerName="XYZ", OrderNo="f8d4068e-e81f-4231-b623-6e64cf996b01", TotalCost=250}
            };
            }

            return PartialView("Chat", dataModel);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            var Model = new Order();
            Model.OrderNo = Guid.NewGuid().ToString();
            return PartialView(Model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mdl"></param>
        /// <returns></returns>
        [HttpPost]
        public string CreateOrder(OrderList Mdl)
        {
            dataModel.Add(Mdl);
            return JsonConvert.SerializeObject(dataModel);
        }
    }
}
