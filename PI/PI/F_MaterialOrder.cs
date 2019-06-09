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
    public partial class F_MaterialOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMaterialService _serviceMat;
        public MaterialOrderBM model { set; get; }

        public int sizeId { set; get; }

        public F_MaterialOrder(IMaterialService serviceMat)
        {
            InitializeComponent();
            _serviceMat = serviceMat;
        }

        private void F_MaterialOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<MaterialBM> list = _serviceMat.GetListSize(sizeId);
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
                if (F_ChooseMat.SelectedValue == null)
                {
                    MessageBox.Show("Заполните поля на форме", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                    model = new MaterialOrderBM
                    {
                        MaterialId = Convert.ToInt32(F_ChooseMat.SelectedValue),
                        Name = _serviceMat.GetElement(Convert.ToInt32(F_ChooseMat.SelectedValue)).Name
                    };

                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
