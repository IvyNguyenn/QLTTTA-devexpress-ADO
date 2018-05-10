namespace QLTTTA.GUI
{
   partial class frmOracleConfig
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
            this.lblForm = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.cbbSid = new System.Windows.Forms.ComboBox();
            this.cbbHostname = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.gvLoadData = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnGoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.Red;
            this.lblForm.Location = new System.Drawing.Point(249, 22);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(507, 42);
            this.lblForm.TabIndex = 25;
            this.lblForm.Text = "CONNECT C# TO ORACLE";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(217, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 43);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(52, 368);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 43);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbbTables
            // 
            this.cbbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTables.FormattingEnabled = true;
            this.cbbTables.Location = new System.Drawing.Point(207, 316);
            this.cbbTables.Name = "cbbTables";
            this.cbbTables.Size = new System.Drawing.Size(142, 37);
            this.cbbTables.TabIndex = 22;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.Location = new System.Drawing.Point(37, 323);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(102, 31);
            this.lblTables.TabIndex = 21;
            this.lblTables.Text = "Tables";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(207, 259);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(142, 34);
            this.tbPass.TabIndex = 20;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // cbbUser
            // 
            this.cbbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Items.AddRange(new object[] {
            "trungle97",
            "rum123"});
            this.cbbUser.Location = new System.Drawing.Point(207, 196);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(142, 37);
            this.cbbUser.TabIndex = 19;
            // 
            // cbbSid
            // 
            this.cbbSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSid.FormattingEnabled = true;
            this.cbbSid.Items.AddRange(new object[] {
            "db12c",
            "test"});
            this.cbbSid.Location = new System.Drawing.Point(207, 136);
            this.cbbSid.Name = "cbbSid";
            this.cbbSid.Size = new System.Drawing.Size(142, 37);
            this.cbbSid.TabIndex = 18;
            // 
            // cbbHostname
            // 
            this.cbbHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHostname.FormattingEnabled = true;
            this.cbbHostname.Items.AddRange(new object[] {
            "localhost",
            "192.168.43.152"});
            this.cbbHostname.Location = new System.Drawing.Point(207, 76);
            this.cbbHostname.Name = "cbbHostname";
            this.cbbHostname.Size = new System.Drawing.Size(142, 37);
            this.cbbHostname.TabIndex = 17;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(37, 263);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(142, 31);
            this.lblPass.TabIndex = 16;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(37, 203);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 31);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "User";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.Location = new System.Drawing.Point(37, 143);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(170, 31);
            this.lblSid.TabIndex = 14;
            this.lblSid.Text = "SID/Service";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.Location = new System.Drawing.Point(37, 83);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(146, 31);
            this.lblHostname.TabIndex = 13;
            this.lblHostname.Text = "Hostname";
            // 
            // gvLoadData
            // 
            this.gvLoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLoadData.Location = new System.Drawing.Point(364, 76);
            this.gvLoadData.Name = "gvLoadData";
            this.gvLoadData.ReadOnly = true;
            this.gvLoadData.Size = new System.Drawing.Size(515, 272);
            this.gvLoadData.TabIndex = 26;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(364, 365);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(285, 43);
            this.btnLoadData.TabIndex = 27;
            this.btnLoadData.Text = "LOAD DATA";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.Enabled = false;
            this.btnGoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoto.Location = new System.Drawing.Point(655, 365);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(224, 43);
            this.btnGoto.TabIndex = 28;
            this.btnGoto.Text = "GO TO APPLICATION";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // frmOracleConfig
            // 
            this.ClientSize = new System.Drawing.Size(884, 413);
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.gvLoadData);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbbTables);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.cbbUser);
            this.Controls.Add(this.cbbSid);
            this.Controls.Add(this.cbbHostname);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.lblHostname);
            this.MaximizeBox = false;
            this.Name = "frmOracleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOracleConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmOracleConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblForm;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnConnect;
      private System.Windows.Forms.ComboBox cbbTables;
      private System.Windows.Forms.Label lblTables;
      private System.Windows.Forms.TextBox tbPass;
      private System.Windows.Forms.ComboBox cbbUser;
      private System.Windows.Forms.ComboBox cbbSid;
      private System.Windows.Forms.ComboBox cbbHostname;
      private System.Windows.Forms.Label lblPass;
      private System.Windows.Forms.Label lblUser;
      private System.Windows.Forms.Label lblSid;
      private System.Windows.Forms.Label lblHostname;
      private System.Windows.Forms.DataGridView gvLoadData;
      private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnGoto;
    }
}

