﻿
namespace GrupoE_Protitipos
{
    partial class FormConsultarOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarOrdenes));
            labelNroOrden = new Label();
            labelDNI = new Label();
            labelEstado = new Label();
            txtNroOrden = new TextBox();
            cmbEstado = new ComboBox();
            listViewEstado = new ListView();
            NroOrdenCol = new ColumnHeader();
            CuitCol = new ColumnHeader();
            EstadoCol = new ColumnHeader();
            FechaCol = new ColumnHeader();
            groupBoxEdicion = new GroupBox();
            label1 = new Label();
            clienteBox = new ComboBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            VolverBoton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            groupBoxEdicion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNroOrden
            // 
            labelNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNroOrden.AutoSize = true;
            labelNroOrden.Location = new Point(6, 41);
            labelNroOrden.Name = "labelNroOrden";
            labelNroOrden.Size = new Size(73, 15);
            labelNroOrden.TabIndex = 0;
            labelNroOrden.Text = "N° de Orden";
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(314, 41);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(44, 15);
            labelDNI.TabIndex = 1;
            labelDNI.Text = "Cliente";
            // 
            // labelEstado
            // 
            labelEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(554, 41);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 2;
            labelEstado.Text = "Estado";
            labelEstado.Click += labelEstado_Click;
            // 
            // txtNroOrden
            // 
            txtNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNroOrden.BorderStyle = BorderStyle.FixedSingle;
            txtNroOrden.Location = new Point(85, 39);
            txtNroOrden.Name = "txtNroOrden";
            txtNroOrden.Size = new Size(183, 23);
            txtNroOrden.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(596, 38);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(179, 23);
            cmbEstado.TabIndex = 5;
            // 
            // listViewEstado
            // 
            listViewEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEstado.Columns.AddRange(new ColumnHeader[] { NroOrdenCol, CuitCol, EstadoCol, FechaCol });
            listViewEstado.FullRowSelect = true;
            listViewEstado.Location = new Point(14, 178);
            listViewEstado.Name = "listViewEstado";
            listViewEstado.Size = new Size(794, 204);
            listViewEstado.TabIndex = 6;
            listViewEstado.UseCompatibleStateImageBehavior = false;
            listViewEstado.View = View.Details;
            // 
            // NroOrdenCol
            // 
            NroOrdenCol.Text = "Nro de Orden";
            NroOrdenCol.Width = 171;
            // 
            // CuitCol
            // 
            CuitCol.Text = "Cuit Cliente";
            CuitCol.TextAlign = HorizontalAlignment.Center;
            CuitCol.Width = 200;
            // 
            // EstadoCol
            // 
            EstadoCol.Text = "Estado";
            EstadoCol.TextAlign = HorizontalAlignment.Center;
            EstadoCol.Width = 200;
            // 
            // FechaCol
            // 
            FechaCol.Text = "Fecha";
            FechaCol.TextAlign = HorizontalAlignment.Center;
            FechaCol.Width = 200;
            // 
            // groupBoxEdicion
            // 
            groupBoxEdicion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEdicion.Controls.Add(label1);
            groupBoxEdicion.Controls.Add(clienteBox);
            groupBoxEdicion.Controls.Add(labelNroOrden);
            groupBoxEdicion.Controls.Add(cmbEstado);
            groupBoxEdicion.Controls.Add(txtNroOrden);
            groupBoxEdicion.Controls.Add(labelEstado);
            groupBoxEdicion.Controls.Add(labelDNI);
            groupBoxEdicion.Location = new Point(14, 40);
            groupBoxEdicion.Name = "groupBoxEdicion";
            groupBoxEdicion.Size = new Size(792, 140);
            groupBoxEdicion.TabIndex = 7;
            groupBoxEdicion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 11;
            label1.Text = "Consultar Estado de Ordenes";
            // 
            // clienteBox
            // 
            clienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteBox.FormattingEnabled = true;
            clienteBox.Location = new Point(364, 39);
            clienteBox.Name = "clienteBox";
            clienteBox.Size = new Size(141, 23);
            clienteBox.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(161, 32, 89);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(680, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(161, 32, 89);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(554, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // VolverBoton
            // 
            VolverBoton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VolverBoton.BackColor = Color.FromArgb(161, 32, 89);
            VolverBoton.ForeColor = SystemColors.ButtonHighlight;
            VolverBoton.Location = new Point(690, 387);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(118, 29);
            VolverBoton.TabIndex = 10;
            VolverBoton.Text = "Volver al menu";
            VolverBoton.UseVisualStyleBackColor = false;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 39);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(250, 11);
            label9.Name = "label9";
            label9.Size = new Size(261, 25);
            label9.TabIndex = 23;
            label9.Text = "Consultar Estado de Ordenes ";
            // 
            // FormConsultarOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(818, 418);
            Controls.Add(panel1);
            Controls.Add(VolverBoton);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(listViewEstado);
            Controls.Add(groupBoxEdicion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultarOrdenes";
            Text = "Consultar Estado de Ordenes";
            Load += ConsultarOrdenes_Load;
            groupBoxEdicion.ResumeLayout(false);
            groupBoxEdicion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private Label labelNroOrden;
        private Label labelDNI;
        private Label labelEstado;
        private TextBox txtNroOrden;
        private ComboBox cmbEstado;
        private ListView listViewEstado;
        private ColumnHeader NroOrdenCol;
        private ColumnHeader CuitCol;
        private ColumnHeader EstadoCol;
        private ColumnHeader FechaCol;
        private GroupBox groupBoxEdicion;
        private Button btnLimpiar;
        private Button btnBuscar;
        private ComboBox clienteBox;
        private Label label1;
        private Button VolverBoton;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
    }
}