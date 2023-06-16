namespace zadanie2_shvets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillTableButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.findForNameButton = new System.Windows.Forms.Button();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.phoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(545, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "ФИО";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "phoneNumber";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // fillTableButton
            // 
            this.fillTableButton.Location = new System.Drawing.Point(684, 255);
            this.fillTableButton.Name = "fillTableButton";
            this.fillTableButton.Size = new System.Drawing.Size(148, 59);
            this.fillTableButton.TabIndex = 1;
            this.fillTableButton.Text = "Заполнить таблицу";
            this.fillTableButton.UseVisualStyleBackColor = true;
            this.fillTableButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // findForNameButton
            // 
            this.findForNameButton.Location = new System.Drawing.Point(109, 82);
            this.findForNameButton.Name = "findForNameButton";
            this.findForNameButton.Size = new System.Drawing.Size(123, 58);
            this.findForNameButton.TabIndex = 3;
            this.findForNameButton.Text = "Найти по имени";
            this.findForNameButton.UseVisualStyleBackColor = true;
            this.findForNameButton.Click += new System.EventHandler(this.findForNameButton_Click);
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(117, 287);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.addNameTextBox.TabIndex = 4;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(117, 356);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 26);
            this.numberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите имя человека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите номер человека";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(117, 398);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(115, 56);
            this.addPersonButton.TabIndex = 8;
            this.addPersonButton.Text = "Добавить человека";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1435, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(374, 73);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(138, 76);
            this.deleteUserButton.TabIndex = 10;
            this.deleteUserButton.Text = "Удалить выбранную строчку";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(730, 329);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(102, 53);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Экспортировать таблицу";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 639);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.findForNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.fillTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.Button fillTableButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button findForNameButton;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button exportButton;
    }
}

