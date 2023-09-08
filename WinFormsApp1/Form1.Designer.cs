namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            btnConnMySql = new Button();
            label1 = new Label();
            btnConnectionSqlServer = new Button();
            SuspendLayout();
            // 
            // btnConnMySql
            // 
            btnConnMySql.Location = new Point(34, 81);
            btnConnMySql.Name = "btnConnMySql";
            btnConnMySql.Size = new Size(154, 65);
            btnConnMySql.TabIndex = 0;
            btnConnMySql.Text = "Conexao MySql";
            btnConnMySql.UseVisualStyleBackColor = true;
            btnConnMySql.Click += btnConnMySql_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "ADO.NET";
            label1.Click += label1_Click;
            // 
            // btnConnectionSqlServer
            // 
            btnConnectionSqlServer.Location = new Point(221, 81);
            btnConnectionSqlServer.Name = "btnConnectionSqlServer";
            btnConnectionSqlServer.Size = new Size(154, 65);
            btnConnectionSqlServer.TabIndex = 2;
            btnConnectionSqlServer.Text = "Conexao Sql Server";
            btnConnectionSqlServer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnectionSqlServer);
            Controls.Add(label1);
            Controls.Add(btnConnMySql);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnMySql;
        private Label label1;
        private Button btnConnectionSqlServer;
    }
}