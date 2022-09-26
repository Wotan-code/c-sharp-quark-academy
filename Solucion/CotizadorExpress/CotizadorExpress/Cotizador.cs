using CotizadorExpress.Views;
using CotizadorPresenters;
using System.Windows.Forms.VisualStyles;
using static CotizadorModel.Camisa;

namespace CotizadorExpress
{
    public partial class Cotizador : Form, ICotizador
    {
        private CotizacionPresenter presenter = new CotizacionPresenter();
        private Panel panel1;
        private Button btnCotizar;
        private ListBox lstCotizaciones;
        private Label label2;
        private Label lblVendedor;
        private Label lblTienda;
        private Label lblDireccion;
        private Panel panel3;
        private Panel panel2;
        private RadioButton rdoCamisa;
        private RadioButton rdoPantalon;
        private CheckBox chkMangaCorta;
        private CheckBox chkCuelloMao;
        private CheckBox chkChupin;
        private NumericUpDown numStock;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdoStandard;
        private RadioButton rdoPremium;
        private GroupBox groupBox4;
        private NumericUpDown numCantidad;
        private Label label5;
        private Label label3;
        private NumericUpDown numPrecio;
        private Label label6;
        private Label label7;
        private Label lblCotizacion;
        private Label label1;

        public Cotizador()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lstCotizaciones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoCamisa = new System.Windows.Forms.RadioButton();
            this.rdoPantalon = new System.Windows.Forms.RadioButton();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPremium = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(379, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(416, 705);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(117, 44);
            this.btnCotizar.TabIndex = 0;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lstCotizaciones
            // 
            this.lstCotizaciones.BackColor = System.Drawing.Color.White;
            this.lstCotizaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstCotizaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstCotizaciones.FormattingEnabled = true;
            this.lstCotizaciones.ItemHeight = 21;
            this.lstCotizaciones.Location = new System.Drawing.Point(12, 805);
            this.lstCotizaciones.Name = "lstCotizaciones";
            this.lstCotizaciones.Size = new System.Drawing.Size(1000, 214);
            this.lstCotizaciones.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(477, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tienda";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.Location = new System.Drawing.Point(12, 227);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 33);
            this.lblVendedor.TabIndex = 5;
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienda.Location = new System.Drawing.Point(12, 175);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(0, 33);
            this.lblTienda.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(715, 175);
            this.lblDireccion.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDireccion.Size = new System.Drawing.Size(0, 33);
            this.lblDireccion.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(12, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 10);
            this.panel2.TabIndex = 4;
            // 
            // rdoCamisa
            // 
            this.rdoCamisa.AutoSize = true;
            this.rdoCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoCamisa.Location = new System.Drawing.Point(63, 33);
            this.rdoCamisa.Name = "rdoCamisa";
            this.rdoCamisa.Size = new System.Drawing.Size(102, 29);
            this.rdoCamisa.TabIndex = 8;
            this.rdoCamisa.TabStop = true;
            this.rdoCamisa.Text = "Camisa";
            this.rdoCamisa.UseVisualStyleBackColor = true;
            this.rdoCamisa.CheckedChanged += new System.EventHandler(this.rdoCamisa_CheckedChanged);
            // 
            // rdoPantalon
            // 
            this.rdoPantalon.AutoSize = true;
            this.rdoPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoPantalon.Location = new System.Drawing.Point(63, 101);
            this.rdoPantalon.Name = "rdoPantalon";
            this.rdoPantalon.Size = new System.Drawing.Size(115, 29);
            this.rdoPantalon.TabIndex = 9;
            this.rdoPantalon.TabStop = true;
            this.rdoPantalon.Text = "Pantalón";
            this.rdoPantalon.UseVisualStyleBackColor = true;
            this.rdoPantalon.CheckedChanged += new System.EventHandler(this.rdoPantalon_CheckedChanged);
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMangaCorta.Location = new System.Drawing.Point(184, 33);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(151, 29);
            this.chkMangaCorta.TabIndex = 11;
            this.chkMangaCorta.Text = "Manga corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // chkCuelloMao
            // 
            this.chkCuelloMao.AutoSize = true;
            this.chkCuelloMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCuelloMao.Location = new System.Drawing.Point(334, 34);
            this.chkCuelloMao.Name = "chkCuelloMao";
            this.chkCuelloMao.Size = new System.Drawing.Size(139, 29);
            this.chkCuelloMao.TabIndex = 12;
            this.chkCuelloMao.Text = "Cuello mao";
            this.chkCuelloMao.UseVisualStyleBackColor = true;
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkChupin.Location = new System.Drawing.Point(184, 101);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(99, 29);
            this.chkChupin.TabIndex = 13;
            this.chkChupin.Text = "Chupín";
            this.chkChupin.UseVisualStyleBackColor = true;
            // 
            // numStock
            // 
            this.numStock.Enabled = false;
            this.numStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numStock.Location = new System.Drawing.Point(196, 24);
            this.numStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(71, 35);
            this.numStock.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stock disponible:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCamisa);
            this.groupBox1.Controls.Add(this.rdoPantalon);
            this.groupBox1.Controls.Add(this.chkChupin);
            this.groupBox1.Controls.Add(this.chkCuelloMao);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Location = new System.Drawing.Point(273, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numStock);
            this.groupBox2.Location = new System.Drawing.Point(532, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 79);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPremium);
            this.groupBox3.Controls.Add(this.rdoStandard);
            this.groupBox3.Location = new System.Drawing.Point(273, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 81);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad";
            // 
            // rdoPremium
            // 
            this.rdoPremium.AutoSize = true;
            this.rdoPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoPremium.Location = new System.Drawing.Point(129, 32);
            this.rdoPremium.Name = "rdoPremium";
            this.rdoPremium.Size = new System.Drawing.Size(114, 29);
            this.rdoPremium.TabIndex = 15;
            this.rdoPremium.TabStop = true;
            this.rdoPremium.Text = "Premium";
            this.rdoPremium.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoStandard.Location = new System.Drawing.Point(6, 34);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(117, 29);
            this.rdoStandard.TabIndex = 14;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numCantidad);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numPrecio);
            this.groupBox4.Location = new System.Drawing.Point(380, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 91);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio unidad y cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCantidad.Location = new System.Drawing.Point(256, 35);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(62, 35);
            this.numCantidad.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(146, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "$";
            // 
            // numPrecio
            // 
            this.numPrecio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numPrecio.Location = new System.Drawing.Point(36, 35);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(104, 35);
            this.numPrecio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(600, 712);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(370, 769);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Historial de cotizaciones";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCotizacion.Location = new System.Drawing.Point(636, 712);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(0, 31);
            this.lblCotizacion.TabIndex = 21;
            // 
            // Cotizador
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 1024);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCotizaciones);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Cotizador";
            this.Text = "Cotizador Express";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Muestra los datos iniciales en la vista
        public void MostrarDatos()
        {
            this.lblVendedor.Text = presenter.GetDatosVendedor();
            this.lblTienda.Text = presenter.GetNombreTienda();
            this.lblDireccion.Text = presenter.GetDireccionTienda();
        }

        //Comprueba los datos ingresados por el usuario, en caso de que no sean validos muestra un mensaje de error
        public bool DatosValidos()
        {
            string mensaje = "";
            if (!this.rdoCamisa.Checked && !this.rdoPantalon.Checked)
            {
                mensaje = "Debe seleccionar una camisa o pantalon";
            }
            if (!this.rdoStandard.Checked && !this.rdoPremium.Checked)
            {
                mensaje = "Debe seleccionar la calidad de la prenda";
            }
            if (this.numCantidad.Value <= 0 || this.numPrecio.Value <= 0 || this.numStock.Value <= 0)
            {
                mensaje = "Asegurese de que todos los valores sean mayor que 0";
            }
            if(this.numCantidad.Value > this.numStock.Value)
            {
                mensaje = "La cantidad de prendas no pueden superar al stock";
            }
            if (!string.IsNullOrEmpty(mensaje))
            {
                MostrarError(mensaje);
                return false;
            }

            return true;
        }

        //Muestra un mensaje de error al usuario
        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Form Closing",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
        }

        //Actualiza el historial de cotizaciones del vendedor
        public void ActualizarHistorial()
        {
            this.lstCotizaciones.Items.Clear();
            List<string> historial = presenter.GetHistorialCotizaciones();
            foreach(string item in historial)
            {
                this.lstCotizaciones.Items.Add(item);
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    string calidadPrenda = this.rdoPremium.Checked ? "premium" : "standard";
                    decimal precio = this.numPrecio.Value;
                    int cantidad = (int)this.numCantidad.Value;

                    if (this.rdoCamisa.Checked)
                    {
                        string mangaCamisa = this.chkMangaCorta.Checked ? "corta" : "comun";
                        string cuelloCamisa = this.chkCuelloMao.Checked ? "mao" : "comun";
                        this.lblCotizacion.Text = presenter.CotizarCamisa(cantidad, precio, cuelloCamisa, mangaCamisa, calidadPrenda).ToString();
                    }
                    if (this.rdoPantalon.Checked)
                    {
                        string tipoPantalon = this.chkChupin.Checked ? "chupin" : "comun";
                        this.lblCotizacion.Text = presenter.CotizarPantalon(cantidad, precio, tipoPantalon, calidadPrenda).ToString();
                    }
                    ActualizarHistorial();
                }
                catch(Exception ex)
                {
                    MostrarError(ex.Message);
                }
            }
        }

        private void rdoCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdoCamisa.Checked)
            {
                this.numStock.Value = presenter.GetStockCamisas();
            }
        }

        private void rdoPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoPantalon.Checked)
            {
                this.numStock.Value = presenter.GetStockPantalones();
            }
        }
    }
}