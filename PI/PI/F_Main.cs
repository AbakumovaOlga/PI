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
    public partial class F_Main : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int userId { get; set; }

        private readonly IOrderService _serviceO;
        private readonly IMaterialService _serviceMat;

        //public Logger logger;

        public F_Main( IOrderService serviceO, IMaterialService serviceMat)
        {
            InitializeComponent();
            _serviceO = serviceO;
            _serviceMat = serviceMat;
            F_Status.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F_Status.DataSource = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
            F_Status.SelectedIndex = -1;

            F_OdersList.DataSource = _serviceO.GetList();
        }

        private void добавитьМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddMat>();
            form.Show();

        }

        private void добавитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddSize>();
            form.Show();
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddUser>();
            form.Show();
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddOrder>();
            form.Show();
        }

        private void закупкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddBuy>();
            form.Show();
        }

        private void вНаличииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_MatOnStock>();
            form.Show();
        }

        private void распечатьСписокПокупокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc|docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //CreateDoc(sfd.FileName);

                    if (_serviceMat.ListShop(sfd.FileName))
                    {
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("не удалось сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void добавитьТипToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddTypemy>();
            form.Show();
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_Materials>();
            form.Show();
        }

        private void F_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (F_Status.SelectedIndex != -1)
            {
                F_OdersList.DataSource = _serviceO.GetListSatus((OrderStatus)Enum.Parse(typeof(OrderStatus), F_Status.SelectedValue.ToString()));
            }
        }



        private void LoadData()
        {
            if (F_Status.SelectedIndex != -1)
                F_OdersList.DataSource = _serviceO.GetListSatus((OrderStatus)Enum.Parse(typeof(OrderStatus), F_Status.SelectedValue.ToString()));
        }

        private void F_Clear_Click(object sender, EventArgs e)
        {
            F_Status.SelectedIndex = -1;

            F_OdersList.DataSource = _serviceO.GetList();
        }

        private void типыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_Typemys>();
            form.Show();
        }

        private void размерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_Sizes>();
            form.Show();
        }

        private void покупкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_Buys>();
            form.Show();
        }

        private void F_Del_Click(object sender, EventArgs e)
        {
            if (F_OdersList.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _serviceO.DelOrder(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void F_OdersList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (F_OdersList.SelectedRows.Count == 1)
            {
                switch (_serviceO.GetStatus(Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value)))
                {

                    case OrderStatus.Принят:
                        try
                        {
                            if (MessageBox.Show("Принять в обработку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int id = Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value);
                                try
                                {
                                    _serviceO.TakeOrderInWork(id,userId);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                LoadData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case OrderStatus.Выполняется:
                        if (MessageBox.Show("Готов?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value);
                            try
                            {
                                _serviceO.FinishOrder(id);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            LoadData();
                        }
                        break;
                    case OrderStatus.Готов:
                        if (MessageBox.Show("Оплачен?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value);
                            try
                            {
                                _serviceO.PayOrder(id);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            LoadData();
                        }
                        break;
                }
            }
        }

        private void F_Inf_Click(object sender, EventArgs e)
        {
            if (F_OdersList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(F_OdersList.SelectedRows[0].Cells[0].Value);
                var form = Container.Resolve<F_InfOrder>();
                form.orderId = id;
                form.Show();
            }

        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_Diagram>();
            form.Show();
        }
        
    }
}
