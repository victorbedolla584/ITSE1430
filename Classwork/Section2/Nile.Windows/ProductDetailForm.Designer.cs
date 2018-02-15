﻿namespace Nile.Windows
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this._name = new System.Windows.Forms.TextBox();
            this._description = new System.Windows.Forms.TextBox();
            this._price = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._discontinued = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(89, 37);
            this._name.Multiline = true;
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(144, 20);
            this._name.TabIndex = 0;
            this._name.TextChanged += new System.EventHandler(this._checkIsDiscontinued_TextChanged);
            // 
            // _description
            // 
            this._description.Location = new System.Drawing.Point(89, 64);
            this._description.Multiline = true;
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(144, 47);
            this._description.TabIndex = 1;
            // 
            // _price
            // 
            this._price.Location = new System.Drawing.Point(89, 117);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(144, 20);
            this._price.TabIndex = 2;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(109, 168);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 3;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(191, 168);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 4;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // _discontinued
            // 
            this._discontinued.AutoSize = true;
            this._discontinued.Location = new System.Drawing.Point(109, 145);
            this._discontinued.Name = "_discontinued";
            this._discontinued.Size = new System.Drawing.Size(88, 17);
            this._discontinued.TabIndex = 5;
            this._discontinued.Text = "Discontinued";
            this._discontinued.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._discontinued);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._price);
            this.Controls.Add(this._description);
            this.Controls.Add(this._name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _description;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.CheckBox _discontinued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}