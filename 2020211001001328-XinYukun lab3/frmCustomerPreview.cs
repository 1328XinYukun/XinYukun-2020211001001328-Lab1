using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020211001001328_XinYukun_lab3
{
    public partial class frmCustomerPreview : Form
    {
        public frmCustomerPreview()
        {
            InitializeComponent();
        }
        public void SetValues(string Name,string Country,string Gender,string Hobby,string Status)
        {
            label1.Text = Name;
            label2.Text = Country;
            label3.Text = Gender;
            label4.Text = Hobby;
            label5.Text = Status;
        }
    }
}
