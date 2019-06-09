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
    public partial class F_Sizes : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ISizeService _serviceS;

        public F_Sizes(ISizeService serviceS)
        {
            InitializeComponent();
            _serviceS = serviceS;
        }

        private void F_Sizes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void F_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddSize>();
            form.Show();
            LoadData();
        }

        private void LoadData()
        {
            F_List.DataSource = null;
            F_List.DataSource = _serviceS.GetList();
        }
    }
}
