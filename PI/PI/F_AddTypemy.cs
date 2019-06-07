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
    public partial class F_AddTypemy : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITypemyService _serviceT;

        public F_AddTypemy(ITypemyService serviceT)
        {
            _serviceT = serviceT;
            InitializeComponent();
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(F_Name.Text))
            {
                MessageBox.Show("Заполните Name");
                return;
            }
            try
            {
                _serviceT.CreateTypemy(new TypemyBM
                {
                    Name = F_Name.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_AddType_Load(object sender, EventArgs e)
        {

        }
    }
}
