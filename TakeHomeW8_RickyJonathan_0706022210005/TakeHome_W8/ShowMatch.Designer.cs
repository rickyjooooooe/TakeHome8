namespace TakeHome_W8
{
    partial class ShowMatch
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
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_home = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_match = new System.Windows.Forms.ComboBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.label_away = new System.Windows.Forms.Label();
            this.dtgrid_away = new System.Windows.Forms.DataGridView();
            this.dtgrid_detail = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_team
            // 
            this.cmb_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(42, 69);
            this.cmb_team.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(158, 28);
            this.cmb_team.TabIndex = 0;
            this.cmb_team.SelectedIndexChanged += new System.EventHandler(this.cmb_team_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Team";
            // 
            // dtgrid_home
            // 
            this.dtgrid_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_home.Location = new System.Drawing.Point(233, 43);
            this.dtgrid_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgrid_home.Name = "dtgrid_home";
            this.dtgrid_home.RowHeadersWidth = 62;
            this.dtgrid_home.Size = new System.Drawing.Size(507, 203);
            this.dtgrid_home.TabIndex = 2;
            this.dtgrid_home.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date";
            // 
            // cmb_match
            // 
            this.cmb_match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_match.FormattingEnabled = true;
            this.cmb_match.Location = new System.Drawing.Point(47, 164);
            this.cmb_match.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_match.Name = "cmb_match";
            this.cmb_match.Size = new System.Drawing.Size(158, 28);
            this.cmb_match.TabIndex = 4;
            this.cmb_match.SelectedIndexChanged += new System.EventHandler(this.cmb_match_SelectedIndexChanged);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(47, 227);
            this.btn_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(92, 35);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Search";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Home Team";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Away Team";
            this.label4.Visible = false;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Location = new System.Drawing.Point(349, 17);
            this.label_home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(14, 20);
            this.label_home.TabIndex = 8;
            this.label_home.Text = "-";
            this.label_home.Visible = false;
            // 
            // label_away
            // 
            this.label_away.AutoSize = true;
            this.label_away.Location = new System.Drawing.Point(349, 265);
            this.label_away.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_away.Name = "label_away";
            this.label_away.Size = new System.Drawing.Size(14, 20);
            this.label_away.TabIndex = 9;
            this.label_away.Text = "-";
            this.label_away.Visible = false;
            // 
            // dtgrid_away
            // 
            this.dtgrid_away.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_away.Location = new System.Drawing.Point(233, 289);
            this.dtgrid_away.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgrid_away.Name = "dtgrid_away";
            this.dtgrid_away.RowHeadersWidth = 62;
            this.dtgrid_away.Size = new System.Drawing.Size(507, 203);
            this.dtgrid_away.TabIndex = 10;
            this.dtgrid_away.Visible = false;
            // 
            // dtgrid_detail
            // 
            this.dtgrid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_detail.Location = new System.Drawing.Point(767, 43);
            this.dtgrid_detail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgrid_detail.Name = "dtgrid_detail";
            this.dtgrid_detail.RowHeadersWidth = 62;
            this.dtgrid_detail.Size = new System.Drawing.Size(639, 449);
            this.dtgrid_detail.TabIndex = 11;
            this.dtgrid_detail.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Details";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(602, 82);
            this.label6.TabIndex = 24;
            this.label6.Text = "Premiere League";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 64);
            this.label7.TabIndex = 25;
            this.label7.Text = "More than a league";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::TakeHome_W8.Properties.Resources.premiere;
            this.pictureBox1.Location = new System.Drawing.Point(851, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ShowMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgrid_detail);
            this.Controls.Add(this.dtgrid_away);
            this.Controls.Add(this.label_away);
            this.Controls.Add(this.label_home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.cmb_match);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrid_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_team);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowMatch";
            this.Text = "ShowMatch";
            this.Load += new System.EventHandler(this.ShowMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_match;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label_away;
        private System.Windows.Forms.DataGridView dtgrid_away;
        private System.Windows.Forms.DataGridView dtgrid_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}