namespace ArxDev
{
    partial class FormApplication
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.applicationStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAoo = new System.Windows.Forms.TabPage();
            this.buttonAooForArchivePa = new System.Windows.Forms.Button();
            this.buttonAooForArchive = new System.Windows.Forms.Button();
            this.buttonAooForSearch = new System.Windows.Forms.Button();
            this.dgAoo = new System.Windows.Forms.DataGridView();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.buttonInfoClasse = new System.Windows.Forms.Button();
            this.textBoxCodiceClasse = new System.Windows.Forms.TextBox();
            this.buttonClassesForEditProfile = new System.Windows.Forms.Button();
            this.buttonClassesForSearch = new System.Windows.Forms.Button();
            this.buttonClassesForArchive = new System.Windows.Forms.Button();
            this.dgClasses = new System.Windows.Forms.DataGridView();
            this.tabPageStates = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStatesByClass = new System.Windows.Forms.Button();
            this.textBoxClassCode = new System.Windows.Forms.TextBox();
            this.buttonStates = new System.Windows.Forms.Button();
            this.dgStates = new System.Windows.Forms.DataGridView();
            this.tabPageStore = new System.Windows.Forms.TabPage();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAoo)).BeginInit();
            this.tabPageClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasses)).BeginInit();
            this.tabPageStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStates)).BeginInit();
            this.tabPageStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(783, 439);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // applicationStrip
            // 
            this.applicationStrip.Name = "applicationStrip";
            this.applicationStrip.Size = new System.Drawing.Size(39, 17);
            this.applicationStrip.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAoo);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Controls.Add(this.tabPageStates);
            this.tabControl1.Controls.Add(this.tabPageStore);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 421);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAoo
            // 
            this.tabPageAoo.Controls.Add(this.buttonAooForArchivePa);
            this.tabPageAoo.Controls.Add(this.buttonAooForArchive);
            this.tabPageAoo.Controls.Add(this.buttonAooForSearch);
            this.tabPageAoo.Controls.Add(this.dgAoo);
            this.tabPageAoo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAoo.Name = "tabPageAoo";
            this.tabPageAoo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAoo.Size = new System.Drawing.Size(838, 395);
            this.tabPageAoo.TabIndex = 1;
            this.tabPageAoo.Text = "Aoo";
            this.tabPageAoo.UseVisualStyleBackColor = true;
            // 
            // buttonAooForArchivePa
            // 
            this.buttonAooForArchivePa.Location = new System.Drawing.Point(6, 64);
            this.buttonAooForArchivePa.Name = "buttonAooForArchivePa";
            this.buttonAooForArchivePa.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForArchivePa.TabIndex = 3;
            this.buttonAooForArchivePa.Text = "Get Aoo for Archive Pa ";
            this.buttonAooForArchivePa.UseVisualStyleBackColor = true;
            this.buttonAooForArchivePa.Click += new System.EventHandler(this.buttonAooForArchivePa_Click);
            // 
            // buttonAooForArchive
            // 
            this.buttonAooForArchive.Location = new System.Drawing.Point(6, 35);
            this.buttonAooForArchive.Name = "buttonAooForArchive";
            this.buttonAooForArchive.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForArchive.TabIndex = 2;
            this.buttonAooForArchive.Text = "Get Aoo for Archive";
            this.buttonAooForArchive.UseVisualStyleBackColor = true;
            this.buttonAooForArchive.Click += new System.EventHandler(this.buttonAooForArchive_Click);
            // 
            // buttonAooForSearch
            // 
            this.buttonAooForSearch.Location = new System.Drawing.Point(6, 6);
            this.buttonAooForSearch.Name = "buttonAooForSearch";
            this.buttonAooForSearch.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForSearch.TabIndex = 1;
            this.buttonAooForSearch.Text = "Get Aoo for Search";
            this.buttonAooForSearch.UseVisualStyleBackColor = true;
            this.buttonAooForSearch.Click += new System.EventHandler(this.buttonAooForSearch_Click);
            // 
            // dgAoo
            // 
            this.dgAoo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAoo.Location = new System.Drawing.Point(182, 6);
            this.dgAoo.Name = "dgAoo";
            this.dgAoo.Size = new System.Drawing.Size(650, 383);
            this.dgAoo.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.buttonInfoClasse);
            this.tabPageClasses.Controls.Add(this.textBoxCodiceClasse);
            this.tabPageClasses.Controls.Add(this.buttonClassesForEditProfile);
            this.tabPageClasses.Controls.Add(this.buttonClassesForSearch);
            this.tabPageClasses.Controls.Add(this.buttonClassesForArchive);
            this.tabPageClasses.Controls.Add(this.dgClasses);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(838, 395);
            this.tabPageClasses.TabIndex = 2;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // buttonInfoClasse
            // 
            this.buttonInfoClasse.Location = new System.Drawing.Point(6, 140);
            this.buttonInfoClasse.Name = "buttonInfoClasse";
            this.buttonInfoClasse.Size = new System.Drawing.Size(75, 23);
            this.buttonInfoClasse.TabIndex = 8;
            this.buttonInfoClasse.Text = "Class info";
            this.buttonInfoClasse.UseVisualStyleBackColor = true;
            this.buttonInfoClasse.Click += new System.EventHandler(this.buttonInfoClasse_Click);
            // 
            // textBoxCodiceClasse
            // 
            this.textBoxCodiceClasse.Location = new System.Drawing.Point(6, 114);
            this.textBoxCodiceClasse.Name = "textBoxCodiceClasse";
            this.textBoxCodiceClasse.Size = new System.Drawing.Size(170, 20);
            this.textBoxCodiceClasse.TabIndex = 7;
            // 
            // buttonClassesForEditProfile
            // 
            this.buttonClassesForEditProfile.Location = new System.Drawing.Point(6, 64);
            this.buttonClassesForEditProfile.Name = "buttonClassesForEditProfile";
            this.buttonClassesForEditProfile.Size = new System.Drawing.Size(170, 23);
            this.buttonClassesForEditProfile.TabIndex = 4;
            this.buttonClassesForEditProfile.Text = "Get Classes For Edit Profile";
            this.buttonClassesForEditProfile.UseVisualStyleBackColor = true;
            this.buttonClassesForEditProfile.Click += new System.EventHandler(this.buttonClassesForEditProfile_Click);
            // 
            // buttonClassesForSearch
            // 
            this.buttonClassesForSearch.Location = new System.Drawing.Point(6, 35);
            this.buttonClassesForSearch.Name = "buttonClassesForSearch";
            this.buttonClassesForSearch.Size = new System.Drawing.Size(170, 23);
            this.buttonClassesForSearch.TabIndex = 3;
            this.buttonClassesForSearch.Text = "Get Classes For Search";
            this.buttonClassesForSearch.UseVisualStyleBackColor = true;
            this.buttonClassesForSearch.Click += new System.EventHandler(this.buttonClassesForSearch_Click);
            // 
            // buttonClassesForArchive
            // 
            this.buttonClassesForArchive.Location = new System.Drawing.Point(6, 6);
            this.buttonClassesForArchive.Name = "buttonClassesForArchive";
            this.buttonClassesForArchive.Size = new System.Drawing.Size(170, 23);
            this.buttonClassesForArchive.TabIndex = 2;
            this.buttonClassesForArchive.Text = "Get Classes For Archive";
            this.buttonClassesForArchive.UseVisualStyleBackColor = true;
            this.buttonClassesForArchive.Click += new System.EventHandler(this.buttonClassesForArchive_Click);
            // 
            // dgClasses
            // 
            this.dgClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClasses.Location = new System.Drawing.Point(182, 6);
            this.dgClasses.Name = "dgClasses";
            this.dgClasses.Size = new System.Drawing.Size(650, 383);
            this.dgClasses.TabIndex = 1;
            // 
            // tabPageStates
            // 
            this.tabPageStates.Controls.Add(this.label1);
            this.tabPageStates.Controls.Add(this.buttonStatesByClass);
            this.tabPageStates.Controls.Add(this.textBoxClassCode);
            this.tabPageStates.Controls.Add(this.buttonStates);
            this.tabPageStates.Controls.Add(this.dgStates);
            this.tabPageStates.Location = new System.Drawing.Point(4, 22);
            this.tabPageStates.Name = "tabPageStates";
            this.tabPageStates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStates.Size = new System.Drawing.Size(838, 395);
            this.tabPageStates.TabIndex = 3;
            this.tabPageStates.Text = "States";
            this.tabPageStates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set the class code";
            // 
            // buttonStatesByClass
            // 
            this.buttonStatesByClass.Location = new System.Drawing.Point(6, 106);
            this.buttonStatesByClass.Name = "buttonStatesByClass";
            this.buttonStatesByClass.Size = new System.Drawing.Size(170, 23);
            this.buttonStatesByClass.TabIndex = 6;
            this.buttonStatesByClass.Text = "States by class";
            this.buttonStatesByClass.UseVisualStyleBackColor = true;
            this.buttonStatesByClass.Click += new System.EventHandler(this.buttonStatesByClass_Click);
            // 
            // textBoxClassCode
            // 
            this.textBoxClassCode.Location = new System.Drawing.Point(6, 80);
            this.textBoxClassCode.Name = "textBoxClassCode";
            this.textBoxClassCode.Size = new System.Drawing.Size(170, 20);
            this.textBoxClassCode.TabIndex = 5;
            // 
            // buttonStates
            // 
            this.buttonStates.Location = new System.Drawing.Point(6, 6);
            this.buttonStates.Name = "buttonStates";
            this.buttonStates.Size = new System.Drawing.Size(170, 23);
            this.buttonStates.TabIndex = 4;
            this.buttonStates.Text = "States";
            this.buttonStates.UseVisualStyleBackColor = true;
            this.buttonStates.Click += new System.EventHandler(this.buttonStates_Click);
            // 
            // dgStates
            // 
            this.dgStates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStates.Location = new System.Drawing.Point(182, 6);
            this.dgStates.Name = "dgStates";
            this.dgStates.Size = new System.Drawing.Size(650, 383);
            this.dgStates.TabIndex = 3;
            // 
            // tabPageStore
            // 
            this.tabPageStore.Controls.Add(this.buttonEditProfile);
            this.tabPageStore.Controls.Add(this.buttonArchive);
            this.tabPageStore.Location = new System.Drawing.Point(4, 22);
            this.tabPageStore.Name = "tabPageStore";
            this.tabPageStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStore.Size = new System.Drawing.Size(838, 395);
            this.tabPageStore.TabIndex = 4;
            this.tabPageStore.Text = "Store";
            this.tabPageStore.UseVisualStyleBackColor = true;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(6, 35);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(170, 23);
            this.buttonEditProfile.TabIndex = 6;
            this.buttonEditProfile.Text = "Edit profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(6, 6);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(170, 23);
            this.buttonArchive.TabIndex = 5;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAoo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAoo)).EndInit();
            this.tabPageClasses.ResumeLayout(false);
            this.tabPageClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasses)).EndInit();
            this.tabPageStates.ResumeLayout(false);
            this.tabPageStates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStates)).EndInit();
            this.tabPageStore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel applicationStrip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAoo;
        private System.Windows.Forms.Button buttonAooForArchivePa;
        private System.Windows.Forms.Button buttonAooForArchive;
        private System.Windows.Forms.Button buttonAooForSearch;
        private System.Windows.Forms.DataGridView dgAoo;
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.Button buttonClassesForArchive;
        private System.Windows.Forms.DataGridView dgClasses;
        private System.Windows.Forms.Button buttonClassesForEditProfile;
        private System.Windows.Forms.Button buttonClassesForSearch;
        private System.Windows.Forms.TabPage tabPageStates;
        private System.Windows.Forms.Button buttonStates;
        private System.Windows.Forms.DataGridView dgStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStatesByClass;
        private System.Windows.Forms.TextBox textBoxClassCode;
        private System.Windows.Forms.TabPage tabPageStore;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonInfoClasse;
        private System.Windows.Forms.TextBox textBoxCodiceClasse;
    }
}