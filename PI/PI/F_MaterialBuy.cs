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
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PI
{
    public partial class F_MaterialBuy : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMaterialService _serviceMat;
        public MaterialBuyBM model { set; get; }

        public F_MaterialBuy(IMaterialService serviceMat)
        {

            InitializeComponent();
            _serviceMat = serviceMat;
        }

        private void F_MaterialBuy_Load(object sender, EventArgs e)
        {
            try
            {
                List<MaterialBM> list = _serviceMat.GetList();
                if (list != null)
                {
                    F_ChooseMat.DisplayMember = "Name";
                    F_ChooseMat.ValueMember = "Id";
                    F_ChooseMat.DataSource = list;
                    F_ChooseMat.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(F_Count.Text) || F_ChooseMat.SelectedValue == null)
                {
                    MessageBox.Show("Заполните поля на форме", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Check())
                {

                    model = new MaterialBuyBM
                    {
                        MaterialId = Convert.ToInt32(F_ChooseMat.SelectedValue),
                        Count = Convert.ToInt32(F_Count.Text),
                        Name = _serviceMat.GetElement(Convert.ToInt32(F_ChooseMat.SelectedValue)).Name

                    };

                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Check()
        {
            string resCheck = CheckFields.CheckCount(F_Count.Text);
            if (resCheck != "")
            {
                MessageBox.Show(resCheck);
                return false;
            }
            return true;
        }
    }
}
