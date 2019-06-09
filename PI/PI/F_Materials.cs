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
    public partial class F_Materials : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMaterialService _serviceMat;

        public F_Materials(IMaterialService serviceMat)
        {
            InitializeComponent();
            _serviceMat = serviceMat;
        }

        private void F_Materials_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            F_List.DataSource = null;
            F_List.DataSource = _serviceMat.GetList();
        }
        private void F_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddMat>();
            form.Show();
            LoadData();
        }
    }
}
