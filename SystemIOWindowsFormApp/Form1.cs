using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global
        DataOperations dataOperations = new DataOperations();
        Personnel chosenPersonnel = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            btnBringPersonnel.Click += new EventHandler(btnBringPersonnel_Click);

            listBoxPersonnel.DoubleClick += new EventHandler(listBoxPersonnel_DoubleClick);

            btnPersonnelInfoSave.Click += new EventHandler(btnPersonnelInfoSave_Click);

            foreach (var item in this.Controls)
            {
                var theItem = item.GetType();
                
                if (theItem.Name == "GroupBox" && ((GroupBox)item).Name == "groupBoxPersonnelDetail")
                {
                    foreach (var subitems in ((GroupBox)item).Controls)
                    {
                        if (subitems is TextBox)
                        {
                            ((TextBox)subitems).ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void btnPersonnelInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                string savedPathInfo = string.Empty;
                //path required.
                if (chosenPersonnel != null)
                {
                    bool check = dataOperations.SavePersonnel(@"C:\\Emre", chosenPersonnel,  out savedPathInfo);
                    if (check)
                    {
                        MessageBox.Show($"{chosenPersonnel.ToString()} has been saved to computer..\nPath: {savedPathInfo}");
                    }
                    else
                    {
                        throw new Exception($"{chosenPersonnel.ToString()} has not been saved to computer");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a personnel!");
                    listBoxPersonnel.SelectedIndex = -1;

                    //Cleaning texts and listbox.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error has occured");
            }

        }

        private void btnBringPersonnel_Click(object sender, EventArgs e)
        {
            listBoxPersonnel.DataSource = dataOperations.BringAllPersonnel();       //5 personnel are brougt with fakedata


        }

        private void listBoxPersonnel_DoubleClick(object sender, EventArgs e)
        {
            chosenPersonnel = listBoxPersonnel.SelectedItem as Personnel;
            textName.Text = chosenPersonnel.Name;
            textSurname.Text = chosenPersonnel.Surname;
            textEmail.Text = chosenPersonnel.Email;
            textCompany.Text = chosenPersonnel.Company;
            textCountry.Text = chosenPersonnel.Country;
        }
    }
}
