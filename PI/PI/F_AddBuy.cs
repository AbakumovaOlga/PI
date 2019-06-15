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
    public partial class F_AddBuy : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IBuyService _serviceB;

        private List<MaterialBuyBM> MaterialBuys;

        public F_AddBuy(IBuyService serviceB)
        {
            InitializeComponent();
            _serviceB = serviceB;
        }

        private void F_AddMat_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_MaterialBuy>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    MaterialBuys.Add(form.model);
                }
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                if (MaterialBuys != null)
                {
                    F_Materials.DataSource = null;
                    F_Materials.DataSource = MaterialBuys;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_DelMat_Click(object sender, EventArgs e)
        {
            if (F_Materials.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MaterialBuys.RemoveAt(F_Materials.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            try
            {
                List<MaterialBuyBM> MaterialBuysBM = new List<MaterialBuyBM>();
                for (int i = 0; i < MaterialBuys.Count; ++i)
                {
                    MaterialBuysBM.Add(new MaterialBuyBM
                    {
                        Id = MaterialBuys[i].Id,
                        MaterialId = MaterialBuys[i].MaterialId,
                        BuyId = MaterialBuys[i].BuyId,
                        Count = MaterialBuys[i].Count,
                        Name= MaterialBuys[i].Name

                    });
                }

                if (MaterialBuysBM.Count == 0)
                {
                    MessageBox.Show("Список пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _serviceB.CreateBuy(new BuyBM
                {
                    Date = F_Date.Value,
                    MaterialBuys = MaterialBuysBM
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

        private void F_AddBuy_Load(object sender, EventArgs e)
        {
            MaterialBuys = new List<MaterialBuyBM>();
        }
    }
}
