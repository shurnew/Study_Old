namespace GeomexWorkManager.Login
{
    partial class FrmConfig
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPw = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDB = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new DevExpress.XtraEditors.TextEdit();
            this.btnConnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.btnClose);
            this.flyoutPanel1.Controls.Add(this.txtPw);
            this.flyoutPanel1.Controls.Add(this.label5);
            this.flyoutPanel1.Controls.Add(this.txtUsername);
            this.flyoutPanel1.Controls.Add(this.label4);
            this.flyoutPanel1.Controls.Add(this.txtDB);
            this.flyoutPanel1.Controls.Add(this.label3);
            this.flyoutPanel1.Controls.Add(this.txtPort);
            this.flyoutPanel1.Controls.Add(this.label2);
            this.flyoutPanel1.Controls.Add(this.txtIP);
            this.flyoutPanel1.Controls.Add(this.btnConnTest);
            this.flyoutPanel1.Controls.Add(this.btnSave);
            this.flyoutPanel1.Controls.Add(this.label1);
            this.flyoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flyoutPanel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(348, 540);
            this.flyoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(209, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "button3";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPw
            // 
            this.txtPw.EditValue = "1234";
            this.txtPw.Location = new System.Drawing.Point(85, 217);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(199, 20);
            this.txtPw.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "PassWord";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 191);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 20);
            this.txtUsername.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(58, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "DB";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(85, 165);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(199, 20);
            this.txtDB.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "UserName";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 139);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(199, 20);
            this.txtPort.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(44, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.EditValue = "127.0.0.1";
            this.txtIP.Location = new System.Drawing.Point(85, 113);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(199, 20);
            this.txtIP.TabIndex = 16;
            // 
            // btnConnTest
            // 
            this.btnConnTest.Location = new System.Drawing.Point(227, 254);
            this.btnConnTest.Name = "btnConnTest";
            this.btnConnTest.Size = new System.Drawing.Size(75, 23);
            this.btnConnTest.TabIndex = 15;
            this.btnConnTest.Text = "button2";
            this.btnConnTest.UseVisualStyleBackColor = true;
            this.btnConnTest.Click += new System.EventHandler(this.btnConnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanel1);
            this.Name = "FrmConfig";
            this.Size = new System.Drawing.Size(1120, 768);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            this.flyoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.TextEdit txtPw;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtDB;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIP;
        private System.Windows.Forms.Button btnConnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}
