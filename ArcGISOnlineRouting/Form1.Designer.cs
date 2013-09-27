namespace ArcGISOnlineRouting
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
      this.label17 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.btnAuthenticate = new System.Windows.Forms.Button();
      this.btnRoute = new System.Windows.Forms.Button();
      this.txtOrg = new System.Windows.Forms.TextBox();
      this.btnBatchGeocode = new System.Windows.Forms.Button();
      this.btnReverseGeocode = new System.Windows.Forms.Button();
      this.btnGeocode = new System.Windows.Forms.Button();
      this.btnGeocodeService = new System.Windows.Forms.Button();
      this.btnRouteService = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaxRecords = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.chkAddress = new System.Windows.Forms.CheckBox();
      this.chkbxPOI = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtReverseGeocode = new System.Windows.Forms.TextBox();
      this.txtReverseGeocodeResult = new System.Windows.Forms.TextBox();
      this.txtBatchGeo4 = new System.Windows.Forms.TextBox();
      this.txtBatchGeo3 = new System.Windows.Forms.TextBox();
      this.txtBatchGeo2 = new System.Windows.Forms.TextBox();
      this.txtBatchGeo1 = new System.Windows.Forms.TextBox();
      this.txtGeocodeResult = new System.Windows.Forms.TextBox();
      this.txtBatchGeoCode = new System.Windows.Forms.TextBox();
      this.txtRoute = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(12, 12);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(227, 26);
      this.label17.TabIndex = 82;
      this.label17.Text = "Organisation Endpoint";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(538, 10);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(114, 26);
      this.label14.TabIndex = 81;
      this.label14.Text = "Password:";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(538, 41);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(128, 31);
      this.txtPassword.TabIndex = 80;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(380, 10);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(129, 26);
      this.label13.TabIndex = 79;
      this.label13.Text = "User Name:";
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(380, 41);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(152, 31);
      this.txtUserName.TabIndex = 78;
      // 
      // btnAuthenticate
      // 
      this.btnAuthenticate.Location = new System.Drawing.Point(12, 85);
      this.btnAuthenticate.Name = "btnAuthenticate";
      this.btnAuthenticate.Size = new System.Drawing.Size(226, 39);
      this.btnAuthenticate.TabIndex = 77;
      this.btnAuthenticate.Text = "Authenticate";
      this.btnAuthenticate.UseVisualStyleBackColor = true;
      this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
      // 
      // btnRoute
      // 
      this.btnRoute.Enabled = false;
      this.btnRoute.Location = new System.Drawing.Point(12, 921);
      this.btnRoute.Name = "btnRoute";
      this.btnRoute.Size = new System.Drawing.Size(226, 39);
      this.btnRoute.TabIndex = 84;
      this.btnRoute.Text = "Route";
      this.btnRoute.UseVisualStyleBackColor = true;
      this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
      // 
      // txtOrg
      // 
      this.txtOrg.Location = new System.Drawing.Point(17, 41);
      this.txtOrg.Name = "txtOrg";
      this.txtOrg.Size = new System.Drawing.Size(320, 31);
      this.txtOrg.TabIndex = 85;
      this.txtOrg.Text = "http://startups.maps.arcgis.com/";
      // 
      // btnBatchGeocode
      // 
      this.btnBatchGeocode.Enabled = false;
      this.btnBatchGeocode.Location = new System.Drawing.Point(12, 609);
      this.btnBatchGeocode.Name = "btnBatchGeocode";
      this.btnBatchGeocode.Size = new System.Drawing.Size(226, 39);
      this.btnBatchGeocode.TabIndex = 86;
      this.btnBatchGeocode.Text = "Batch Geocode";
      this.btnBatchGeocode.UseVisualStyleBackColor = true;
      this.btnBatchGeocode.Click += new System.EventHandler(this.btnBatchGeocode_Click);
      // 
      // btnReverseGeocode
      // 
      this.btnReverseGeocode.Enabled = false;
      this.btnReverseGeocode.Location = new System.Drawing.Point(13, 494);
      this.btnReverseGeocode.Name = "btnReverseGeocode";
      this.btnReverseGeocode.Size = new System.Drawing.Size(226, 39);
      this.btnReverseGeocode.TabIndex = 87;
      this.btnReverseGeocode.Text = "Reverse Geocode";
      this.btnReverseGeocode.UseVisualStyleBackColor = true;
      this.btnReverseGeocode.Click += new System.EventHandler(this.btnReverseGeocode_Click);
      // 
      // btnGeocode
      // 
      this.btnGeocode.Enabled = false;
      this.btnGeocode.Location = new System.Drawing.Point(13, 277);
      this.btnGeocode.Name = "btnGeocode";
      this.btnGeocode.Size = new System.Drawing.Size(226, 39);
      this.btnGeocode.TabIndex = 88;
      this.btnGeocode.Text = "Geocode";
      this.btnGeocode.UseVisualStyleBackColor = true;
      this.btnGeocode.Click += new System.EventHandler(this.btnGeocode_Click);
      // 
      // btnGeocodeService
      // 
      this.btnGeocodeService.Enabled = false;
      this.btnGeocodeService.Location = new System.Drawing.Point(13, 146);
      this.btnGeocodeService.Name = "btnGeocodeService";
      this.btnGeocodeService.Size = new System.Drawing.Size(226, 39);
      this.btnGeocodeService.TabIndex = 89;
      this.btnGeocodeService.Text = "Geocode Service Info";
      this.btnGeocodeService.UseVisualStyleBackColor = true;
      this.btnGeocodeService.Click += new System.EventHandler(this.btnGeocodeService_Click);
      // 
      // btnRouteService
      // 
      this.btnRouteService.Enabled = false;
      this.btnRouteService.Location = new System.Drawing.Point(12, 191);
      this.btnRouteService.Name = "btnRouteService";
      this.btnRouteService.Size = new System.Drawing.Size(226, 39);
      this.btnRouteService.TabIndex = 90;
      this.btnRouteService.Text = "Route Service";
      this.btnRouteService.UseVisualStyleBackColor = true;
      this.btnRouteService.Click += new System.EventHandler(this.btnRouteService_Click);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(250, 146);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(565, 84);
      this.textBox1.TabIndex = 91;
      // 
      // textBox2
      // 
      this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox2.Location = new System.Drawing.Point(250, 89);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(565, 31);
      this.textBox2.TabIndex = 92;
      // 
      // txtAddress
      // 
      this.txtAddress.AcceptsReturn = true;
      this.txtAddress.Location = new System.Drawing.Point(250, 281);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(565, 31);
      this.txtAddress.TabIndex = 93;
      this.txtAddress.Text = "Sydney Aus Starbucks";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(250, 252);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(361, 26);
      this.label1.TabIndex = 94;
      this.label1.Text = "Address / POIs (city, region, search)";
      // 
      // txtMaxRecords
      // 
      this.txtMaxRecords.Location = new System.Drawing.Point(250, 347);
      this.txtMaxRecords.Name = "txtMaxRecords";
      this.txtMaxRecords.Size = new System.Drawing.Size(147, 31);
      this.txtMaxRecords.TabIndex = 95;
      this.txtMaxRecords.Text = "20";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(250, 318);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(152, 26);
      this.label2.TabIndex = 96;
      this.label2.Text = "Max Lacations";
      // 
      // chkAddress
      // 
      this.chkAddress.AutoSize = true;
      this.chkAddress.Location = new System.Drawing.Point(555, 348);
      this.chkAddress.Name = "chkAddress";
      this.chkAddress.Size = new System.Drawing.Size(118, 30);
      this.chkAddress.TabIndex = 98;
      this.chkAddress.Text = "Address";
      this.chkAddress.UseVisualStyleBackColor = true;
      // 
      // chkbxPOI
      // 
      this.chkbxPOI.AutoSize = true;
      this.chkbxPOI.Checked = true;
      this.chkbxPOI.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkbxPOI.Location = new System.Drawing.Point(555, 312);
      this.chkbxPOI.Name = "chkbxPOI";
      this.chkbxPOI.Size = new System.Drawing.Size(87, 30);
      this.chkbxPOI.TabIndex = 99;
      this.chkbxPOI.Text = "POIs";
      this.chkbxPOI.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(250, 491);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 26);
      this.label3.TabIndex = 101;
      this.label3.Text = "Lat / lon";
      // 
      // txtReverseGeocode
      // 
      this.txtReverseGeocode.AcceptsReturn = true;
      this.txtReverseGeocode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtReverseGeocode.Location = new System.Drawing.Point(250, 520);
      this.txtReverseGeocode.Name = "txtReverseGeocode";
      this.txtReverseGeocode.Size = new System.Drawing.Size(565, 31);
      this.txtReverseGeocode.TabIndex = 100;
      this.txtReverseGeocode.Text = "34.0564, -117.1956";
      // 
      // txtReverseGeocodeResult
      // 
      this.txtReverseGeocodeResult.AcceptsReturn = true;
      this.txtReverseGeocodeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtReverseGeocodeResult.Location = new System.Drawing.Point(250, 557);
      this.txtReverseGeocodeResult.Name = "txtReverseGeocodeResult";
      this.txtReverseGeocodeResult.Size = new System.Drawing.Size(565, 31);
      this.txtReverseGeocodeResult.TabIndex = 102;
      // 
      // txtBatchGeo4
      // 
      this.txtBatchGeo4.AcceptsReturn = true;
      this.txtBatchGeo4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatchGeo4.Location = new System.Drawing.Point(250, 722);
      this.txtBatchGeo4.Name = "txtBatchGeo4";
      this.txtBatchGeo4.Size = new System.Drawing.Size(565, 31);
      this.txtBatchGeo4.TabIndex = 104;
      this.txtBatchGeo4.Text = "1 International Ct, Broomfield, CO";
      // 
      // txtBatchGeo3
      // 
      this.txtBatchGeo3.AcceptsReturn = true;
      this.txtBatchGeo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatchGeo3.Location = new System.Drawing.Point(250, 685);
      this.txtBatchGeo3.Name = "txtBatchGeo3";
      this.txtBatchGeo3.Size = new System.Drawing.Size(565, 31);
      this.txtBatchGeo3.TabIndex = 103;
      this.txtBatchGeo3.Text = "606 Columbia St NW, Olympia, WA";
      // 
      // txtBatchGeo2
      // 
      this.txtBatchGeo2.AcceptsReturn = true;
      this.txtBatchGeo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatchGeo2.Location = new System.Drawing.Point(250, 649);
      this.txtBatchGeo2.Name = "txtBatchGeo2";
      this.txtBatchGeo2.Size = new System.Drawing.Size(565, 31);
      this.txtBatchGeo2.TabIndex = 106;
      this.txtBatchGeo2.Text = "55 Ferncroft Rd, Danvers, MA";
      // 
      // txtBatchGeo1
      // 
      this.txtBatchGeo1.AcceptsReturn = true;
      this.txtBatchGeo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatchGeo1.Location = new System.Drawing.Point(250, 612);
      this.txtBatchGeo1.Name = "txtBatchGeo1";
      this.txtBatchGeo1.Size = new System.Drawing.Size(565, 31);
      this.txtBatchGeo1.TabIndex = 105;
      this.txtBatchGeo1.Text = "380 New York Street, Redlands, CA";
      // 
      // txtGeocodeResult
      // 
      this.txtGeocodeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtGeocodeResult.Location = new System.Drawing.Point(250, 384);
      this.txtGeocodeResult.Multiline = true;
      this.txtGeocodeResult.Name = "txtGeocodeResult";
      this.txtGeocodeResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtGeocodeResult.Size = new System.Drawing.Size(565, 84);
      this.txtGeocodeResult.TabIndex = 97;
      // 
      // txtBatchGeoCode
      // 
      this.txtBatchGeoCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatchGeoCode.Location = new System.Drawing.Point(250, 769);
      this.txtBatchGeoCode.Multiline = true;
      this.txtBatchGeoCode.Name = "txtBatchGeoCode";
      this.txtBatchGeoCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtBatchGeoCode.Size = new System.Drawing.Size(565, 119);
      this.txtBatchGeoCode.TabIndex = 107;
      // 
      // txtRoute
      // 
      this.txtRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRoute.Location = new System.Drawing.Point(250, 921);
      this.txtRoute.Multiline = true;
      this.txtRoute.Name = "txtRoute";
      this.txtRoute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtRoute.Size = new System.Drawing.Size(565, 119);
      this.txtRoute.TabIndex = 108;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(827, 1065);
      this.Controls.Add(this.txtRoute);
      this.Controls.Add(this.txtBatchGeoCode);
      this.Controls.Add(this.txtBatchGeo2);
      this.Controls.Add(this.txtBatchGeo1);
      this.Controls.Add(this.txtBatchGeo4);
      this.Controls.Add(this.txtBatchGeo3);
      this.Controls.Add(this.txtReverseGeocodeResult);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtReverseGeocode);
      this.Controls.Add(this.chkbxPOI);
      this.Controls.Add(this.chkAddress);
      this.Controls.Add(this.txtGeocodeResult);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMaxRecords);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnRouteService);
      this.Controls.Add(this.btnGeocodeService);
      this.Controls.Add(this.btnGeocode);
      this.Controls.Add(this.btnReverseGeocode);
      this.Controls.Add(this.btnBatchGeocode);
      this.Controls.Add(this.txtOrg);
      this.Controls.Add(this.btnRoute);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.btnAuthenticate);
      this.Name = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Button btnAuthenticate;
    private System.Windows.Forms.Button btnRoute;
    private System.Windows.Forms.TextBox txtOrg;
    private System.Windows.Forms.Button btnBatchGeocode;
    private System.Windows.Forms.Button btnReverseGeocode;
    private System.Windows.Forms.Button btnGeocode;
    private System.Windows.Forms.Button btnGeocodeService;
    private System.Windows.Forms.Button btnRouteService;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaxRecords;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox chkAddress;
    private System.Windows.Forms.CheckBox chkbxPOI;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtReverseGeocode;
    private System.Windows.Forms.TextBox txtReverseGeocodeResult;
    private System.Windows.Forms.TextBox txtBatchGeo4;
    private System.Windows.Forms.TextBox txtBatchGeo3;
    private System.Windows.Forms.TextBox txtBatchGeo2;
    private System.Windows.Forms.TextBox txtBatchGeo1;
    private System.Windows.Forms.TextBox txtGeocodeResult;
    private System.Windows.Forms.TextBox txtBatchGeoCode;
    private System.Windows.Forms.TextBox txtRoute;
  }
}

