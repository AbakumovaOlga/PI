using PI_Models;
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
        //public Logger logger;

        public F_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F_Status.DataSource = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
            F_Status.SelectedItem = 1;

         //  F_OdersList.DataSource=
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

        }

        private void распечатьСписокПокупокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьТипToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<F_AddTypemy>();
            form.Show();
        }
    }
}
