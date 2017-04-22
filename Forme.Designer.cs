namespace Navigateur
{
    partial class Forme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forme));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.O1 = new System.Windows.Forms.TabPage();
            this.O2 = new System.Windows.Forms.TabPage();
            this.O3 = new System.Windows.Forms.TabPage();
            this.O4 = new System.Windows.Forms.TabPage();
            this.W1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.O1.SuspendLayout();
            this.O2.SuspendLayout();
            this.O3.SuspendLayout();
            this.O4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.O1);
            this.tabControl1.Controls.Add(this.O2);
            this.tabControl1.Controls.Add(this.O3);
            this.tabControl1.Controls.Add(this.O4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // O1
            // 
            this.O1.Controls.Add(this.W1);
            this.O1.Location = new System.Drawing.Point(4, 22);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(926, 235);
            this.O1.TabIndex = 0;
            this.O1.Text = "Onglet 1";
            this.O1.UseVisualStyleBackColor = true;
            // 
            // O2
            // 
            this.O2.Controls.Add(this.webBrowser2);
            this.O2.Location = new System.Drawing.Point(4, 22);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(926, 235);
            this.O2.TabIndex = 1;
            this.O2.Text = "Onglet 2";
            this.O2.UseVisualStyleBackColor = true;
            // 
            // O3
            // 
            this.O3.Controls.Add(this.webBrowser3);
            this.O3.Location = new System.Drawing.Point(4, 22);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(926, 235);
            this.O3.TabIndex = 2;
            this.O3.Text = "Onglet 3";
            this.O3.UseVisualStyleBackColor = true;
            // 
            // O4
            // 
            this.O4.Controls.Add(this.webBrowser4);
            this.O4.Location = new System.Drawing.Point(4, 22);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(926, 235);
            this.O4.TabIndex = 3;
            this.O4.Text = "Onglet 4";
            this.O4.UseVisualStyleBackColor = true;
            // 
            // W1
            // 
            this.W1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.W1.Location = new System.Drawing.Point(0, 0);
            this.W1.MinimumSize = new System.Drawing.Size(20, 20);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(926, 235);
            this.W1.TabIndex = 0;
            this.W1.Url = new System.Uri("https://www.google.ca/?gfe_rd=cr&ei=a3j7WIj6MPTj8AffgKjoCw", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(926, 235);
            this.webBrowser2.TabIndex = 0;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(926, 235);
            this.webBrowser3.TabIndex = 0;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(926, 235);
            this.webBrowser4.TabIndex = 0;
            // 
            // Forme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 261);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigateur";
            this.tabControl1.ResumeLayout(false);
            this.O1.ResumeLayout(false);
            this.O2.ResumeLayout(false);
            this.O3.ResumeLayout(false);
            this.O4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage O1;
        private System.Windows.Forms.WebBrowser W1;
        private System.Windows.Forms.TabPage O2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TabPage O3;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.TabPage O4;
        private System.Windows.Forms.WebBrowser webBrowser4;
    }
}

