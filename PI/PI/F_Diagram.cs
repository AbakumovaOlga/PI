using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PI
{
    public partial class F_Diagram : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IOrderService _serviceO;
        private readonly IUserService _serviceU;

        public F_Diagram(IOrderService serviceO, IUserService serviceU)
        {
            InitializeComponent();
            _serviceO = serviceO;
            _serviceU = serviceU;
        }

        private void F_Diagram_Load(object sender, EventArgs e)
        {
            F_Chart.Series.Clear();

            List<UserBM> users = _serviceU.GetList();

            foreach(var user in users)
            {
                F_Chart.Series.Add(user.Name);
                F_Chart.Series[user.Name].Points.AddY(_serviceU.GetCountOrders(user.Id));
            }
        }
    }
}
