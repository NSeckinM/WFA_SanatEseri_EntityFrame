using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SanatEseri_EntityFrame.Models;

namespace WFA_SanatEseri_EntityFrame
{
    public partial class Form1 : Form
    {
        SanatOkuluContext db = new SanatOkuluContext();

        public Form1()
        {
            InitializeComponent();
        }

    }
}
