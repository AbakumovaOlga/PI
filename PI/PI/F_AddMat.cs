using PI_Service;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PI
{
    public partial class F_AddMat : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ISizeService _serviceS;
        private readonly ITypemyService _serviceT;
        private readonly IMaterialService _serviceMat;

        // private readonly IMainService _serviceM;

        public F_AddMat(ISizeService serviceS, IMaterialService serviceMat, ITypemyService serviceT)
        {
            InitializeComponent();
            _serviceS = serviceS;
            _serviceMat = serviceMat;
            _serviceT = serviceT;
        }

        private void F_AddSize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(F_NewSize.Text))
            {
                MessageBox.Show("Заполните новый размер");
                return;
            }
            try
            {
                _serviceS.CreateSize(new SizeBM
                {
                    Name = F_NewSize.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading();
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (F_ChooseType.SelectedValue == null || string.IsNullOrEmpty(F_Price.Text) || F_ChooseSize.SelectedValue == null)
                {
                    MessageBox.Show("Заполните поля на форме");
                    return;
                }
                if (Check())
                {
                    _serviceMat.CreateMaterial(new MaterialBM
                    {
                        Price = Convert.ToDouble(F_Price.Text),
                        SizeId = Convert.ToInt32(F_ChooseSize.SelectedValue),
                        TypeId = Convert.ToInt32(F_ChooseType.SelectedValue)
                    });

                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    // Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Check()
        {
           
            string resCheck = CheckFields.CheckPrice(F_Price.Text);
            if (resCheck != "")
            {
                MessageBox.Show(resCheck);
                return false;
            }
            return true;
        }

        private void F_AddMat_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void Loading()
        {
            try
            {
                List<SizeBM> list = _serviceS.GetList();
                if (list != null)
                {
                    F_ChooseSize.DisplayMember = "Name";
                    F_ChooseSize.ValueMember = "Id";
                    F_ChooseSize.DataSource = list;
                    F_ChooseSize.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                List<TypemyBM> list = _serviceT.GetList();
                if (list != null)
                {
                    F_ChooseType.DisplayMember = "Name";
                    F_ChooseType.ValueMember = "Id";
                    F_ChooseType.DataSource = list;
                    F_ChooseType.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_AddType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(F_NewType.Text))
            {
                MessageBox.Show("Заполните новый размер");
                return;
            }
            try
            {
                _serviceT.CreateTypemy(new TypemyBM
                {
                    Name = F_NewType.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading();
        }
    }
}
