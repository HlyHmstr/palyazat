
namespace palyazat
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btn_ujPalyazat = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzamlakSzama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzamlakOsszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.keretosszeg,
            this.SzamlakSzama,
            this.SzamlakOsszege});
            this.dgvMain.Location = new System.Drawing.Point(12, 12);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(570, 260);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ujPalyazat
            // 
            this.btn_ujPalyazat.BackColor = System.Drawing.Color.Green;
            this.btn_ujPalyazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujPalyazat.ForeColor = System.Drawing.Color.White;
            this.btn_ujPalyazat.Location = new System.Drawing.Point(14, 278);
            this.btn_ujPalyazat.Name = "btn_ujPalyazat";
            this.btn_ujPalyazat.Size = new System.Drawing.Size(285, 55);
            this.btn_ujPalyazat.TabIndex = 1;
            this.btn_ujPalyazat.Text = "Új pályázat";
            this.btn_ujPalyazat.UseVisualStyleBackColor = false;
            this.btn_ujPalyazat.Click += new System.EventHandler(this.btn_ujPalyazat_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.BackColor = System.Drawing.Color.DarkRed;
            this.btn_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.ForeColor = System.Drawing.Color.White;
            this.btn_kilep.Location = new System.Drawing.Point(305, 278);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(277, 54);
            this.btn_kilep.TabIndex = 2;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = false;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 20F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // keretosszeg
            // 
            this.keretosszeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keretosszeg.HeaderText = "Keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // SzamlakSzama
            // 
            this.SzamlakSzama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SzamlakSzama.HeaderText = "Számlák Száma";
            this.SzamlakSzama.Name = "SzamlakSzama";
            // 
            // SzamlakOsszege
            // 
            this.SzamlakOsszege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SzamlakOsszege.HeaderText = "Számlák Összege";
            this.SzamlakOsszege.Name = "SzamlakOsszege";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 341);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_ujPalyazat);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.Text = "Pályázatok állapota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btn_ujPalyazat;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzamlakSzama;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzamlakOsszege;
    }
}

