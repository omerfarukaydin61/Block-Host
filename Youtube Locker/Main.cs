using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Locker
{
    public partial class Main : Form
    {
        repository repository = new repository();
        public Main()
        {
            InitializeComponent();
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            repository.AllowYoutube();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            repository.BlockYoutube();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
