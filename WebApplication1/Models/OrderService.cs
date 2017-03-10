using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrdersService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrders(Models.Orders order)
        {
            //todo
        }
        /// <summary>
        /// 依照Id 取得訂單資料
        /// </summary>
        /// <returns></returns>
        public Models.Orders GetOrdersById(string orderId)
        {
            //todo
            Models.Orders result = new Orders();
            result.CustId = "GSS";
            result.CustName = "叡楊";
            return result;           
        }
        /// <summary>
        /// 依照條件取得訂單資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Orders> GetOrdersByCondtioin()
        {
            //todo
            List<Models.Orders> result = new List<Orders>();
            result.Add(new Orders() { CustId = "001", CustName = "叡揚資訊", EmpId = 1, EmpName = "王小明", Orderdate = DateTime.Parse("2015/11/08") });
            result.Add(new Orders() { CustId = "002", CustName = "網軟資訊", EmpId = 2, EmpName = "李小華", Orderdate = DateTime.Parse("2015/11/01") });
            return result;
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrdersById(string orderId)
        {
            //todo
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrders(Models.Orders order)
        {
            //todo
        }

    }
}
