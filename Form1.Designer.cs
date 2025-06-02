using System;
using System.Data.SqlClient;
namespace LTW_ContactApp

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        string connectionString = "Server=localhost;Database=ContactData;Trusted_Connection=True;";

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnDangNhap = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnSignIn = new Button();
            btnESC = new Button();
            tbLoginPass = new TextBox();
            tbLoginName = new TextBox();
            linkQuen = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pnDangKy = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            tbReMatKhau = new TextBox();
            tbMatKhau = new TextBox();
            tbEmail = new TextBox();
            tbSdt = new TextBox();
            tbName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnQuen = new Panel();
            btnConfirmChange = new Button();
            btnCancelChange = new Button();
            btnGui = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            tbCaptchaCode = new TextBox();
            tbValidateEmail = new TextBox();
            label12 = new Label();
            label11 = new Label();
            lbCaptcha = new Label();
            label9 = new Label();
            label8 = new Label();
            pnContactList = new Panel();
            splitContainer1 = new SplitContainer();
            tbSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            pnDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnQuen.SuspendLayout();
            pnContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnDangNhap
            // 
            pnDangNhap.Controls.Add(pictureBox2);
            pnDangNhap.Controls.Add(pictureBox1);
            pnDangNhap.Controls.Add(btnLogin);
            pnDangNhap.Controls.Add(btnSignIn);
            pnDangNhap.Controls.Add(btnESC);
            pnDangNhap.Controls.Add(tbLoginPass);
            pnDangNhap.Controls.Add(tbLoginName);
            pnDangNhap.Controls.Add(linkQuen);
            pnDangNhap.Controls.Add(label2);
            pnDangNhap.Controls.Add(label1);
            pnDangNhap.Dock = DockStyle.Fill;
            pnDangNhap.Location = new Point(0, 0);
            pnDangNhap.Name = "pnDangNhap";
            pnDangNhap.Size = new Size(482, 353);
            pnDangNhap.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(142, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.GreenYellow;
            btnLogin.Location = new Point(198, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Turquoise;
            btnSignIn.Location = new Point(46, 262);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(99, 42);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Đăng ký";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnESC
            // 
            btnESC.BackColor = Color.Salmon;
            btnESC.Location = new Point(352, 262);
            btnESC.Name = "btnESC";
            btnESC.Size = new Size(98, 42);
            btnESC.TabIndex = 5;
            btnESC.Text = "Thoát";
            btnESC.UseVisualStyleBackColor = false;
            btnESC.Click += btnESC_Click;
            // 
            // tbLoginPass
            // 
            tbLoginPass.Location = new Point(139, 122);
            tbLoginPass.Name = "tbLoginPass";
            tbLoginPass.PasswordChar = '*';
            tbLoginPass.Size = new Size(231, 27);
            tbLoginPass.TabIndex = 4;
            // 
            // tbLoginName
            // 
            tbLoginName.Location = new Point(139, 47);
            tbLoginName.Name = "tbLoginName";
            tbLoginName.Size = new Size(231, 27);
            tbLoginName.TabIndex = 3;
            // 
            // linkQuen
            // 
            linkQuen.AutoSize = true;
            linkQuen.Location = new Point(176, 179);
            linkQuen.Name = "linkQuen";
            linkQuen.Size = new Size(120, 20);
            linkQuen.TabIndex = 2;
            linkQuen.TabStop = true;
            linkQuen.Text = "Quên mật khẩu ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 24);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu";
            // 
            // pnDangKy
            // 
            pnDangKy.BackColor = SystemColors.ControlLight;
            pnDangKy.Controls.Add(pictureBox7);
            pnDangKy.Controls.Add(pictureBox6);
            pnDangKy.Controls.Add(pictureBox5);
            pnDangKy.Controls.Add(pictureBox4);
            pnDangKy.Controls.Add(pictureBox3);
            pnDangKy.Controls.Add(btnDangKy);
            pnDangKy.Controls.Add(btnHuy);
            pnDangKy.Controls.Add(tbReMatKhau);
            pnDangKy.Controls.Add(tbMatKhau);
            pnDangKy.Controls.Add(tbEmail);
            pnDangKy.Controls.Add(tbSdt);
            pnDangKy.Controls.Add(tbName);
            pnDangKy.Controls.Add(label7);
            pnDangKy.Controls.Add(label6);
            pnDangKy.Controls.Add(label5);
            pnDangKy.Controls.Add(label4);
            pnDangKy.Controls.Add(label3);
            pnDangKy.Dock = DockStyle.Fill;
            pnDangKy.Location = new Point(0, 0);
            pnDangKy.Name = "pnDangKy";
            pnDangKy.Size = new Size(482, 353);
            pnDangKy.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(46, 227);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(46, 183);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(46, 135);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(46, 87);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(46, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.LawnGreen;
            btnDangKy.Location = new Point(352, 299);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Tomato;
            btnHuy.Location = new Point(234, 299);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // tbReMatKhau
            // 
            tbReMatKhau.Location = new Point(234, 227);
            tbReMatKhau.Name = "tbReMatKhau";
            tbReMatKhau.Size = new Size(227, 27);
            tbReMatKhau.TabIndex = 1;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(234, 180);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(227, 27);
            tbMatKhau.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(234, 133);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(227, 27);
            tbEmail.TabIndex = 1;
            // 
            // tbSdt
            // 
            tbSdt.Location = new Point(234, 86);
            tbSdt.Name = "tbSdt";
            tbSdt.Size = new Size(227, 27);
            tbSdt.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(234, 39);
            tbName.Name = "tbName";
            tbName.Size = new Size(227, 27);
            tbName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Wheat;
            label7.Location = new Point(89, 231);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 0;
            label7.Text = "Nhập lại mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Wheat;
            label6.Location = new Point(89, 191);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Wheat;
            label5.Location = new Point(95, 143);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.Location = new Point(89, 95);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 0;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.Location = new Point(89, 47);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập";
            // 
            // pnQuen
            // 
            pnQuen.Controls.Add(btnConfirmChange);
            pnQuen.Controls.Add(btnCancelChange);
            pnQuen.Controls.Add(btnGui);
            pnQuen.Controls.Add(textBox4);
            pnQuen.Controls.Add(textBox3);
            pnQuen.Controls.Add(tbCaptchaCode);
            pnQuen.Controls.Add(tbValidateEmail);
            pnQuen.Controls.Add(label12);
            pnQuen.Controls.Add(label11);
            pnQuen.Controls.Add(lbCaptcha);
            pnQuen.Controls.Add(label9);
            pnQuen.Controls.Add(label8);
            pnQuen.Dock = DockStyle.Fill;
            pnQuen.Location = new Point(0, 0);
            pnQuen.Name = "pnQuen";
            pnQuen.Size = new Size(482, 353);
            pnQuen.TabIndex = 9;
            // 
            // btnConfirmChange
            // 
            btnConfirmChange.BackColor = Color.DodgerBlue;
            btnConfirmChange.Location = new Point(334, 299);
            btnConfirmChange.Name = "btnConfirmChange";
            btnConfirmChange.Size = new Size(130, 29);
            btnConfirmChange.TabIndex = 2;
            btnConfirmChange.Text = "Đổi mật khẩu";
            btnConfirmChange.UseVisualStyleBackColor = false;
            // 
            // btnCancelChange
            // 
            btnCancelChange.BackColor = Color.Coral;
            btnCancelChange.Location = new Point(221, 299);
            btnCancelChange.Name = "btnCancelChange";
            btnCancelChange.Size = new Size(94, 29);
            btnCancelChange.TabIndex = 2;
            btnCancelChange.Text = "Hủy";
            btnCancelChange.UseVisualStyleBackColor = false;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.Orange;
            btnGui.Location = new Point(352, 75);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(61, 29);
            btnGui.TabIndex = 2;
            btnGui.Text = "Gửi";
            btnGui.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(222, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 1;
            // 
            // tbCaptchaCode
            // 
            tbCaptchaCode.Location = new Point(221, 75);
            tbCaptchaCode.Name = "tbCaptchaCode";
            tbCaptchaCode.Size = new Size(125, 27);
            tbCaptchaCode.TabIndex = 1;
            // 
            // tbValidateEmail
            // 
            tbValidateEmail.Location = new Point(163, 38);
            tbValidateEmail.Name = "tbValidateEmail";
            tbValidateEmail.Size = new Size(183, 27);
            tbValidateEmail.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 194);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 0;
            label12.Text = "Xác nhận mật khẩu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 152);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 0;
            label11.Text = "Mật khẩu mới";
            // 
            // lbCaptcha
            // 
            lbCaptcha.AutoSize = true;
            lbCaptcha.BackColor = Color.NavajoWhite;
            lbCaptcha.Location = new Point(219, 116);
            lbCaptcha.Name = "lbCaptcha";
            lbCaptcha.Size = new Size(45, 20);
            lbCaptcha.TabIndex = 0;
            lbCaptcha.Text = "         ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 76);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 0;
            label9.Text = "Mã xác thực";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 39);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // pnContactList
            // 
            pnContactList.Controls.Add(splitContainer1);
            pnContactList.Dock = DockStyle.Fill;
            pnContactList.Location = new Point(0, 0);
            pnContactList.Name = "pnContactList";
            pnContactList.Size = new Size(482, 353);
            pnContactList.TabIndex = 10;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DodgerBlue;
            splitContainer1.Panel1.Controls.Add(tbSearch);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(482, 353);
            splitContainer1.SplitterDistance = 25;
            splitContainer1.TabIndex = 0;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Right;
            tbSearch.Location = new Point(263, 1);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(216, 27);
            tbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.SkyBlue;
            btnSearch.Location = new Point(158, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.Location = new Point(12, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(482, 324);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "STT";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnESC;
            ClientSize = new Size(482, 353);
            Controls.Add(pnDangNhap);
            Controls.Add(pnDangKy);
            Controls.Add(pnContactList);
            Controls.Add(pnQuen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnDangNhap.ResumeLayout(false);
            pnDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnDangKy.ResumeLayout(false);
            pnDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnQuen.ResumeLayout(false);
            pnQuen.PerformLayout();
            pnContactList.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDangNhap;
        private Button btnLogin;
        private Button btnSignIn;
        private Button btnESC;
        private TextBox tbLoginPass;
        private TextBox tbLoginName;
        private LinkLabel linkQuen;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel pnDangKy;
        private Button btnDangKy;
        private Button btnHuy;
        private TextBox tbReMatKhau;
        private TextBox tbMatKhau;
        private TextBox tbEmail;
        private TextBox tbSdt;
        private TextBox tbName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel pnQuen;
        private Button btnConfirmChange;
        private Button btnCancelChange;
        private Button btnGui;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox tbCaptchaCode;
        private TextBox tbValidateEmail;
        private Label label12;
        private Label label11;
        private Label lbCaptcha;
        private Label label9;
        private Label label8;
        private Panel pnContactList;
        private SplitContainer splitContainer1;
        private Button btnAdd;
        private TextBox tbSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
    }
}
