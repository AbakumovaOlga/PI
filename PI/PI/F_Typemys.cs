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
    public partial class F_Typemys : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITypemyService _serviceT;

        public F_Typemys(ITypemyService serviceT)
        {
            InitializeComponent();
            _serviceT = serviceT;
        }

        private void F_Typemys_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            F_List.DataSource = null;
            F_List.DataSource = _serviceT.GetList();
        }

        private void F_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddTypemy>();
            form.Show();
            LoadData();
        }

        private void F_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
