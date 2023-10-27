namespace Fabrica
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
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(702, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 62);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(702, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 76);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(cmbVehiculos);
            Controls.Add(lblTipoVechiculo);
            Controls.Add(lstVehiculos);
            Controls.Add(btnFabricar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFabricar;
        private ListBox lstVehiculos;
        private Label lblTipoVechiculo;
        private ComboBox cmbVehiculos;
        private Button btnEliminar;
        private PictureBox pictureBox1;
    }
}