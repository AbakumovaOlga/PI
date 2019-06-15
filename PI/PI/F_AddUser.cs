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
    public partial class F_AddUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IUserService _serviceU;

        public F_AddUser(IUserService serviceU)
        {
            InitializeComponent();
            _serviceU = serviceU;
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(F_Login.Text) || string.IsNullOrEmpty(F_Password.Text) || string.IsNullOrEmpty(F_Name.Text))
                {
                    MessageBox.Show("Заполните поля на форме");
                    return;
                }

                _serviceU.CreateUser(new User
                {
                    Name = F_Name.Text,
                    Login = F_Login.Text,
                    Password = F_Password.Text
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
