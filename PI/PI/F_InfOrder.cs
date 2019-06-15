using PI_Models;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PI
{
    public partial class F_InfOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IOrderService _serviceO;

        public int orderId { set; get; }
        public Order order;

        public F_InfOrder(IOrderService serviceO)
        {
            InitializeComponent();
            _serviceO = serviceO;
        }

        private void F_InfOrder_Load(object sender, EventArgs e)
        {
            order = _serviceO.GetOrder(orderId);
            if (order != null)
            {
                F_Customer.Text = order.Customer;
                F_Date.Value = order.DateCreate;
                F_ListMaterials.DataSource = _serviceO.GetOrderMaterials(order.Id);
                F_Sum.Text = order.Summa.ToString();
            }

            F_ListMaterials.Columns[2].Visible = false;
            F_ListMaterials.Columns[3].Visible = false;
        }
    }
}

