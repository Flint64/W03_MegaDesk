namespace W03_MegaDesk {
    partial class AddQuote {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_customer_name = new System.Windows.Forms.Label();
            this.cmbo_drawers = new System.Windows.Forms.ComboBox();
            this.lbl_drawers = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.num_depth = new System.Windows.Forms.NumericUpDown();
            this.lbl_surfaceMaterial = new System.Windows.Forms.Label();
            this.cmbo_surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.lbl_rushOptions = new System.Windows.Forms.Label();
            this.cmbo_rushOptions = new System.Windows.Forms.ComboBox();
            this.grp_size = new System.Windows.Forms.GroupBox();
            this.grp_features = new System.Windows.Forms.GroupBox();
            this.grp_shipping = new System.Windows.Forms.GroupBox();
            this.btn_getQuote = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_depth)).BeginInit();
            this.grp_size.SuspendLayout();
            this.grp_features.SuspendLayout();
            this.grp_shipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(129, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_customer_name
            // 
            this.lbl_customer_name.AutoSize = true;
            this.lbl_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_name.Location = new System.Drawing.Point(126, 9);
            this.lbl_customer_name.Name = "lbl_customer_name";
            this.lbl_customer_name.Size = new System.Drawing.Size(109, 17);
            this.lbl_customer_name.TabIndex = 1;
            this.lbl_customer_name.Text = "Customer Name";
            // 
            // cmbo_drawers
            // 
            this.cmbo_drawers.FormattingEnabled = true;
            this.cmbo_drawers.Location = new System.Drawing.Point(24, 111);
            this.cmbo_drawers.Name = "cmbo_drawers";
            this.cmbo_drawers.Size = new System.Drawing.Size(121, 24);
            this.cmbo_drawers.TabIndex = 2;
            // 
            // lbl_drawers
            // 
            this.lbl_drawers.AutoSize = true;
            this.lbl_drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drawers.Location = new System.Drawing.Point(21, 91);
            this.lbl_drawers.Name = "lbl_drawers";
            this.lbl_drawers.Size = new System.Drawing.Size(88, 17);
            this.lbl_drawers.TabIndex = 3;
            this.lbl_drawers.Text = "# of Drawers";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(43, 31);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(44, 17);
            this.lbl_width.TabIndex = 5;
            this.lbl_width.Text = "Width";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depth.Location = new System.Drawing.Point(43, 90);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(46, 17);
            this.lbl_depth.TabIndex = 6;
            this.lbl_depth.Text = "Depth";
            // 
            // num_width
            // 
            this.num_width.Location = new System.Drawing.Point(46, 52);
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(49, 23);
            this.num_width.TabIndex = 7;
            this.num_width.ValueChanged += new System.EventHandler(this.num_width_ValueChanged);
            // 
            // num_depth
            // 
            this.num_depth.Location = new System.Drawing.Point(46, 111);
            this.num_depth.Name = "num_depth";
            this.num_depth.Size = new System.Drawing.Size(49, 23);
            this.num_depth.TabIndex = 8;
            this.num_depth.ValueChanged += new System.EventHandler(this.num_depth_ValueChanged);
            // 
            // lbl_surfaceMaterial
            // 
            this.lbl_surfaceMaterial.AutoSize = true;
            this.lbl_surfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surfaceMaterial.Location = new System.Drawing.Point(21, 32);
            this.lbl_surfaceMaterial.Name = "lbl_surfaceMaterial";
            this.lbl_surfaceMaterial.Size = new System.Drawing.Size(111, 17);
            this.lbl_surfaceMaterial.TabIndex = 9;
            this.lbl_surfaceMaterial.Text = "Surface Material";
            // 
            // cmbo_surfaceMaterial
            // 
            this.cmbo_surfaceMaterial.FormattingEnabled = true;
            this.cmbo_surfaceMaterial.Location = new System.Drawing.Point(24, 52);
            this.cmbo_surfaceMaterial.Name = "cmbo_surfaceMaterial";
            this.cmbo_surfaceMaterial.Size = new System.Drawing.Size(121, 24);
            this.cmbo_surfaceMaterial.TabIndex = 10;
            // 
            // lbl_rushOptions
            // 
            this.lbl_rushOptions.AutoSize = true;
            this.lbl_rushOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rushOptions.Location = new System.Drawing.Point(112, 19);
            this.lbl_rushOptions.Name = "lbl_rushOptions";
            this.lbl_rushOptions.Size = new System.Drawing.Size(94, 17);
            this.lbl_rushOptions.TabIndex = 11;
            this.lbl_rushOptions.Text = "Rush Options";
            // 
            // cmbo_rushOptions
            // 
            this.cmbo_rushOptions.FormattingEnabled = true;
            this.cmbo_rushOptions.Location = new System.Drawing.Point(101, 39);
            this.cmbo_rushOptions.Name = "cmbo_rushOptions";
            this.cmbo_rushOptions.Size = new System.Drawing.Size(121, 24);
            this.cmbo_rushOptions.TabIndex = 12;
            // 
            // grp_size
            // 
            this.grp_size.BackColor = System.Drawing.SystemColors.Control;
            this.grp_size.Controls.Add(this.lbl_width);
            this.grp_size.Controls.Add(this.lbl_depth);
            this.grp_size.Controls.Add(this.num_depth);
            this.grp_size.Controls.Add(this.num_width);
            this.grp_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_size.Location = new System.Drawing.Point(57, 55);
            this.grp_size.Name = "grp_size";
            this.grp_size.Size = new System.Drawing.Size(142, 158);
            this.grp_size.TabIndex = 13;
            this.grp_size.TabStop = false;
            this.grp_size.Text = "Desk Size";
            // 
            // grp_features
            // 
            this.grp_features.BackColor = System.Drawing.SystemColors.Control;
            this.grp_features.Controls.Add(this.lbl_surfaceMaterial);
            this.grp_features.Controls.Add(this.cmbo_drawers);
            this.grp_features.Controls.Add(this.lbl_drawers);
            this.grp_features.Controls.Add(this.cmbo_surfaceMaterial);
            this.grp_features.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_features.Location = new System.Drawing.Point(217, 55);
            this.grp_features.Name = "grp_features";
            this.grp_features.Size = new System.Drawing.Size(161, 158);
            this.grp_features.TabIndex = 14;
            this.grp_features.TabStop = false;
            this.grp_features.Text = "Features";
            // 
            // grp_shipping
            // 
            this.grp_shipping.BackColor = System.Drawing.SystemColors.Control;
            this.grp_shipping.Controls.Add(this.lbl_rushOptions);
            this.grp_shipping.Controls.Add(this.cmbo_rushOptions);
            this.grp_shipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_shipping.Location = new System.Drawing.Point(57, 219);
            this.grp_shipping.Name = "grp_shipping";
            this.grp_shipping.Size = new System.Drawing.Size(321, 79);
            this.grp_shipping.TabIndex = 15;
            this.grp_shipping.TabStop = false;
            this.grp_shipping.Text = "Shipping";
            // 
            // btn_getQuote
            // 
            this.btn_getQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getQuote.Location = new System.Drawing.Point(80, 316);
            this.btn_getQuote.Name = "btn_getQuote";
            this.btn_getQuote.Size = new System.Drawing.Size(108, 34);
            this.btn_getQuote.TabIndex = 16;
            this.btn_getQuote.Text = "Get Quote";
            this.btn_getQuote.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(217, 316);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 34);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 373);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_getQuote);
            this.Controls.Add(this.grp_shipping);
            this.Controls.Add(this.grp_features);
            this.Controls.Add(this.grp_size);
            this.Controls.Add(this.lbl_customer_name);
            this.Controls.Add(this.txt_name);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_depth)).EndInit();
            this.grp_size.ResumeLayout(false);
            this.grp_size.PerformLayout();
            this.grp_features.ResumeLayout(false);
            this.grp_features.PerformLayout();
            this.grp_shipping.ResumeLayout(false);
            this.grp_shipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_customer_name;
        private System.Windows.Forms.ComboBox cmbo_drawers;
        private System.Windows.Forms.Label lbl_drawers;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_depth;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.NumericUpDown num_depth;
        private System.Windows.Forms.Label lbl_surfaceMaterial;
        private System.Windows.Forms.ComboBox cmbo_surfaceMaterial;
        private System.Windows.Forms.Label lbl_rushOptions;
        private System.Windows.Forms.ComboBox cmbo_rushOptions;
        private System.Windows.Forms.GroupBox grp_size;
        private System.Windows.Forms.GroupBox grp_features;
        private System.Windows.Forms.GroupBox grp_shipping;
        private System.Windows.Forms.Button btn_getQuote;
        private System.Windows.Forms.Button btn_cancel;
    }
}