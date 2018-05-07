using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bazaSQLite
{
    public partial class Menu : Form
    {
        Person oPerson = new Person("Staszek", "Olejnik", "58121212836");

        public Menu()
        {
            InitializeComponent();

            lblFirstName.Text = oPerson.FirstName;

            txtFirsName.Text = oPerson.FirstName;
            txtName.Text = oPerson.LastName;
            txtPesel.Text = oPerson.Pesel;

        }



        private void lblFirstName_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = "Ja ci kliknę";
        }
    }
}
