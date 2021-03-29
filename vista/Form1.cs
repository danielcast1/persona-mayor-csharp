using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lib_busines_logic;

namespace vista
{
    public partial class Form1 : Form
    {
        private OlderPerson oldP = new OlderPerson();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveUser();
            clearFields();
        }

        private Person fillFields()
        {
            try {
                int age = Convert.ToInt32(tAge.Text);

                Person p = new Person(tName.Text,age );

                return p;
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                return null;
            };
          
        }
        private void clearFields()
        {
            tName.Text = "";
            tAge.Text = "";

        }

       
        private bool saveUser()
        {
          
            return oldP.addPerson(fillFields()) ? true : false;

        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            if (isEmptyList())
            {
                MessageBox.Show("La lista esta vacia");
                return;
            }
           var old= olderPerson();
            MessageBox.Show(old.name+" :"+old.age.ToString());
           
        }

        private bool isEmptyList() =>oldP.people.ToArray().Length == 0 ? true : false;
        private Person olderPerson()=>oldP.olderPerson();
    }
}
