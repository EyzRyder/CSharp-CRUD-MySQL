
namespace DataBaseHomework
{
    partial class DBCShape
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBCShape));
            this.txtBoxfrstNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLstNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxfrstNm
            // 
            this.txtBoxfrstNm.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxfrstNm.Location = new System.Drawing.Point(12, 42);
            this.txtBoxfrstNm.Name = "txtBoxfrstNm";
            this.txtBoxfrstNm.Size = new System.Drawing.Size(183, 20);
            this.txtBoxfrstNm.TabIndex = 0;
            this.txtBoxfrstNm.TextChanged += new System.EventHandler(this.txtBoxfrstNm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtBoxLstNm
            // 
            this.txtBoxLstNm.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxLstNm.Location = new System.Drawing.Point(12, 112);
            this.txtBoxLstNm.Name = "txtBoxLstNm";
            this.txtBoxLstNm.Size = new System.Drawing.Size(183, 20);
            this.txtBoxLstNm.TabIndex = 2;
            this.txtBoxLstNm.TextChanged += new System.EventHandler(this.txtBoxLstNm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // txtBoxDress
            // 
            this.txtBoxDress.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxDress.Location = new System.Drawing.Point(12, 180);
            this.txtBoxDress.Name = "txtBoxDress";
            this.txtBoxDress.Size = new System.Drawing.Size(183, 20);
            this.txtBoxDress.TabIndex = 4;
            this.txtBoxDress.TextChanged += new System.EventHandler(this.txtBoxDress_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegister.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(58, 239);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 41);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register User";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateUser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(174, 239);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(136, 41);
            this.btnUpdateUser.TabIndex = 7;
            this.btnUpdateUser.Text = "Update user list";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(216, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 197);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "first name";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "last name";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "address";
            this.columnHeader4.Width = 80;
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelet.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(419, 239);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(100, 41);
            this.btnDelet.TabIndex = 9;
            this.btnDelet.Text = "Delete user";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(316, 239);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(97, 41);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar User";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // DBCShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(565, 312);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLstNm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxfrstNm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBCShape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DBCShape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxfrstNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLstNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnListar;
    }
}

