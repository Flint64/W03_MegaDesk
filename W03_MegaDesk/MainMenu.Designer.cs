namespace W03_MegaDesk {
    partial class MainMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_newQuote = new System.Windows.Forms.Button();
            this.btn_viewQuotes = new System.Windows.Forms.Button();
            this.btn_searchQuotes = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.img_desk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_desk)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newQuote
            // 
            this.btn_newQuote.Location = new System.Drawing.Point(12, 12);
            this.btn_newQuote.Name = "btn_newQuote";
            this.btn_newQuote.Size = new System.Drawing.Size(134, 45);
            this.btn_newQuote.TabIndex = 0;
            this.btn_newQuote.Text = "Add New Quote";
            this.btn_newQuote.UseVisualStyleBackColor = true;
            this.btn_newQuote.Click += new System.EventHandler(this.btn_newQuote_Click);
            // 
            // btn_viewQuotes
            // 
            this.btn_viewQuotes.Location = new System.Drawing.Point(12, 63);
            this.btn_viewQuotes.Name = "btn_viewQuotes";
            this.btn_viewQuotes.Size = new System.Drawing.Size(134, 45);
            this.btn_viewQuotes.TabIndex = 1;
            this.btn_viewQuotes.Text = "View Quotes";
            this.btn_viewQuotes.UseVisualStyleBackColor = true;
            this.btn_viewQuotes.Click += new System.EventHandler(this.btn_viewQuotes_Click);
            // 
            // btn_searchQuotes
            // 
            this.btn_searchQuotes.Location = new System.Drawing.Point(12, 114);
            this.btn_searchQuotes.Name = "btn_searchQuotes";
            this.btn_searchQuotes.Size = new System.Drawing.Size(134, 45);
            this.btn_searchQuotes.TabIndex = 2;
            this.btn_searchQuotes.Text = "Search Quotes";
            this.btn_searchQuotes.UseVisualStyleBackColor = true;
            this.btn_searchQuotes.Click += new System.EventHandler(this.btn_searchQuotes_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 165);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 45);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // img_desk
            // 
            this.img_desk.Image = ((System.Drawing.Image)(resources.GetObject("img_desk.Image")));
            this.img_desk.Location = new System.Drawing.Point(172, 15);
            this.img_desk.Name = "img_desk";
            this.img_desk.Size = new System.Drawing.Size(303, 195);
            this.img_desk.TabIndex = 4;
            this.img_desk.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 227);
            this.Controls.Add(this.img_desk);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_searchQuotes);
            this.Controls.Add(this.btn_viewQuotes);
            this.Controls.Add(this.btn_newQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.img_desk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newQuote;
        private System.Windows.Forms.Button btn_viewQuotes;
        private System.Windows.Forms.Button btn_searchQuotes;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox img_desk;
    }
}

