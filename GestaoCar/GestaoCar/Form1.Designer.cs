
namespace GestaoCar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricaoVeiculo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMecanico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtPlacaVeiculoCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorItem = new System.Windows.Forms.TextBox();
            this.txtQtdItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.lblValorTotalServico = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLocalPdf = new System.Windows.Forms.TextBox();
            this.btnSalvarPDF = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listViewAnexo = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricaoVeiculo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMecanico);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOrdemServico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPesquisaCliente);
            this.groupBox1.Controls.Add(this.txtPlacaVeiculoCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Cliente";
            // 
            // txtDescricaoVeiculo
            // 
            this.txtDescricaoVeiculo.Location = new System.Drawing.Point(296, 73);
            this.txtDescricaoVeiculo.Name = "txtDescricaoVeiculo";
            this.txtDescricaoVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoVeiculo.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Descrição Veículo";
            // 
            // txtMecanico
            // 
            this.txtMecanico.Location = new System.Drawing.Point(501, 20);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(200, 20);
            this.txtMecanico.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mecânico";
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Location = new System.Drawing.Point(296, 20);
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(121, 20);
            this.txtOrdemServico.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ordem de Serviço";
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(639, 71);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 6;
            this.btnPesquisaCliente.Text = "Procurar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // txtPlacaVeiculoCliente
            // 
            this.txtPlacaVeiculoCliente.Location = new System.Drawing.Point(90, 74);
            this.txtPlacaVeiculoCliente.Name = "txtPlacaVeiculoCliente";
            this.txtPlacaVeiculoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaVeiculoCliente.TabIndex = 5;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(90, 49);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(250, 20);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(90, 20);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Cliente";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(30, 144);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(734, 68);
            this.txtDiagnostico.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diagnóstico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adicionar";
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(99, 216);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(450, 21);
            this.cboItem.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(669, 346);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(95, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
            // 
            // txtValorItem
            // 
            this.txtValorItem.Location = new System.Drawing.Point(592, 217);
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.Size = new System.Drawing.Size(100, 20);
            this.txtValorItem.TabIndex = 8;
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.Location = new System.Drawing.Point(727, 217);
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(37, 20);
            this.txtQtdItem.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Qtde";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(30, 375);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(734, 230);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Executado?";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Peça";
            this.columnHeader2.Width = 430;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor Unitário";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor Total";
            this.columnHeader5.Width = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valor Total Serviço";
            // 
            // lblValorTotalServico
            // 
            this.lblValorTotalServico.AutoSize = true;
            this.lblValorTotalServico.Location = new System.Drawing.Point(700, 612);
            this.lblValorTotalServico.Name = "lblValorTotalServico";
            this.lblValorTotalServico.Size = new System.Drawing.Size(43, 13);
            this.lblValorTotalServico.TabIndex = 13;
            this.lblValorTotalServico.Text = "$$$$$$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "PDF";
            // 
            // txtLocalPdf
            // 
            this.txtLocalPdf.Enabled = false;
            this.txtLocalPdf.Location = new System.Drawing.Point(99, 245);
            this.txtLocalPdf.Name = "txtLocalPdf";
            this.txtLocalPdf.Size = new System.Drawing.Size(487, 20);
            this.txtLocalPdf.TabIndex = 15;
            // 
            // btnSalvarPDF
            // 
            this.btnSalvarPDF.Location = new System.Drawing.Point(676, 243);
            this.btnSalvarPDF.Name = "btnSalvarPDF";
            this.btnSalvarPDF.Size = new System.Drawing.Size(88, 23);
            this.btnSalvarPDF.TabIndex = 16;
            this.btnSalvarPDF.Text = "Adicionar PDF";
            this.btnSalvarPDF.UseVisualStyleBackColor = true;
            this.btnSalvarPDF.Click += new System.EventHandler(this.btnSalvarPDF_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(595, 243);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 23);
            this.btnAbrir.TabIndex = 17;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewAnexo
            // 
            this.listViewAnexo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listViewAnexo.HideSelection = false;
            this.listViewAnexo.Location = new System.Drawing.Point(30, 272);
            this.listViewAnexo.Name = "listViewAnexo";
            this.listViewAnexo.Size = new System.Drawing.Size(629, 97);
            this.listViewAnexo.TabIndex = 18;
            this.listViewAnexo.UseCompatibleStateImageBehavior = false;
            this.listViewAnexo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "anexo";
            this.columnHeader6.Width = 625;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.listViewAnexo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSalvarPDF);
            this.Controls.Add(this.txtLocalPdf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblValorTotalServico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQtdItem);
            this.Controls.Add(this.txtValorItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Veicular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.TextBox txtPlacaVeiculoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorItem;
        private System.Windows.Forms.TextBox txtQtdItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMecanico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValorTotalServico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLocalPdf;
        private System.Windows.Forms.Button btnSalvarPDF;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtDescricaoVeiculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listViewAnexo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

