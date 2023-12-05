namespace BCA_SetA_FoodDishManagement
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
            this.lblDishId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIsLowFat = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDishId
            // 
            this.lblDishId.AutoSize = true;
            this.lblDishId.Location = new System.Drawing.Point(84, 35);
            this.lblDishId.Name = "lblDishId";
            this.lblDishId.Size = new System.Drawing.Size(62, 19);
            this.lblDishId.TabIndex = 0;
            this.lblDishId.Text = "Dish Id :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(97, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 19);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price :";
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(76, 115);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(70, 19);
            this.lblCal.TabIndex = 2;
            this.lblCal.Text = "Calories :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Dish Name :";
            // 
            // lblIsLowFat
            // 
            this.lblIsLowFat.AutoSize = true;
            this.lblIsLowFat.Location = new System.Drawing.Point(31, 221);
            this.lblIsLowFat.Name = "lblIsLowFat";
            this.lblIsLowFat.Size = new System.Drawing.Size(115, 19);
            this.lblIsLowFat.TabIndex = 4;
            this.lblIsLowFat.Text = "Is Low Fat Dish :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(175, 27);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(138, 27);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId.Leave += new System.EventHandler(this.txt_nonNumericValueEntered);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(175, 107);
            this.txtCal.Name = "txtCal";
            this.txtCal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCal.Size = new System.Drawing.Size(138, 27);
            this.txtCal.TabIndex = 7;
            this.txtCal.Text = "0";
            this.txtCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCal.Leave += new System.EventHandler(this.txt_nonNumericValueEntered);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(175, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(138, 27);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.Leave += new System.EventHandler(this.txt_nonNumericValueEntered);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Location = new System.Drawing.Point(175, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 54);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(89, 24);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(45, 23);
            this.rbNo.TabIndex = 1;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(6, 24);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(49, 23);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "All",
            "Fat Dish",
            "Not Fat Dish"});
            this.cmbType.Location = new System.Drawing.Point(598, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(149, 27);
            this.cmbType.TabIndex = 10;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Type :";
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(410, 65);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(423, 313);
            this.dgDisplay.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(49, 295);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 43);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Clicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(175, 295);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 43);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 415);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIsLowFat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDishId);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Food Dish Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDishId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIsLowFat;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
    }
}

