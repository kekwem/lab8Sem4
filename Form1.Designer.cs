
namespace Taski
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.szukajPierwszeButton = new System.Windows.Forms.Button();
            this.zakresTextBox = new System.Windows.Forms.TextBox();
            this.szukajPierwButton = new System.Windows.Forms.Button();
            this.labelinfo2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(12, 29);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstTextBox.TabIndex = 0;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(118, 29);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondTextBox.TabIndex = 1;
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(9, 104);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(0, 17);
            this.labelinfo.TabIndex = 2;
            // 
            // szukajPierwszeButton
            // 
            this.szukajPierwszeButton.Location = new System.Drawing.Point(12, 57);
            this.szukajPierwszeButton.Name = "szukajPierwszeButton";
            this.szukajPierwszeButton.Size = new System.Drawing.Size(100, 23);
            this.szukajPierwszeButton.TabIndex = 3;
            this.szukajPierwszeButton.Text = "szkajPierwszeButton";
            this.szukajPierwszeButton.UseVisualStyleBackColor = true;
            this.szukajPierwszeButton.Click += new System.EventHandler(this.szukajPierwszeButton_Click);
            // 
            // zakresTextBox
            // 
            this.zakresTextBox.Location = new System.Drawing.Point(318, 29);
            this.zakresTextBox.Name = "zakresTextBox";
            this.zakresTextBox.Size = new System.Drawing.Size(100, 22);
            this.zakresTextBox.TabIndex = 4;
            // 
            // szukajPierwButton
            // 
            this.szukajPierwButton.Location = new System.Drawing.Point(318, 57);
            this.szukajPierwButton.Name = "szukajPierwButton";
            this.szukajPierwButton.Size = new System.Drawing.Size(100, 23);
            this.szukajPierwButton.TabIndex = 5;
            this.szukajPierwButton.Text = "szukaj";
            this.szukajPierwButton.UseVisualStyleBackColor = true;
            this.szukajPierwButton.Click += new System.EventHandler(this.szukajPierwButton_Click);
            // 
            // labelinfo2
            // 
            this.labelinfo2.AutoSize = true;
            this.labelinfo2.Location = new System.Drawing.Point(12, 201);
            this.labelinfo2.Name = "labelinfo2";
            this.labelinfo2.Size = new System.Drawing.Size(0, 17);
            this.labelinfo2.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 153);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(406, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Liczba podzakresow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelinfo2);
            this.Controls.Add(this.szukajPierwButton);
            this.Controls.Add(this.zakresTextBox);
            this.Controls.Add(this.szukajPierwszeButton);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Name = "Form1";
            this.Text = "Taski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Button szukajPierwszeButton;
        private System.Windows.Forms.TextBox zakresTextBox;
        private System.Windows.Forms.Button szukajPierwButton;
        private System.Windows.Forms.Label labelinfo2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

