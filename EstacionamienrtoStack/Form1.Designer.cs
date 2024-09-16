namespace EstacionamienrtoStack
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
            txtPlacas = new TextBox();
            txtPropietario = new TextBox();
            txtColor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnPush = new Button();
            btbPOP = new Button();
            dgvEstacionamiento = new DataGridView();
            btnPeek = new Button();
            lbCount = new Label();
            txtCount = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstacionamiento).BeginInit();
            SuspendLayout();
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(146, 52);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(150, 31);
            txtPlacas.TabIndex = 0;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(146, 102);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(150, 31);
            txtPropietario.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(146, 152);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 31);
            txtColor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 3;
            label1.Text = "Placas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 158);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 4;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 5;
            label3.Text = "Propietario";
            // 
            // btnPush
            // 
            btnPush.Location = new Point(361, 52);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(112, 98);
            btnPush.TabIndex = 6;
            btnPush.Text = "PUSH - Insertar";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btbPOP
            // 
            btbPOP.Location = new Point(495, 52);
            btbPOP.Name = "btbPOP";
            btbPOP.Size = new Size(112, 98);
            btbPOP.TabIndex = 7;
            btbPOP.Text = "POP - Eliminar";
            btbPOP.UseVisualStyleBackColor = true;
            btbPOP.Click += btbPOP_Click;
            // 
            // dgvEstacionamiento
            // 
            dgvEstacionamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstacionamiento.Location = new Point(41, 262);
            dgvEstacionamiento.Name = "dgvEstacionamiento";
            dgvEstacionamiento.RowHeadersWidth = 62;
            dgvEstacionamiento.Size = new Size(699, 225);
            dgvEstacionamiento.TabIndex = 8;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(628, 51);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(112, 99);
            btnPeek.TabIndex = 9;
            btnPeek.Text = "PEEK - Mostrar Ultimo";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Location = new Point(624, 187);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(60, 25);
            lbCount.TabIndex = 10;
            lbCount.Text = "Count";
            // 
            // txtCount
            // 
            txtCount.BackColor = SystemColors.ControlLightLight;
            txtCount.ForeColor = Color.Red;
            txtCount.Location = new Point(690, 181);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(50, 31);
            txtCount.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 222);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 12;
            label4.Text = "Autos Apilados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(label4);
            Controls.Add(txtCount);
            Controls.Add(lbCount);
            Controls.Add(btnPeek);
            Controls.Add(dgvEstacionamiento);
            Controls.Add(btbPOP);
            Controls.Add(btnPush);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtColor);
            Controls.Add(txtPropietario);
            Controls.Add(txtPlacas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstacionamiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlacas;
        private TextBox txtPropietario;
        private TextBox txtColor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPush;
        private Button btbPOP;
        private DataGridView dgvEstacionamiento;
        private Button btnPeek;
        private Label lbCount;
        private TextBox txtCount;
        private Label label4;
    }
}
