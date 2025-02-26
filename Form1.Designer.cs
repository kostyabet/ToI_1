namespace ToI_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colUpButton = new System.Windows.Forms.Button();
            this.vizenerGeneratedButton = new System.Windows.Forms.Button();
            this.shifrButton = new System.Windows.Forms.Button();
            this.deshifrButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.methodNameLabel = new System.Windows.Forms.Label();
            this.langLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.plaintTextBox = new System.Windows.Forms.TextBox();
            this.plainFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ciperTextBox = new System.Windows.Forms.TextBox();
            this.cipherFileButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // colUpButton
            // 
            this.colUpButton.Location = new System.Drawing.Point(0, 0);
            this.colUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.colUpButton.Name = "colUpButton";
            this.colUpButton.Size = new System.Drawing.Size(400, 40);
            this.colUpButton.TabIndex = 0;
            this.colUpButton.Text = "Столбцовый улучшеный метод";
            this.colUpButton.UseVisualStyleBackColor = true;
            this.colUpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // vizenerGeneratedButton
            // 
            this.vizenerGeneratedButton.Location = new System.Drawing.Point(400, 0);
            this.vizenerGeneratedButton.Margin = new System.Windows.Forms.Padding(0);
            this.vizenerGeneratedButton.Name = "vizenerGeneratedButton";
            this.vizenerGeneratedButton.Size = new System.Drawing.Size(400, 40);
            this.vizenerGeneratedButton.TabIndex = 1;
            this.vizenerGeneratedButton.Text = "Виженер, самогенерирующийся ключ";
            this.vizenerGeneratedButton.UseVisualStyleBackColor = true;
            this.vizenerGeneratedButton.Click += new System.EventHandler(this.vizenerGeneratedButton_Click);
            // 
            // shifrButton
            // 
            this.shifrButton.Location = new System.Drawing.Point(12, 279);
            this.shifrButton.Name = "shifrButton";
            this.shifrButton.Size = new System.Drawing.Size(350, 30);
            this.shifrButton.TabIndex = 2;
            this.shifrButton.Text = "Шифрование";
            this.shifrButton.UseVisualStyleBackColor = true;
            this.shifrButton.Click += new System.EventHandler(this.shifrButton_Click);
            // 
            // deshifrButton
            // 
            this.deshifrButton.Location = new System.Drawing.Point(438, 279);
            this.deshifrButton.Name = "deshifrButton";
            this.deshifrButton.Size = new System.Drawing.Size(350, 30);
            this.deshifrButton.TabIndex = 3;
            this.deshifrButton.Text = "Дешифрование";
            this.deshifrButton.UseVisualStyleBackColor = true;
            this.deshifrButton.Click += new System.EventHandler(this.deshifrButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabel.Location = new System.Drawing.Point(19, 115);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(10);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(196, 18);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Введите ключ для работы:";
            // 
            // methodNameLabel
            // 
            this.methodNameLabel.AutoSize = true;
            this.methodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodNameLabel.Location = new System.Drawing.Point(255, 60);
            this.methodNameLabel.Name = "methodNameLabel";
            this.methodNameLabel.Size = new System.Drawing.Size(0, 20);
            this.methodNameLabel.TabIndex = 5;
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(731, 118);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(38, 13);
            this.langLabel.TabIndex = 6;
            this.langLabel.Text = "Язык:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyTextBox.Location = new System.Drawing.Point(217, 113);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(497, 23);
            this.keyTextBox.TabIndex = 7;
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainTextLabel.Location = new System.Drawing.Point(31, 171);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(184, 18);
            this.plainTextLabel.TabIndex = 8;
            this.plainTextLabel.Text = "Введите исходный текст:";
            // 
            // plaintTextBox
            // 
            this.plaintTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plaintTextBox.Location = new System.Drawing.Point(217, 170);
            this.plaintTextBox.Name = "plaintTextBox";
            this.plaintTextBox.Size = new System.Drawing.Size(497, 23);
            this.plaintTextBox.TabIndex = 9;
            // 
            // plainFileButton
            // 
            this.plainFileButton.Location = new System.Drawing.Point(720, 170);
            this.plainFileButton.Name = "plainFileButton";
            this.plainFileButton.Size = new System.Drawing.Size(75, 23);
            this.plainFileButton.TabIndex = 10;
            this.plainFileButton.Text = "из файла";
            this.plainFileButton.UseVisualStyleBackColor = true;
            this.plainFileButton.Click += new System.EventHandler(this.plainFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Конечный текст:";
            // 
            // ciperTextBox
            // 
            this.ciperTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ciperTextBox.Location = new System.Drawing.Point(217, 221);
            this.ciperTextBox.Name = "ciperTextBox";
            this.ciperTextBox.ReadOnly = true;
            this.ciperTextBox.Size = new System.Drawing.Size(497, 23);
            this.ciperTextBox.TabIndex = 12;
            // 
            // cipherFileButton
            // 
            this.cipherFileButton.Location = new System.Drawing.Point(720, 221);
            this.cipherFileButton.Name = "cipherFileButton";
            this.cipherFileButton.Size = new System.Drawing.Size(75, 23);
            this.cipherFileButton.TabIndex = 13;
            this.cipherFileButton.Text = "в файл";
            this.cipherFileButton.UseVisualStyleBackColor = true;
            this.cipherFileButton.Click += new System.EventHandler(this.cipherFileButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(572, 250);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(223, 23);
            this.infoButton.TabIndex = 14;
            this.infoButton.Text = "Посмотреть этапы работы алгоритма";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.cipherFileButton);
            this.Controls.Add(this.ciperTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainFileButton);
            this.Controls.Add(this.plaintTextBox);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.methodNameLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.deshifrButton);
            this.Controls.Add(this.shifrButton);
            this.Controls.Add(this.vizenerGeneratedButton);
            this.Controls.Add(this.colUpButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТИ, лаб. раб. 1, Вариант 5, Бетеня К.С.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colUpButton;
        private System.Windows.Forms.Button vizenerGeneratedButton;
        private System.Windows.Forms.Button shifrButton;
        private System.Windows.Forms.Button deshifrButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label methodNameLabel;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.TextBox plaintTextBox;
        private System.Windows.Forms.Button plainFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ciperTextBox;
        private System.Windows.Forms.Button cipherFileButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}