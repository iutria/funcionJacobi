namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.cmbTipoIteracion = new System.Windows.Forms.ComboBox();
            this.cmbTipoError = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarMatrizDominanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarValoresSemillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.txtCifras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(153, 76);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(135, 23);
            this.txtEntrada.TabIndex = 5;
            // 
            // cmbTipoIteracion
            // 
            this.cmbTipoIteracion.FormattingEnabled = true;
            this.cmbTipoIteracion.Items.AddRange(new object[] {
            "Por Error",
            "Por Numero de iteraciones"});
            this.cmbTipoIteracion.Location = new System.Drawing.Point(12, 41);
            this.cmbTipoIteracion.Name = "cmbTipoIteracion";
            this.cmbTipoIteracion.Size = new System.Drawing.Size(276, 23);
            this.cmbTipoIteracion.TabIndex = 6;
            this.cmbTipoIteracion.Text = "Por Error";
            this.cmbTipoIteracion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTipoError
            // 
            this.cmbTipoError.FormattingEnabled = true;
            this.cmbTipoError.Items.AddRange(new object[] {
            "Error Relativo",
            "Error Absoluto"});
            this.cmbTipoError.Location = new System.Drawing.Point(12, 76);
            this.cmbTipoError.Name = "cmbTipoError";
            this.cmbTipoError.Size = new System.Drawing.Size(135, 23);
            this.cmbTipoError.TabIndex = 7;
            this.cmbTipoError.Text = "Error Relativo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarMatrizDominanteToolStripMenuItem,
            this.seleccionarValoresSemillaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // seleccionarMatrizDominanteToolStripMenuItem
            // 
            this.seleccionarMatrizDominanteToolStripMenuItem.Name = "seleccionarMatrizDominanteToolStripMenuItem";
            this.seleccionarMatrizDominanteToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.seleccionarMatrizDominanteToolStripMenuItem.Text = "Seleccionar Matriz Dominante";
            this.seleccionarMatrizDominanteToolStripMenuItem.Click += new System.EventHandler(this.seleccionarMatrizDominanteToolStripMenuItem_Click);
            // 
            // seleccionarValoresSemillaToolStripMenuItem
            // 
            this.seleccionarValoresSemillaToolStripMenuItem.Name = "seleccionarValoresSemillaToolStripMenuItem";
            this.seleccionarValoresSemillaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.seleccionarValoresSemillaToolStripMenuItem.Text = "Seleccionar Valores Semilla";
            this.seleccionarValoresSemillaToolStripMenuItem.Click += new System.EventHandler(this.seleccionarValoresSemillaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFuncion
            // 
            this.lblFuncion.Location = new System.Drawing.Point(310, 70);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(478, 107);
            this.lblFuncion.TabIndex = 10;
            this.lblFuncion.Text = "Funcion";
            // 
            // lblSemilla
            // 
            this.lblSemilla.Location = new System.Drawing.Point(310, 41);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(478, 23);
            this.lblSemilla.TabIndex = 11;
            this.lblSemilla.Text = "Semillas Cargadas:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 199);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowTemplate.Height = 25;
            this.dgvResultado.Size = new System.Drawing.Size(276, 211);
            this.dgvResultado.TabIndex = 12;
            // 
            // txtCifras
            // 
            this.txtCifras.Location = new System.Drawing.Point(153, 111);
            this.txtCifras.Name = "txtCifras";
            this.txtCifras.Size = new System.Drawing.Size(135, 23);
            this.txtCifras.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cifras Significativas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero de iteraciones";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(427, 199);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(13, 15);
            this.lblIteraciones.TabIndex = 16;
            this.lblIteraciones.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCifras);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbTipoError);
            this.Controls.Add(this.cmbTipoIteracion);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtEntrada;
        private ComboBox cmbTipoIteracion;
        private ComboBox cmbTipoError;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem seleccionarMatrizDominanteToolStripMenuItem;
        private ToolStripMenuItem seleccionarValoresSemillaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblFuncion;
        private Label lblSemilla;
        private DataGridView dgvResultado;
        private TextBox txtCifras;
        private Label label1;
        private Label label2;
        private Label lblIteraciones;
    }
}