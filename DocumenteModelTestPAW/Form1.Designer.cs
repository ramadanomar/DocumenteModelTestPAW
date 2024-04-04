namespace DocumenteModelTestPAW
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTiltu = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cod,
            this.titlu,
            this.data});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cod
            // 
            this.cod.Text = "cod";
            this.cod.Width = 203;
            // 
            // titlu
            // 
            this.titlu.Text = "titlu";
            this.titlu.Width = 288;
            // 
            // data
            // 
            this.data.Text = "data";
            this.data.Width = 378;
            // 
            // textBoxTiltu
            // 
            this.textBoxTiltu.Location = new System.Drawing.Point(129, 35);
            this.textBoxTiltu.Name = "textBoxTiltu";
            this.textBoxTiltu.Size = new System.Drawing.Size(100, 20);
            this.textBoxTiltu.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 19);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(126, 19);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(28, 13);
            this.labelTitlu.TabIndex = 4;
            this.labelTitlu.Text = "Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(15, 36);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(328, 33);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxTiltu);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cod;
        private System.Windows.Forms.ColumnHeader titlu;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.TextBox textBoxTiltu;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonRemove;
    }
}

