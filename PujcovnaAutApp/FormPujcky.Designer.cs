namespace PujcovnaAutApp
{
    partial class FormPujcky
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
            this.dgvPujcky = new System.Windows.Forms.DataGridView();
            this.btnObnovit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.txtVyhledat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVyhledatAuto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujcky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPujcky
            // 
            this.dgvPujcky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPujcky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPujcky.Location = new System.Drawing.Point(12, 12);
            this.dgvPujcky.Name = "dgvPujcky";
            this.dgvPujcky.Size = new System.Drawing.Size(526, 150);
            this.dgvPujcky.TabIndex = 0;
            // 
            // btnObnovit
            // 
            this.btnObnovit.BackColor = System.Drawing.Color.Peru;
            this.btnObnovit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObnovit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObnovit.Location = new System.Drawing.Point(12, 190);
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.Size = new System.Drawing.Size(159, 37);
            this.btnObnovit.TabIndex = 23;
            this.btnObnovit.Text = "Obnovit seznam";
            this.btnObnovit.UseVisualStyleBackColor = false;
            this.btnObnovit.Click += new System.EventHandler(this.btnObnovit_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSmazat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmazat.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmazat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmazat.Location = new System.Drawing.Point(177, 190);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(140, 37);
            this.btnSmazat.TabIndex = 24;
            this.btnSmazat.Text = "Smazat záznam";
            this.btnSmazat.UseVisualStyleBackColor = false;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // txtVyhledat
            // 
            this.txtVyhledat.Location = new System.Drawing.Point(12, 266);
            this.txtVyhledat.Name = "txtVyhledat";
            this.txtVyhledat.Size = new System.Drawing.Size(159, 20);
            this.txtVyhledat.TabIndex = 25;
            this.txtVyhledat.TextChanged += new System.EventHandler(this.txtVyhledat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vyhledat podle jména";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Vyhledat podle vozidla";
            // 
            // txtVyhledatAuto
            // 
            this.txtVyhledatAuto.Location = new System.Drawing.Point(177, 266);
            this.txtVyhledatAuto.Name = "txtVyhledatAuto";
            this.txtVyhledatAuto.Size = new System.Drawing.Size(159, 20);
            this.txtVyhledatAuto.TabIndex = 27;
            // 
            // FormPujcky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVyhledatAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVyhledat);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnObnovit);
            this.Controls.Add(this.dgvPujcky);
            this.Name = "FormPujcky";
            this.Text = "FormPujcky";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujcky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPujcky;
        private System.Windows.Forms.Button btnObnovit;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.TextBox txtVyhledat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVyhledatAuto;
    }
}