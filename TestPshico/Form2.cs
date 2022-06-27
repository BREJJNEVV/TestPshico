using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPshico
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // достать номер вопроса и сам вопрос 
            // отправть ответ
            // посчитать результат


            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

           

            for (int i = 1; i <= 58; i++)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `question` WHERE `Num_Question` == i");
            }
        }

    }
}
