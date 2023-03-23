namespace Lab1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CreateMassive = new System.Windows.Forms.Button();
            this.AllOperations = new System.Windows.Forms.Button();
            this.dataGridViewMas = new System.Windows.Forms.DataGridView();
            this.radioButtonSort = new System.Windows.Forms.RadioButton();
            this.radioButtonPr = new System.Windows.Forms.RadioButton();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество Столбцов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(270, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CreateMassive
            // 
            this.CreateMassive.BackColor = System.Drawing.Color.SteelBlue;
            this.CreateMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMassive.Location = new System.Drawing.Point(369, 49);
            this.CreateMassive.Name = "CreateMassive";
            this.CreateMassive.Size = new System.Drawing.Size(208, 34);
            this.CreateMassive.TabIndex = 11;
            this.CreateMassive.Text = "Создать Массив";
            this.CreateMassive.UseVisualStyleBackColor = false;
            this.CreateMassive.Click += new System.EventHandler(this.CreateMassive_Click);
            // 
            // AllOperations
            // 
            this.AllOperations.BackColor = System.Drawing.Color.SteelBlue;
            this.AllOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllOperations.Location = new System.Drawing.Point(598, 49);
            this.AllOperations.Name = "AllOperations";
            this.AllOperations.Size = new System.Drawing.Size(208, 34);
            this.AllOperations.TabIndex = 12;
            this.AllOperations.Text = "Все Операции";
            this.AllOperations.UseVisualStyleBackColor = false;
            this.AllOperations.Click += new System.EventHandler(this.AllOperations_Click);
            // 
            // dataGridViewMas
            // 
            this.dataGridViewMas.AllowUserToAddRows = false;
            this.dataGridViewMas.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMas.ColumnHeadersVisible = false;
            this.dataGridViewMas.Location = new System.Drawing.Point(31, 96);
            this.dataGridViewMas.Name = "dataGridViewMas";
            this.dataGridViewMas.RowHeadersVisible = false;
            this.dataGridViewMas.RowHeadersWidth = 51;
            this.dataGridViewMas.RowTemplate.Height = 24;
            this.dataGridViewMas.Size = new System.Drawing.Size(943, 62);
            this.dataGridViewMas.TabIndex = 13;
            this.dataGridViewMas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMas_CellContentClick);
            // 
            // radioButtonSort
            // 
            this.radioButtonSort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSort.Location = new System.Drawing.Point(548, 497);
            this.radioButtonSort.Name = "radioButtonSort";
            this.radioButtonSort.Size = new System.Drawing.Size(148, 40);
            this.radioButtonSort.TabIndex = 20;
            this.radioButtonSort.TabStop = true;
            this.radioButtonSort.Text = "Сортировка";
            this.radioButtonSort.UseVisualStyleBackColor = false;
            this.radioButtonSort.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonPr
            // 
            this.radioButtonPr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonPr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPr.Location = new System.Drawing.Point(548, 359);
            this.radioButtonPr.Name = "radioButtonPr";
            this.radioButtonPr.Size = new System.Drawing.Size(208, 40);
            this.radioButtonPr.TabIndex = 19;
            this.radioButtonPr.TabStop = true;
            this.radioButtonPr.Text = "Произведение";
            this.radioButtonPr.UseVisualStyleBackColor = false;
            this.radioButtonPr.CheckedChanged += new System.EventHandler(this.radioButtonPr_CheckedChanged);
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonSum.Location = new System.Drawing.Point(548, 313);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(264, 40);
            this.radioButtonSum.TabIndex = 18;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Сумма ";
            this.radioButtonSum.UseVisualStyleBackColor = false;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(804, 667);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(190, 43);
            this.Back.TabIndex = 21;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(31, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 494);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 31);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.открытьToolStripMenuItem.Text = "Файл";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(178, 28);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMax.Location = new System.Drawing.Point(548, 405);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(275, 40);
            this.radioButtonMax.TabIndex = 24;
            this.radioButtonMax.TabStop = true;
            this.radioButtonMax.Text = "Максимальный Элемент";
            this.radioButtonMax.UseVisualStyleBackColor = false;
            this.radioButtonMax.CheckedChanged += new System.EventHandler(this.radioButtonMax_CheckedChanged);
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMin.Location = new System.Drawing.Point(548, 451);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(264, 40);
            this.radioButtonMin.TabIndex = 25;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "Минимальный Элемент";
            this.radioButtonMin.UseVisualStyleBackColor = false;
            this.radioButtonMin.CheckedChanged += new System.EventHandler(this.radioButtonMin_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(548, 231);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.Location = new System.Drawing.Point(548, 264);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(544, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Диапазон Произведения";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown4.Location = new System.Drawing.Point(804, 231);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown4.TabIndex = 30;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown5.Location = new System.Drawing.Point(804, 264);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown5.TabIndex = 29;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(802, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Диапазон Поиска";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.radioButtonMin);
            this.Controls.Add(this.radioButtonMax);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.radioButtonSort);
            this.Controls.Add(this.radioButtonPr);
            this.Controls.Add(this.radioButtonSum);
            this.Controls.Add(this.dataGridViewMas);
            this.Controls.Add(this.AllOperations);
            this.Controls.Add(this.CreateMassive);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Массив";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CreateMassive;
        private System.Windows.Forms.Button AllOperations;
        private System.Windows.Forms.DataGridView dataGridViewMas;
        private System.Windows.Forms.RadioButton radioButtonSort;
        private System.Windows.Forms.RadioButton radioButtonPr;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label3;
    }
}