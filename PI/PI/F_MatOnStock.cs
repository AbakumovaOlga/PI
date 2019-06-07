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
    public partial class F_MatOnStock : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMaterialService _serviceMat;

        public F_MatOnStock(IMaterialService serviceMat)
        {
            InitializeComponent();
            _serviceMat = serviceMat;
        }

        private void F_MatOnStock_Load(object sender, EventArgs e)
        {
            F_Materials.DataSource = null;
            F_Materials.DataSource = _serviceMat.GetListOnStock();
        }
    }
}
