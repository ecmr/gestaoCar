using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSalvarPDF.Enabled = false;


            ListViewItem item = new ListViewItem("S");
            item.SubItems.Add("BARRA AXIAL DA CAIXA DE DIREÇÃO GM ASTRA");
            item.SubItems.Add("2");
            item.SubItems.Add("R$ 53,00");
            item.SubItems.Add("R$ 106,00");
            listView.Items.Add(item);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
                txtLocalPdf.Text = openFileDialog1.FileName;
            if (!string.IsNullOrEmpty(txtLocalPdf.Text))
                btnSalvarPDF.Enabled = true;
        }

        private void btnSalvarPDF_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLocalPdf.Text);
            listViewAnexo.Items.Add(item);
            btnSalvarPDF.Enabled = false;
            txtLocalPdf.Text = string.Empty;
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
