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
    public partial class F_AddSize : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ISizeService _serviceS;

        public F_AddSize(ISizeService serviceS)
        {
            InitializeComponent();
            _serviceS = serviceS;
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
                _serviceS.CreateSize(new SizeBM
                {
                    Name = F_Name.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
