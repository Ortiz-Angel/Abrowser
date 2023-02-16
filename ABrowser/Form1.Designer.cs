namespace ABrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnBack;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbFav = new System.Windows.Forms.ComboBox();
            this.btnWard = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.SystemColors.Menu;
            btnBack.Image = global::ABrowser.Properties.Resources.icons8_left_arrow_161;
            btnBack.Location = new System.Drawing.Point(12, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(32, 28);
            btnBack.TabIndex = 0;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.cmbFav);
            this.panel1.Controls.Add(this.btnWard);
            this.panel1.Controls.Add(this.btnFav);
            this.panel1.Controls.Add(this.btnIr);
            this.panel1.Controls.Add(btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Image = global::ABrowser.Properties.Resources.icons8_country_house_16;
            this.btnHome.Location = new System.Drawing.Point(188, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 34);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Image = global::ABrowser.Properties.Resources.icons8_repeat_16;
            this.btnRefresh.Location = new System.Drawing.Point(113, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 33);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(231, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(398, 26);
            this.txtURL.TabIndex = 5;
            // 
            // cmbFav
            // 
            this.cmbFav.FormattingEnabled = true;
            this.cmbFav.Location = new System.Drawing.Point(751, 6);
            this.cmbFav.Name = "cmbFav";
            this.cmbFav.Size = new System.Drawing.Size(232, 28);
            this.cmbFav.TabIndex = 4;
            this.cmbFav.SelectedIndexChanged += new System.EventHandler(this.cmbFav_SelectedIndexChanged);
            // 
            // btnWard
            // 
            this.btnWard.BackColor = System.Drawing.SystemColors.Menu;
            this.btnWard.Image = global::ABrowser.Properties.Resources.icons8_right_arrow_16;
            this.btnWard.Location = new System.Drawing.Point(59, 5);
            this.btnWard.Name = "btnWard";
            this.btnWard.Size = new System.Drawing.Size(38, 28);
            this.btnWard.TabIndex = 3;
            this.btnWard.UseVisualStyleBackColor = false;
            this.btnWard.Click += new System.EventHandler(this.btnWard_Click);
            // 
            // btnFav
            // 
            this.btnFav.AutoSize = true;
            this.btnFav.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFav.Image = global::ABrowser.Properties.Resources.icons8_favorite_16;
            this.btnFav.Location = new System.Drawing.Point(714, 5);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(31, 29);
            this.btnFav.TabIndex = 2;
            this.btnFav.TabStop = false;
            this.btnFav.UseVisualStyleBackColor = false;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // btnIr
            // 
            this.btnIr.BackColor = System.Drawing.SystemColors.Menu;
            this.btnIr.Image = global::ABrowser.Properties.Resources.icons8_magnifying_glass_kiranshastry_lineal_16;
            this.btnIr.Location = new System.Drawing.Point(635, 6);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(29, 29);
            this.btnIr.TabIndex = 1;
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1064, 563);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Abrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cmbFav;
        private System.Windows.Forms.Button btnWard;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Button btnIr;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

