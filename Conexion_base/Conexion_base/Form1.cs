using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pokemon_base pokemon_Base = new Pokemon_base();
            PokemosList.DataSource = pokemon_Base.Listar();  
        }

        private void PokemosList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
