
namespace task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.notSortBox = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sortP = new System.Windows.Forms.Panel();
            this.notSortLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.startP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.border1 = new System.Windows.Forms.TextBox();
            this.border2 = new System.Windows.Forms.TextBox();
            this.ctrl = new System.Windows.Forms.ListBox();
            this.shaker = new System.Windows.Forms.ListBox();
            this.bubbleT = new System.Windows.Forms.Label();
            this.bubbleP = new System.Windows.Forms.Label();
            this.bubbleS = new System.Windows.Forms.Label();
            this.ctrlS = new System.Windows.Forms.Label();
            this.ctrlP = new System.Windows.Forms.Label();
            this.ctrlT = new System.Windows.Forms.Label();
            this.shakerS = new System.Windows.Forms.Label();
            this.shakerP = new System.Windows.Forms.Label();
            this.shakerT = new System.Windows.Forms.Label();
            this.bubbleB = new System.Windows.Forms.ListBox();
            this.sortP.SuspendLayout();
            this.startP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер массива";
            // 
            // notSortBox
            // 
            this.notSortBox.FormattingEnabled = true;
            this.notSortBox.Location = new System.Drawing.Point(12, 64);
            this.notSortBox.Name = "notSortBox";
            this.notSortBox.Size = new System.Drawing.Size(140, 277);
            this.notSortBox.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(507, 118);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(134, 20);
            this.inputBox.TabIndex = 3;
            // 
            // sortP
            // 
            this.sortP.Controls.Add(this.bubbleB);
            this.sortP.Controls.Add(this.shakerS);
            this.sortP.Controls.Add(this.shakerP);
            this.sortP.Controls.Add(this.shakerT);
            this.sortP.Controls.Add(this.ctrlS);
            this.sortP.Controls.Add(this.ctrlP);
            this.sortP.Controls.Add(this.ctrlT);
            this.sortP.Controls.Add(this.bubbleS);
            this.sortP.Controls.Add(this.bubbleP);
            this.sortP.Controls.Add(this.bubbleT);
            this.sortP.Controls.Add(this.shaker);
            this.sortP.Controls.Add(this.ctrl);
            this.sortP.Controls.Add(this.sortLabel);
            this.sortP.Controls.Add(this.notSortLabel);
            this.sortP.Controls.Add(this.notSortBox);
            this.sortP.Location = new System.Drawing.Point(32, 9);
            this.sortP.Name = "sortP";
            this.sortP.Size = new System.Drawing.Size(735, 429);
            this.sortP.TabIndex = 5;
            this.sortP.Visible = false;
            // 
            // notSortLabel
            // 
            this.notSortLabel.AutoSize = true;
            this.notSortLabel.Location = new System.Drawing.Point(9, 35);
            this.notSortLabel.Name = "notSortLabel";
            this.notSortLabel.Size = new System.Drawing.Size(155, 13);
            this.notSortLabel.TabIndex = 5;
            this.notSortLabel.Text = "Не отсортированный массив";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(426, 15);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(148, 13);
            this.sortLabel.TabIndex = 6;
            this.sortLabel.Text = "Отсортированные массивы";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(507, 265);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(134, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Ok";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // startP
            // 
            this.startP.Controls.Add(this.border2);
            this.startP.Controls.Add(this.label2);
            this.startP.Controls.Add(this.border1);
            this.startP.Controls.Add(this.startBtn);
            this.startP.Controls.Add(this.label1);
            this.startP.Controls.Add(this.inputBox);
            this.startP.Location = new System.Drawing.Point(-174, 9);
            this.startP.Name = "startP";
            this.startP.Size = new System.Drawing.Size(976, 439);
            this.startP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите диапазон массива";
            // 
            // border1
            // 
            this.border1.Location = new System.Drawing.Point(507, 209);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(56, 20);
            this.border1.TabIndex = 8;
            // 
            // border2
            // 
            this.border2.Location = new System.Drawing.Point(585, 209);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(56, 20);
            this.border2.TabIndex = 9;
            // 
            // ctrl
            // 
            this.ctrl.FormattingEnabled = true;
            this.ctrl.Location = new System.Drawing.Point(441, 64);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(119, 277);
            this.ctrl.TabIndex = 7;
            // 
            // shaker
            // 
            this.shaker.FormattingEnabled = true;
            this.shaker.Location = new System.Drawing.Point(593, 64);
            this.shaker.Name = "shaker";
            this.shaker.Size = new System.Drawing.Size(119, 277);
            this.shaker.TabIndex = 8;
            // 
            // bubbleT
            // 
            this.bubbleT.AutoSize = true;
            this.bubbleT.Location = new System.Drawing.Point(276, 359);
            this.bubbleT.Name = "bubbleT";
            this.bubbleT.Size = new System.Drawing.Size(43, 13);
            this.bubbleT.TabIndex = 9;
            this.bubbleT.Text = "Время:";
            // 
            // bubbleP
            // 
            this.bubbleP.AutoSize = true;
            this.bubbleP.Location = new System.Drawing.Point(276, 383);
            this.bubbleP.Name = "bubbleP";
            this.bubbleP.Size = new System.Drawing.Size(83, 13);
            this.bubbleP.TabIndex = 10;
            this.bubbleP.Text = "Перестановок:";
            // 
            // bubbleS
            // 
            this.bubbleS.AutoSize = true;
            this.bubbleS.Location = new System.Drawing.Point(276, 407);
            this.bubbleS.Name = "bubbleS";
            this.bubbleS.Size = new System.Drawing.Size(65, 13);
            this.bubbleS.TabIndex = 11;
            this.bubbleS.Text = "Сравнений:";
            // 
            // ctrlS
            // 
            this.ctrlS.AutoSize = true;
            this.ctrlS.Location = new System.Drawing.Point(438, 407);
            this.ctrlS.Name = "ctrlS";
            this.ctrlS.Size = new System.Drawing.Size(65, 13);
            this.ctrlS.TabIndex = 14;
            this.ctrlS.Text = "Сравнений:";
            // 
            // ctrlP
            // 
            this.ctrlP.AutoSize = true;
            this.ctrlP.Location = new System.Drawing.Point(438, 383);
            this.ctrlP.Name = "ctrlP";
            this.ctrlP.Size = new System.Drawing.Size(83, 13);
            this.ctrlP.TabIndex = 13;
            this.ctrlP.Text = "Перестановок:";
            // 
            // ctrlT
            // 
            this.ctrlT.AutoSize = true;
            this.ctrlT.Location = new System.Drawing.Point(438, 359);
            this.ctrlT.Name = "ctrlT";
            this.ctrlT.Size = new System.Drawing.Size(43, 13);
            this.ctrlT.TabIndex = 12;
            this.ctrlT.Text = "Время:";
            // 
            // shakerS
            // 
            this.shakerS.AutoSize = true;
            this.shakerS.Location = new System.Drawing.Point(590, 407);
            this.shakerS.Name = "shakerS";
            this.shakerS.Size = new System.Drawing.Size(65, 13);
            this.shakerS.TabIndex = 17;
            this.shakerS.Text = "Сравнений:";
            // 
            // shakerP
            // 
            this.shakerP.AutoSize = true;
            this.shakerP.Location = new System.Drawing.Point(590, 383);
            this.shakerP.Name = "shakerP";
            this.shakerP.Size = new System.Drawing.Size(83, 13);
            this.shakerP.TabIndex = 16;
            this.shakerP.Text = "Перестановок:";
            // 
            // shakerT
            // 
            this.shakerT.AutoSize = true;
            this.shakerT.Location = new System.Drawing.Point(590, 359);
            this.shakerT.Name = "shakerT";
            this.shakerT.Size = new System.Drawing.Size(43, 13);
            this.shakerT.TabIndex = 15;
            this.shakerT.Text = "Время:";
            // 
            // bubbleB
            // 
            this.bubbleB.FormattingEnabled = true;
            this.bubbleB.Location = new System.Drawing.Point(279, 64);
            this.bubbleB.Name = "bubbleB";
            this.bubbleB.Size = new System.Drawing.Size(119, 277);
            this.bubbleB.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortP);
            this.Controls.Add(this.startP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка массивов в Thread";
            this.sortP.ResumeLayout(false);
            this.sortP.PerformLayout();
            this.startP.ResumeLayout(false);
            this.startP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox notSortBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Panel sortP;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label notSortLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel startP;
        private System.Windows.Forms.TextBox border2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox border1;
        private System.Windows.Forms.ListBox shaker;
        private System.Windows.Forms.ListBox ctrl;
        private System.Windows.Forms.Label shakerS;
        private System.Windows.Forms.Label shakerP;
        private System.Windows.Forms.Label shakerT;
        private System.Windows.Forms.Label ctrlS;
        private System.Windows.Forms.Label ctrlP;
        private System.Windows.Forms.Label ctrlT;
        private System.Windows.Forms.Label bubbleS;
        private System.Windows.Forms.Label bubbleP;
        private System.Windows.Forms.Label bubbleT;
        private System.Windows.Forms.ListBox bubbleB;
    }
}

