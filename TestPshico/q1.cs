using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestPshico
{
    public partial class q1 : Form
    {
        
        public q1()
        {
            InitializeComponent();
            DataBank.NamberQuest += 1;

            //question.Text = ffd.ReadLine();

            //question.Text = ffd.WriteLine();


            int counter = 0;
            foreach (string line in File.ReadLines(@"Вопросы.TXT"))
            {
                //Console.WriteLine(line);
                
                counter++;
                if (counter == DataBank.NamberQuest)
                {
                    question.Text = line;
                    break;
                }
            }
        }


        
        private void button1_Click(object sender, EventArgs e) // нет
        {
            //question.Text = ffd.ReadLine();

            DataBank.NamberQuest += 1;
            int counter = 0;
            foreach (string line in File.ReadLines(@"Вопросы.TXT"))
            {

                counter++;
                if (counter == DataBank.NamberQuest)
                {
                    question.Text = line;
                    label2.Text = counter + " /58";
                    break;
                }
            }
        }

        

        private void Yes_Click(object sender, EventArgs e)    // да
        {
            DataBank.NamberQuest += 1;

            int counter = 0;

            if (DataBank.NamberQuest == 59)
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            if (DataBank.NamberQuest == 3 || counter == 5 || counter == 5 || counter == 52 || counter == 4 || counter == 7 || counter == 12 || counter == 16 || counter == 21 || counter == 23 || counter == 26 || counter == 28 || counter == 46 || counter == 47 || counter == 48 || counter == 49 || counter == 50 || counter == 51 || counter == 52 || counter == 53 || counter == 54 || counter == 55 || counter == 56 || counter == 57 || counter == 58)
                DataBank.counter1++;
           
            foreach (string line in File.ReadLines(@"Вопросы.TXT"))
            {
                

                counter++;
                if (counter == DataBank.NamberQuest)
                {
                    
                    question.Text = line;
                    label2.Text = counter + " /58";
                    break;
                }
            }
        }
    }
}
