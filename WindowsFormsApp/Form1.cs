using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ListFindCountries_Form : Form
    {
        public ListFindCountries_Form()
        {
            InitializeComponent();

            List<Country> countries = new List<Country>
            {
                new Country {Id = 1, Name = "Австралия"},
                new Country {Id = 30, Name = "Великобритания"},
                new Country {Id = 43, Name = "Германия"},
                new Country {Id = 46, Name = "Греция" },
                new Country {Id = 62, Name = "Исландия"},
                new Country {Id = 70, Name = "Канада"},
                new Country {Id = 121, Name = "Норвегия"},
                new Country {Id = 132, Name = "Россия"},
                new Country {Id = 151, Name = "США"}
            };

            Countries_listBox.DisplayMember = "Name";
            Countries_listBox.ValueMember = "Id";
            Countries_listBox.DataSource = countries;

            Countries_comboBox.DisplayMember = "Name";
            Countries_comboBox.DataSource = countries;

            string[] countries_names = {"Австралия", "Великобритания", "Германия", "Греция", "Исландия", "Канада", "Норвегия", 
                "Россия", "США" };
            Name_domainUpDown.Items.AddRange(countries_names);

            string[] findCountryCategories = { "Id страны по названию", "Название страны по Id" };
            Categories_checkedListBox.Items.AddRange(findCountryCategories);

            Categories_checkedListBox.CheckOnClick = true;
            Id_numericUpDown.Enabled = false;
            Name_domainUpDown.Enabled = false;

            Categories_checkedListBox.SelectedIndexChanged += Categories_checkedListBox_SelectedIndexChanged;
            GetOutput_button.Click += GetOutput_button_Click;
        }

        void Categories_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory = Categories_checkedListBox.SelectedItem.ToString();

            if (SelectedCategory == "Id страны по названию")
            {
                Id_numericUpDown.Enabled = false;
                Name_domainUpDown.Enabled = true;
            }
            else if (SelectedCategory == "Название страны по Id")
            {
                Name_domainUpDown.Enabled = false;
                Id_numericUpDown.Enabled = true;
            }
        }

        void GetOutput_button_Click(object sender, EventArgs e)
        {
            if (Name_domainUpDown.Enabled == false)
            {
                int InputId = (int)Id_numericUpDown.Value;
                Country Id_country = (Country)Countries_listBox.Items[InputId - 1];
                string Name_country = Id_country.Name;
                MessageBox.Show("Название страны под " + InputId + "-ым Id — " + Name_country + ".");
            }
            
        }
    }
}

class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
}