﻿
namespace Presentacion_GUI
{
    partial class FrmRegistarTractor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridRegistro = new System.Windows.Forms.DataGridView();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.PnlRegistarTactor = new System.Windows.Forms.Panel();
            this.dateTimeRenta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnrRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).BeginInit();
            this.PnlRegistarTactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "REGISTRAR TRACTOR ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Placa";
            // 
            // dataGridRegistro
            // 
            this.dataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistro.Location = new System.Drawing.Point(51, 119);
            this.dataGridRegistro.Name = "dataGridRegistro";
            this.dataGridRegistro.RowTemplate.Height = 25;
            this.dataGridRegistro.Size = new System.Drawing.Size(382, 216);
            this.dataGridRegistro.TabIndex = 21;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPlaca.Location = new System.Drawing.Point(625, 115);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(85, 22);
            this.TxtPlaca.TabIndex = 25;
            // 
            // PnlRegistarTactor
            // 
            this.PnlRegistarTactor.AllowDrop = true;
            this.PnlRegistarTactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlRegistarTactor.Controls.Add(this.BtnrRegistrar);
            this.PnlRegistarTactor.Controls.Add(this.label4);
            this.PnlRegistarTactor.Controls.Add(this.label2);
            this.PnlRegistarTactor.Controls.Add(this.dateTimeDevolucion);
            this.PnlRegistarTactor.Controls.Add(this.dateTimeRenta);
            this.PnlRegistarTactor.Controls.Add(this.TxtPlaca);
            this.PnlRegistarTactor.Controls.Add(this.dataGridRegistro);
            this.PnlRegistarTactor.Controls.Add(this.label3);
            this.PnlRegistarTactor.Controls.Add(this.label1);
            this.PnlRegistarTactor.Location = new System.Drawing.Point(0, 0);
            this.PnlRegistarTactor.Name = "PnlRegistarTactor";
            this.PnlRegistarTactor.Size = new System.Drawing.Size(777, 490);
            this.PnlRegistarTactor.TabIndex = 2;
            // 
            // dateTimeRenta
            // 
            this.dateTimeRenta.Location = new System.Drawing.Point(520, 197);
            this.dateTimeRenta.Name = "dateTimeRenta";
            this.dateTimeRenta.Size = new System.Drawing.Size(227, 23);
            this.dateTimeRenta.TabIndex = 26;
            this.dateTimeRenta.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            // 
            // dateTimeDevolucion
            // 
            this.dateTimeDevolucion.Location = new System.Drawing.Point(520, 276);
            this.dateTimeDevolucion.Name = "dateTimeDevolucion";
            this.dateTimeDevolucion.Size = new System.Drawing.Size(227, 23);
            this.dateTimeDevolucion.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(568, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha de Renta";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(558, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha de Devolucion";
            // 
            // BtnrRegistrar
            // 
            this.BtnrRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnrRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnrRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnrRegistrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnrRegistrar.Image = global::Presentacion_GUI.Properties.Resources.verificar;
            this.BtnrRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnrRegistrar.Location = new System.Drawing.Point(598, 439);
            this.BtnrRegistrar.Name = "BtnrRegistrar";
            this.BtnrRegistrar.Size = new System.Drawing.Size(167, 39);
            this.BtnrRegistrar.TabIndex = 30;
            this.BtnrRegistrar.Text = "    REGISTRAR";
            this.BtnrRegistrar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistarTractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlRegistarTactor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistarTractor";
            this.Text = "FrmRegistarTractor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).EndInit();
            this.PnlRegistarTactor.ResumeLayout(false);
            this.PnlRegistarTactor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridRegistro;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Panel PnlRegistarTactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimeRenta;
        private System.Windows.Forms.Button BtnrRegistrar;
    }
}