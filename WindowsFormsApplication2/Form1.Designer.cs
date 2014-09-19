using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    partial class Form1
    {
        private bool isDragging = false;
        private int currentX, currentY;

        Rectangle dropRect = new Rectangle(180, 180, 60, 60);
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.L_cardgroup = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_act = new System.Windows.Forms.Label();
            this.L_actrate = new System.Windows.Forms.Label();
            this.L_name = new System.Windows.Forms.Label();
            this.L_mp = new System.Windows.Forms.Label();
            this.L_level = new System.Windows.Forms.Label();
            this.L_def = new System.Windows.Forms.Label();
            this.L_demo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_team2 = new System.Windows.Forms.Label();
            this.L_team1 = new System.Windows.Forms.Label();
            this.L_hp = new System.Windows.Forms.Label();
            this.L_cardgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_cardgroup
            // 
            this.L_cardgroup.Controls.Add(this.vScrollBar1);
            this.L_cardgroup.Controls.Add(this.pictureBox13);
            this.L_cardgroup.Controls.Add(this.pictureBox14);
            this.L_cardgroup.Controls.Add(this.pictureBox15);
            this.L_cardgroup.Controls.Add(this.pictureBox7);
            this.L_cardgroup.Controls.Add(this.pictureBox8);
            this.L_cardgroup.Controls.Add(this.pictureBox9);
            this.L_cardgroup.Controls.Add(this.pictureBox10);
            this.L_cardgroup.Controls.Add(this.pictureBox11);
            this.L_cardgroup.Controls.Add(this.pictureBox12);
            this.L_cardgroup.Controls.Add(this.pictureBox6);
            this.L_cardgroup.Controls.Add(this.pictureBox5);
            this.L_cardgroup.Controls.Add(this.pictureBox4);
            this.L_cardgroup.Controls.Add(this.pictureBox3);
            this.L_cardgroup.Controls.Add(this.pictureBox2);
            this.L_cardgroup.Controls.Add(this.pictureBox1);
            this.L_cardgroup.Font = new System.Drawing.Font("新細明體", 16F);
            this.L_cardgroup.Location = new System.Drawing.Point(33, 21);
            this.L_cardgroup.Name = "L_cardgroup";
            this.L_cardgroup.Size = new System.Drawing.Size(400, 400);
            this.L_cardgroup.TabIndex = 1;
            this.L_cardgroup.TabStop = false;
            this.L_cardgroup.Text = "牌組";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(382, 15);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 400);
            this.vScrollBar1.TabIndex = 15;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApplication2.Properties.Resources.Jellyfish;
            this.pictureBox13.InitialImage = null;
            this.pictureBox13.Location = new System.Drawing.Point(170, 150);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 80);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WindowsFormsApplication2.Properties.Resources.Lighthouse;
            this.pictureBox14.InitialImage = null;
            this.pictureBox14.Location = new System.Drawing.Point(241, 150);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 80);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::WindowsFormsApplication2.Properties.Resources.Koala;
            this.pictureBox15.InitialImage = null;
            this.pictureBox15.Location = new System.Drawing.Point(317, 150);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(50, 80);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 12;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApplication2.Properties.Resources.Tulips;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(97, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 80);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApplication2.Properties.Resources.Hydrangeas;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(170, 249);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 80);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApplication2.Properties.Resources.Desert;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(241, 249);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 80);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApplication2.Properties.Resources.Jellyfish;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(317, 249);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 80);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApplication2.Properties.Resources.Hydrangeas;
            this.pictureBox11.InitialImage = null;
            this.pictureBox11.Location = new System.Drawing.Point(97, 150);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 80);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 7;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApplication2.Properties.Resources.Chrysanthemum;
            this.pictureBox12.InitialImage = null;
            this.pictureBox12.Location = new System.Drawing.Point(20, 249);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 80);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 6;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApplication2.Properties.Resources.Lighthouse;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(97, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApplication2.Properties.Resources.Penguins;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(170, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication2.Properties.Resources.Koala;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(241, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.Chrysanthemum;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(317, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.Tulips;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(20, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Desert;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(20, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 710);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "戰鬥";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.37209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.62791F));
            this.tableLayoutPanel1.Controls.Add(this.L_act, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_mp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_def, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_demo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_actrate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_level, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_hp, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 444);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.31788F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.68212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 300);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // L_act
            // 
            this.L_act.AutoSize = true;
            this.L_act.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_act.Location = new System.Drawing.Point(3, 151);
            this.L_act.Name = "L_act";
            this.L_act.Size = new System.Drawing.Size(82, 24);
            this.L_act.TabIndex = 14;
            this.L_act.Text = "攻擊力";
            // 
            // L_actrate
            // 
            this.L_actrate.AutoSize = true;
            this.L_actrate.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_actrate.Location = new System.Drawing.Point(3, 224);
            this.L_actrate.Name = "L_actrate";
            this.L_actrate.Size = new System.Drawing.Size(106, 24);
            this.L_actrate.TabIndex = 13;
            this.L_actrate.Text = "發動機率";
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_name.Location = new System.Drawing.Point(3, 0);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(58, 24);
            this.L_name.TabIndex = 8;
            this.L_name.Text = "名稱";
            this.L_name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // L_mp
            // 
            this.L_mp.AutoSize = true;
            this.L_mp.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_mp.Location = new System.Drawing.Point(269, 0);
            this.L_mp.Name = "L_mp";
            this.L_mp.Size = new System.Drawing.Size(43, 24);
            this.L_mp.TabIndex = 11;
            this.L_mp.Text = "MP";
            // 
            // L_level
            // 
            this.L_level.AutoSize = true;
            this.L_level.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_level.Location = new System.Drawing.Point(3, 79);
            this.L_level.Name = "L_level";
            this.L_level.Size = new System.Drawing.Size(58, 24);
            this.L_level.TabIndex = 10;
            this.L_level.Text = "等級";
            // 
            // L_def
            // 
            this.L_def.AutoSize = true;
            this.L_def.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_def.Location = new System.Drawing.Point(269, 151);
            this.L_def.Name = "L_def";
            this.L_def.Size = new System.Drawing.Size(82, 24);
            this.L_def.TabIndex = 15;
            this.L_def.Text = "防禦力";
            // 
            // L_demo
            // 
            this.L_demo.AutoSize = true;
            this.L_demo.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_demo.Location = new System.Drawing.Point(269, 224);
            this.L_demo.Name = "L_demo";
            this.L_demo.Size = new System.Drawing.Size(106, 24);
            this.L_demo.TabIndex = 12;
            this.L_demo.Text = "技能說明";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L_team2);
            this.panel1.Controls.Add(this.L_team1);
            this.panel1.Location = new System.Drawing.Point(467, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 400);
            this.panel1.TabIndex = 18;
            // 
            // L_team2
            // 
            this.L_team2.AutoSize = true;
            this.L_team2.Font = new System.Drawing.Font("新細明體", 16F);
            this.L_team2.Location = new System.Drawing.Point(14, 221);
            this.L_team2.Name = "L_team2";
            this.L_team2.Size = new System.Drawing.Size(73, 22);
            this.L_team2.TabIndex = 1;
            this.L_team2.Text = "Team 2";
            // 
            // L_team1
            // 
            this.L_team1.AutoSize = true;
            this.L_team1.Font = new System.Drawing.Font("新細明體", 16F);
            this.L_team1.Location = new System.Drawing.Point(14, 18);
            this.L_team1.Name = "L_team1";
            this.L_team1.Size = new System.Drawing.Size(73, 22);
            this.L_team1.TabIndex = 0;
            this.L_team1.Text = "Team 1";
            this.L_team1.Click += new System.EventHandler(this.label9_Click);
            // 
            // L_hp
            // 
            this.L_hp.AutoSize = true;
            this.L_hp.Font = new System.Drawing.Font("新細明體", 18F);
            this.L_hp.Location = new System.Drawing.Point(269, 79);
            this.L_hp.Name = "L_hp";
            this.L_hp.Size = new System.Drawing.Size(39, 24);
            this.L_hp.TabIndex = 16;
            this.L_hp.Text = "HP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.L_cardgroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.L_cardgroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox L_cardgroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.Label L_act;
        private System.Windows.Forms.Label L_demo;
        private System.Windows.Forms.Label L_level;
        private System.Windows.Forms.Label L_def;
        private System.Windows.Forms.Label L_actrate;
        private System.Windows.Forms.Label L_mp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label L_team2;
        private System.Windows.Forms.Label L_team1;
        private VScrollBar vScrollBar1;
        private Label L_hp;


    }
}

