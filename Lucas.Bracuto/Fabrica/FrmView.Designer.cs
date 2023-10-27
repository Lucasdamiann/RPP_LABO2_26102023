namespace FabricaAutomoviles
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            btnFabricar = new Button();
            lstVehiculos = new ListBox();
            lblTipoVechiculo = new Label();
            cmbVehiculos = new ComboBox();
            pcbFabrica = new PictureBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(702, 217);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(131, 57);
            btnFabricar.TabIndex = 0;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(22, 33);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(558, 394);
            lstVehiculos.TabIndex = 1;
            lstVehiculos.SelectedIndexChanged += lstVehiculos_SelectedIndexChanged;
            // 
            // lblTipoVechiculo
            // 
            lblTipoVechiculo.AutoSize = true;
            lblTipoVechiculo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoVechiculo.Location = new Point(682, 27);
            lblTipoVechiculo.Name = "lblTipoVechiculo";
            lblTipoVechiculo.Size = new Size(197, 32);
            lblTipoVechiculo.TabIndex = 2;
            lblTipoVechiculo.Text = "Tipo de vehiculo:";
            // 
            // cmbVehiculos
            // 
            cmbVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehiculos.FormattingEnabled = true;
            cmbVehiculos.Location = new Point(702, 72);
            cmbVehiculos.Name = "cmbVehiculos";
            cmbVehiculos.Size = new Size(131, 23);
            cmbVehiculos.TabIndex = 3;
            cmbVehiculos.SelectedIndexChanged += cmbVehiculos_SelectedIndexChanged;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(702, 127);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(131, 64);
            pcbFabrica.TabIndex = 4;
            pcbFabrica.TabStop = false;
            pcbFabrica.Click += pcbFabrica_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(702, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(btnEliminar);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbVehiculos);
            Controls.Add(lblTipoVechiculo);
            Controls.Add(lstVehiculos);
            Controls.Add(btnFabricar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFabricar;
        private ListBox lstVehiculos;
        private Label lblTipoVechiculo;
        private ComboBox cmbVehiculos;
        private PictureBox pcbFabrica;
        private Button btnEliminar;
    }
}