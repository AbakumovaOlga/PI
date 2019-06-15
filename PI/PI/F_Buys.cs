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
    public partial class F_Buys : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IBuyService _serviceB;

        public F_Buys(IBuyService serviceB)
        {
            InitializeComponent();
            _serviceB = serviceB;
        }

        private void F_Buys_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            F_List.DataSource = null;
            F_List.DataSource = _serviceB.GetList();
        }

        private void F_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddBuy>();
            form.Show();
            LoadData();
        }

        private void F_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
