using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pozdra
{
    public partial class Form1 : Form
    {
        BdayPeople bdayperson = new BdayPeople();

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();

        }

        private void PopulateDataGridView()
        {
            BdayDatabaseEntities db = new BdayDatabaseEntities();
            gridBirthdays.DataSource = db.BdayPeoples.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gridBirthdays_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridBirthdays_Click(object sender, EventArgs e)
        {

        }




    }
}
