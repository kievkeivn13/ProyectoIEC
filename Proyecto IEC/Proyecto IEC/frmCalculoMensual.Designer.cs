﻿
namespace Proyecto_IEC
{
	partial class frmCalculoMensual
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoMensual));
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExportar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.txtfechainicio = new System.Windows.Forms.TextBox();
			this.txtfechafin = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 51);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(1295, 387);
			this.dgvVistaPrevia.TabIndex = 104;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 107;
			this.label1.Text = "Periodo del";
			// 
			// btnExportar
			// 
			this.btnExportar.BackColor = System.Drawing.Color.Transparent;
			this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
			this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExportar.FlatAppearance.BorderSize = 0;
			this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportar.Location = new System.Drawing.Point(1257, -2);
			this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(50, 50);
			this.btnExportar.TabIndex = 109;
			this.btnExportar.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(523, -2);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 50);
			this.button1.TabIndex = 110;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Location = new System.Drawing.Point(77, 15);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(200, 20);
			this.dtpInicio.TabIndex = 111;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(283, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 112;
			this.label2.Text = "al";
			// 
			// dtpFin
			// 
			this.dtpFin.Location = new System.Drawing.Point(304, 15);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(200, 20);
			this.dtpFin.TabIndex = 113;
			this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
			// 
			// txtfechainicio
			// 
			this.txtfechainicio.Location = new System.Drawing.Point(601, 15);
			this.txtfechainicio.Name = "txtfechainicio";
			this.txtfechainicio.Size = new System.Drawing.Size(100, 20);
			this.txtfechainicio.TabIndex = 114;
			this.txtfechainicio.Visible = false;
			// 
			// txtfechafin
			// 
			this.txtfechafin.Location = new System.Drawing.Point(707, 14);
			this.txtfechafin.Name = "txtfechafin";
			this.txtfechafin.Size = new System.Drawing.Size(100, 20);
			this.txtfechafin.TabIndex = 115;
			this.txtfechafin.Visible = false;
			// 
			// frmCalculoMensual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1319, 450);
			this.Controls.Add(this.txtfechafin);
			this.Controls.Add(this.txtfechainicio);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCalculoMensual";
			this.Text = "Cálculo Mensual";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.TextBox txtfechainicio;
		private System.Windows.Forms.TextBox txtfechafin;
	}
}