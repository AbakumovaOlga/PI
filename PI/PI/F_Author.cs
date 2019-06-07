using PI_Models;
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
    public partial class F_Author : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMainService _serviceM;
        private User user;

        public F_Author(IMainService serviceM)
        {
            
            InitializeComponent();
            _serviceM = serviceM;

            F_Login.Text = "l";
            F_Password.Text = "p";
        }

        private void F_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                user = _serviceM.Author(F_Login.Text, F_Password.Text);

                var form = Container.Resolve<F_Main>();
                form.userId = user.Id;
                // form.logger = logger;
                form.Show();

                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Create_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddUser>();
            form.Show();
        }
    }
}
