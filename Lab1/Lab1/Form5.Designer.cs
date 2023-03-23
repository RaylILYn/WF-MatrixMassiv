namespace Lab1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.CreateMassive = new System.Windows.Forms.Button();
            this.AllOperations = new System.Windows.Forms.Button();
            this.dataGridViewMas = new System.Windows.Forms.DataGridView();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonPr = new System.Windows.Forms.RadioButton();
            this.radioButtonSort = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(804, 667);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(190, 43);
            this.Back.TabIndex = 5;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество Столбцов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(263, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество Строк";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(263, 79);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // CreateMassive
            // 
            this.CreateMassive.BackColor = System.Drawing.Color.SteelBlue;
            this.CreateMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMassive.Location = new System.Drawing.Point(382, 33);
            this.CreateMassive.Name = "CreateMassive";
            this.CreateMassive.Size = new System.Drawing.Size(208, 34);
            this.CreateMassive.TabIndex = 10;
            this.CreateMassive.Text = "Создать Массив";
            this.CreateMassive.UseVisualStyleBackColor = false;
            this.CreateMassive.Click += new System.EventHandler(this.CreateMassive_Click);
            // 
            // AllOperations
            // 
            this.AllOperations.BackColor = System.Drawing.Color.SteelBlue;
            this.AllOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllOperations.Location = new System.Drawing.Point(621, 33);
            this.AllOperations.Name = "AllOperations";
            this.AllOperations.Size = new System.Drawing.Size(208, 34);
            this.AllOperations.TabIndex = 11;
            this.AllOperations.Text = "Все Операции";
            this.AllOperations.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMas
            // 
            this.dataGridViewMas.AllowUserToAddRows = false;
            this.dataGridViewMas.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMas.ColumnHeadersVisible = false;
            this.dataGridViewMas.Location = new System.Drawing.Point(28, 132);
            this.dataGridViewMas.Name = "dataGridViewMas";
            this.dataGridViewMas.RowHeadersVisible = false;
            this.dataGridViewMas.RowHeadersWidth = 51;
            this.dataGridViewMas.RowTemplate.Height = 24;
            this.dataGridViewMas.Size = new System.Drawing.Size(459, 313);
            this.dataGridViewMas.TabIndex = 12;
            this.dataGridViewMas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMas_CellContentClick);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxResult.Location = new System.Drawing.Point(552, 132);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(391, 395);
            this.textBoxResult.TabIndex = 13;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonSum.Location = new System.Drawing.Point(28, 487);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(264, 40);
            this.radioButtonSum.TabIndex = 15;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Сумма ";
            this.radioButtonSum.UseVisualStyleBackColor = false;
            // 
            // radioButtonPr
            // 
            this.radioButtonPr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonPr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPr.Location = new System.Drawing.Point(28, 533);
            this.radioButtonPr.Name = "radioButtonPr";
            this.radioButtonPr.Size = new System.Drawing.Size(208, 40);
            this.radioButtonPr.TabIndex = 16;
            this.radioButtonPr.TabStop = true;
            this.radioButtonPr.Text = "Произведение";
            this.radioButtonPr.UseVisualStyleBackColor = false;
            // 
            // radioButtonSort
            // 
            this.radioButtonSort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSort.Location = new System.Drawing.Point(28, 579);
            this.radioButtonSort.Name = "radioButtonSort";
            this.radioButtonSort.Size = new System.Drawing.Size(148, 40);
            this.radioButtonSort.TabIndex = 17;
            this.radioButtonSort.TabStop = true;
            this.radioButtonSort.Text = "Сортировка";
            this.radioButtonSort.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.radioButtonSort);
            this.Controls.Add(this.radioButtonPr);
            this.Controls.Add(this.radioButtonSum);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.dataGridViewMas);
            this.Controls.Add(this.AllOperations);
            this.Controls.Add(this.CreateMassive);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Матрица";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button CreateMassive;
        private System.Windows.Forms.Button AllOperations;
        private System.Windows.Forms.DataGridView dataGridViewMas;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonPr;
        private System.Windows.Forms.RadioButton radioButtonSort;
    }
}