using PI_Models;
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
    public partial class F_AddOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IOrderService _serviceO;
        private readonly ISizeService _serviceS;
        private readonly IMaterialService _serviceMat;

        private List<MaterialOrderBM> MaterialOrders;

        public F_AddOrder(IOrderService serviceO, ISizeService serviceS, IMaterialService serviceMat)
        {
            InitializeComponent();

            _serviceO = serviceO;
            _serviceS = serviceS;
            _serviceMat = serviceMat;
        }

        private void F_AddOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<SizeBM> list = _serviceS.GetList();
                if (list != null)
                {
                    F_Size.DisplayMember = "Name";
                    F_Size.ValueMember = "Id";
                    F_Size.DataSource = list;
                    F_Size.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MaterialOrders = new List<MaterialOrderBM>();
            F_Add.Enabled = false;
        }

        private void F_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_MaterialOrder>();
            form.sizeId = Convert.ToInt32(F_Size.SelectedValue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    MaterialOrders.Add(form.model);
                }
                LoadData();
            }
            F_Sum.Text = _serviceO.CountSum(MaterialOrders).ToString();
        }

        private void LoadData()
        {
           

            try
            {
                if (MaterialOrders != null)
                {
                    F_List.DataSource = null;
                    F_List.DataSource = MaterialOrders;
                    //F_Products.Columns[0].Visible = false;
                    //  F_Products.Columns[1].Visible = false;
                    //   F_Products.Columns[2].Visible = false;
                    // F_Products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    double sum = 0;
                    foreach (MaterialOrderBM mo in MaterialOrders)
                    {
                        sum += _serviceMat.GetElement(mo.MaterialId).Price;
                    }
                    F_Sum.Text = sum + "";
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
                List<MaterialOrderBM> MaterialOrdersBM = new List<MaterialOrderBM>();
                for (int i = 0; i < MaterialOrders.Count; ++i)
                {
                    MaterialOrdersBM.Add(new MaterialOrderBM
                    {
                        Id = MaterialOrders[i].Id,
                        MaterialId = MaterialOrders[i].MaterialId,
                        OrderId = MaterialOrders[i].OrderId,
                        Name = MaterialOrders[i].Name
                        
                    });
                }

                if (MaterialOrdersBM.Count == 0)
                {
                    MessageBox.Show("Список пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _serviceO.CreateOrder(new OrderBM
                {
                    DateCreate = F_Date.Value,
                    MaterialOrders = MaterialOrdersBM,
                    Customer = F_Customer.Text,
                    Status = OrderStatus.Принят,
                    Summa=Convert.ToDouble(F_Sum.Text)
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

        private void F_Del_Click(object sender, EventArgs e)
        {
            if (F_List.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MaterialOrders.RemoveAt(F_List.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void F_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            F_Add.Enabled = true;
        }
    }
}
