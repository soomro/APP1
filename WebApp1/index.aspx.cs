using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp1.Model;

namespace WebApp1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (NORTHWNDEntities n = new NORTHWNDEntities())
                {
                    var orders = n.Orders.OrderBy(o => o.OrderID);

                    foreach (Order o in orders)
                    {
                        ListItem li = new ListItem();
                        li.Text = o.OrderID.ToString();
                        li.Value = o.OrderID.ToString();
                        ddl.Items.Add(li);
                    }
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NORTHWNDEntities n = new NORTHWNDEntities())
            {
                int orderID = System.Convert.ToInt32(ddl.SelectedValue);

                var order = n.Orders.FirstOrDefault(o => o.OrderID == orderID);

                if (order != null)
                {
                    lblOrder.Text = order.OrderID.ToString();
                    lblCustomer.Text = order.Customer.ContactName;
                    gvProducts.DataSource = (from o in order.Order_Details
                                             select new
                                             {
                                                 o.Product.ProductName,
                                                 o.Product.UnitPrice,
                                                 o.Product.UnitsInStock
                                             }).ToList();
                    gvProducts.DataBind();
                }

            }

        }
    }
}