using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class FrmTickets : Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {
            int age;
            double price=0;

            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter Your Age ", "Tickets", ""));

            if (age <=12)
            {
                price = 5.00;
            }
            else if (age >=13 && age <=20)
            {
                price = 6.00;

            }
            else if (age >=21 && age <= 64)
            {
                price = 10.00;
            }
            else if (age >= 65)
            {
                price = 2.00;
            }
            MessageBox.Show("Your price is" + price.ToString("c"));
        }
    }
}
