
namespace palyazat
{
    partial class ujPalyRog
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_aKat = new System.Windows.Forms.Label();
            this.lbl_cKat = new System.Windows.Forms.Label();
            this.tb_aKat = new System.Windows.Forms.TextBox();
            this.tb_cKat = new System.Windows.Forms.TextBox();
            this.btn_ujPaly = new System.Windows.Forms.Button();
            this.lbl_huf = new System.Windows.Forms.Label();
            this.lbl_huf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(40, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(31, 20);
            this.tb_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(13, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_aKat
            // 
            this.lbl_aKat.AutoSize = true;
            this.lbl_aKat.Location = new System.Drawing.Point(13, 64);
            this.lbl_aKat.Name = "lbl_aKat";
            this.lbl_aKat.Size = new System.Drawing.Size(125, 13);
            this.lbl_aKat.TabIndex = 2;
            this.lbl_aKat.Text = "\"A\" kategória értékkeret:";
            // 
            // lbl_cKat
            // 
            this.lbl_cKat.AutoSize = true;
            this.lbl_cKat.Location = new System.Drawing.Point(13, 117);
            this.lbl_cKat.Name = "lbl_cKat";
            this.lbl_cKat.Size = new System.Drawing.Size(122, 13);
            this.lbl_cKat.TabIndex = 3;
            this.lbl_cKat.Text = "\"C\" kategória értékkeret";
            // 
            // tb_aKat
            // 
            this.tb_aKat.Location = new System.Drawing.Point(16, 91);
            this.tb_aKat.Name = "tb_aKat";
            this.tb_aKat.Size = new System.Drawing.Size(191, 20);
            this.tb_aKat.TabIndex = 4;
            // 
            // tb_cKat
            // 
            this.tb_cKat.Location = new System.Drawing.Point(16, 133);
            this.tb_cKat.Name = "tb_cKat";
            this.tb_cKat.Size = new System.Drawing.Size(191, 20);
            this.tb_cKat.TabIndex = 5;
            // 
            // btn_ujPaly
            // 
            this.btn_ujPaly.Location = new System.Drawing.Point(12, 159);
            this.btn_ujPaly.Name = "btn_ujPaly";
            this.btn_ujPaly.Size = new System.Drawing.Size(195, 55);
            this.btn_ujPaly.TabIndex = 6;
            this.btn_ujPaly.Text = "Új pályázat hirdetése";
            this.btn_ujPaly.UseVisualStyleBackColor = true;
            this.btn_ujPaly.Click += new System.EventHandler(this.btn_ujPaly_Click);
            // 
            // lbl_huf
            // 
            this.lbl_huf.AutoSize = true;
            this.lbl_huf.Location = new System.Drawing.Point(213, 94);
            this.lbl_huf.Name = "lbl_huf";
            this.lbl_huf.Size = new System.Drawing.Size(29, 13);
            this.lbl_huf.TabIndex = 7;
            this.lbl_huf.Text = "HUF";
            // 
            // lbl_huf2
            // 
            this.lbl_huf2.AutoSize = true;
            this.lbl_huf2.Location = new System.Drawing.Point(213, 136);
            this.lbl_huf2.Name = "lbl_huf2";
            this.lbl_huf2.Size = new System.Drawing.Size(29, 13);
            this.lbl_huf2.TabIndex = 8;
            this.lbl_huf2.Text = "HUF";
            // 
            // ujPalyRog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 224);
            this.Controls.Add(this.lbl_huf2);
            this.Controls.Add(this.lbl_huf);
            this.Controls.Add(this.btn_ujPaly);
            this.Controls.Add(this.tb_cKat);
            this.Controls.Add(this.tb_aKat);
            this.Controls.Add(this.lbl_cKat);
            this.Controls.Add(this.lbl_aKat);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.tb_id);
            this.Name = "ujPalyRog";
            this.Text = "ujPalyRog";
            this.Load += new System.EventHandler(this.ujPalyRog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_aKat;
        private System.Windows.Forms.Label lbl_cKat;
        private System.Windows.Forms.TextBox tb_aKat;
        private System.Windows.Forms.TextBox tb_cKat;
        private System.Windows.Forms.Button btn_ujPaly;
        private System.Windows.Forms.Label lbl_huf;
        private System.Windows.Forms.Label lbl_huf2;
    }
}