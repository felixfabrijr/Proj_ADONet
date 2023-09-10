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
            btnListarSqlServer = new Button();
            btnListarMySql = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnListarSqlServerDataSet = new Button();
            btnListarMySqlDataSet = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnConnMySql
            // 
            btnConnMySql.Location = new Point(34, 48);
            btnConnMySql.Name = "btnConnMySql";
            btnConnMySql.Size = new Size(291, 65);
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
            btnConnectionSqlServer.Location = new Point(384, 48);
            btnConnectionSqlServer.Name = "btnConnectionSqlServer";
            btnConnectionSqlServer.Size = new Size(291, 65);
            btnConnectionSqlServer.TabIndex = 2;
            btnConnectionSqlServer.Text = "Conexao Sql Server";
            btnConnectionSqlServer.UseVisualStyleBackColor = true;
            btnConnectionSqlServer.Click += btnConnectionSqlServer_Click;
            // 
            // btnListarSqlServer
            // 
            btnListarSqlServer.Location = new Point(384, 119);
            btnListarSqlServer.Name = "btnListarSqlServer";
            btnListarSqlServer.Size = new Size(291, 65);
            btnListarSqlServer.TabIndex = 4;
            btnListarSqlServer.Text = "Listar Sql Server [DataReader]";
            btnListarSqlServer.UseVisualStyleBackColor = true;
            btnListarSqlServer.Click += btnListarSqlServer_Click;
            // 
            // btnListarMySql
            // 
            btnListarMySql.Location = new Point(34, 119);
            btnListarMySql.Name = "btnListarMySql";
            btnListarMySql.Size = new Size(291, 65);
            btnListarMySql.TabIndex = 3;
            btnListarMySql.Text = "Listar MySql [DataReader]";
            btnListarMySql.UseVisualStyleBackColor = true;
            btnListarMySql.Click += btnListarMySql_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(34, 190);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(291, 254);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(384, 191);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(291, 254);
            listBox2.TabIndex = 6;
            // 
            // btnListarSqlServerDataSet
            // 
            btnListarSqlServerDataSet.Location = new Point(1064, 119);
            btnListarSqlServerDataSet.Name = "btnListarSqlServerDataSet";
            btnListarSqlServerDataSet.Size = new Size(291, 65);
            btnListarSqlServerDataSet.TabIndex = 8;
            btnListarSqlServerDataSet.Text = "Listar Sql Server [DataSet]";
            btnListarSqlServerDataSet.UseVisualStyleBackColor = true;
            btnListarSqlServerDataSet.Click += btnListarSqlServerDataSet_Click;
            // 
            // btnListarMySqlDataSet
            // 
            btnListarMySqlDataSet.Location = new Point(714, 119);
            btnListarMySqlDataSet.Name = "btnListarMySqlDataSet";
            btnListarMySqlDataSet.Size = new Size(291, 65);
            btnListarMySqlDataSet.TabIndex = 7;
            btnListarMySqlDataSet.Text = "Listar MySql [DataSet]";
            btnListarMySqlDataSet.UseVisualStyleBackColor = true;
            btnListarMySqlDataSet.Click += btnListarMySqlDataSet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(714, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(291, 253);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1064, 191);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(291, 253);
            dataGridView2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 558);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnListarSqlServerDataSet);
            Controls.Add(btnListarMySqlDataSet);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnListarSqlServer);
            Controls.Add(btnListarMySql);
            Controls.Add(btnConnectionSqlServer);
            Controls.Add(label1);
            Controls.Add(btnConnMySql);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnConnMySql;
        private Label label1;
        private Button btnConnectionSqlServer;
        private Button btnListarSqlServer;
        private Button btnListarMySql;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnListarSqlServerDataSet;
        private Button btnListarMySqlDataSet;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}