using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotes
{
    public partial class FormCountry : Form
    {
        public CountryData CountryData;
        BindingList<CountryData> countryList = new();
        public FormCountry()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCountry_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
      
                csv.WriteRecords(countryList);
            };
        }
    }
}
