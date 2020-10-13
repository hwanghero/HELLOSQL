namespace HELLOSQL
{
    partial class Settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.port_text = new System.Windows.Forms.TextBox();
            this.service_text = new System.Windows.Forms.TextBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.save_box = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.address_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.port_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.service_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.id_text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.join_btn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.save_box, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pw_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "주소";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "포트";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "서비스이름";
            // 
            // address_text
            // 
            this.address_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address_text.Location = new System.Drawing.Point(108, 6);
            this.address_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(114, 25);
            this.address_text.TabIndex = 1;
            // 
            // port_text
            // 
            this.port_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.port_text.Location = new System.Drawing.Point(108, 44);
            this.port_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(114, 25);
            this.port_text.TabIndex = 1;
            // 
            // service_text
            // 
            this.service_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.service_text.Location = new System.Drawing.Point(108, 82);
            this.service_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.service_text.Name = "service_text";
            this.service_text.Size = new System.Drawing.Size(114, 25);
            this.service_text.TabIndex = 1;
            // 
            // join_btn
            // 
            this.join_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.join_btn.Location = new System.Drawing.Point(108, 204);
            this.join_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(114, 29);
            this.join_btn.TabIndex = 1;
            this.join_btn.Text = "접속";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // save_box
            // 
            this.save_box.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.save_box.AutoSize = true;
            this.save_box.Location = new System.Drawing.Point(43, 209);
            this.save_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_box.Name = "save_box";
            this.save_box.Size = new System.Drawing.Size(59, 19);
            this.save_box.TabIndex = 2;
            this.save_box.Text = "저장";
            this.save_box.UseVisualStyleBackColor = true;
            this.save_box.CheckedChanged += new System.EventHandler(this.save_box_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "아이디";
            // 
            // id_text
            // 
            this.id_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.id_text.Location = new System.Drawing.Point(108, 120);
            this.id_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(114, 25);
            this.id_text.TabIndex = 1;
            // 
            // pw_text
            // 
            this.pw_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pw_text.Location = new System.Drawing.Point(108, 156);
            this.pw_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pw_text.Name = "pw_text";
            this.pw_text.Size = new System.Drawing.Size(114, 25);
            this.pw_text.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "비밀번호";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB설정";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox port_text;
        private System.Windows.Forms.TextBox service_text;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.CheckBox save_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Label label5;
    }
}