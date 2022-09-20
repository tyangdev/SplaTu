namespace SplaTU
{
    partial class SplaTU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplaTU));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbOutput2 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SchineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreviewImg = new System.Windows.Forms.Button();
            this.btnRunTeensy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SplaTU.Properties.Resources.tile_P_2;
            this.groupBox1.Controls.Add(this.pbInput);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pbInput
            // 
            resources.ApplyResources(this.pbInput, "pbInput");
            this.pbInput.Name = "pbInput";
            this.pbInput.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::SplaTU.Properties.Resources.tile_P;
            this.groupBox2.Controls.Add(this.pbOutput2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // pbOutput2
            // 
            resources.ApplyResources(this.pbOutput2, "pbOutput2");
            this.pbOutput2.Name = "pbOutput2";
            this.pbOutput2.TabStop = false;
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.Name = "txtPath";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.SchineseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // SchineseToolStripMenuItem
            // 
            this.SchineseToolStripMenuItem.Name = "SchineseToolStripMenuItem";
            resources.ApplyResources(this.SchineseToolStripMenuItem, "SchineseToolStripMenuItem");
            this.SchineseToolStripMenuItem.Click += new System.EventHandler(this.SchineseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnPreviewImg
            // 
            this.btnPreviewImg.BackgroundImage = global::SplaTU.Properties.Resources.tile_B;
            resources.ApplyResources(this.btnPreviewImg, "btnPreviewImg");
            this.btnPreviewImg.ForeColor = System.Drawing.Color.SeaShell;
            this.btnPreviewImg.Image = global::SplaTU.Properties.Resources.icons8_PreviewPane_32;
            this.btnPreviewImg.Name = "btnPreviewImg";
            this.btnPreviewImg.UseVisualStyleBackColor = true;
            this.btnPreviewImg.Click += new System.EventHandler(this.btnPreviewImg_Click);
            // 
            // btnRunTeensy
            // 
            this.btnRunTeensy.BackgroundImage = global::SplaTU.Properties.Resources.tile_R;
            resources.ApplyResources(this.btnRunTeensy, "btnRunTeensy");
            this.btnRunTeensy.ForeColor = System.Drawing.Color.SeaShell;
            this.btnRunTeensy.Image = global::SplaTU.Properties.Resources.tpp_core;
            this.btnRunTeensy.Name = "btnRunTeensy";
            this.btnRunTeensy.UseVisualStyleBackColor = true;
            this.btnRunTeensy.Click += new System.EventHandler(this.btnRunTeensy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackgroundImage = global::SplaTU.Properties.Resources.tile_O;
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.ForeColor = System.Drawing.Color.SeaShell;
            this.btnGenerate.Image = global::SplaTU.Properties.Resources.icons8_Resume_Button_32;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Image = global::SplaTU.Properties.Resources.icons8_Open_32;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // SplaTU
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SplaTU.Properties.Resources.tile1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviewImg);
            this.Controls.Add(this.btnRunTeensy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SplaTU";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SchineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbOutput2;
        private System.Windows.Forms.Button btnPreviewImg;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRunTeensy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

