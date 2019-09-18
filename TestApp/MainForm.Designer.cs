namespace TestApp
{
    partial class MainForm
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
            this.resetButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.addTestDataButton = new System.Windows.Forms.Button();
            this.doReportButton = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.getStud_button = new System.Windows.Forms.Button();
            this.getSpec_button = new System.Windows.Forms.Button();
            this.getFac_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(41, 295);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(95, 49);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset DB";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesButton.Location = new System.Drawing.Point(146, 295);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(95, 49);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "SaveToTxt";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // addTestDataButton
            // 
            this.addTestDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTestDataButton.Location = new System.Drawing.Point(41, 12);
            this.addTestDataButton.Name = "addTestDataButton";
            this.addTestDataButton.Size = new System.Drawing.Size(200, 49);
            this.addTestDataButton.TabIndex = 10;
            this.addTestDataButton.Text = "AddTestData";
            this.addTestDataButton.UseVisualStyleBackColor = true;
            this.addTestDataButton.Click += new System.EventHandler(this.addTestDataButton_Click);
            // 
            // doReportButton
            // 
            this.doReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doReportButton.Location = new System.Drawing.Point(41, 240);
            this.doReportButton.Name = "doReportButton";
            this.doReportButton.Size = new System.Drawing.Size(200, 49);
            this.doReportButton.TabIndex = 12;
            this.doReportButton.Text = "DoReport";
            this.doReportButton.UseVisualStyleBackColor = true;
            this.doReportButton.Click += new System.EventHandler(this.doReportButton_Click);
            // 
            // console
            // 
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.console.Location = new System.Drawing.Point(297, 12);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(493, 288);
            this.console.TabIndex = 13;
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // getStud_button
            // 
            this.getStud_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getStud_button.Location = new System.Drawing.Point(41, 67);
            this.getStud_button.Name = "getStud_button";
            this.getStud_button.Size = new System.Drawing.Size(200, 49);
            this.getStud_button.TabIndex = 14;
            this.getStud_button.Text = "GetStudents";
            this.getStud_button.UseVisualStyleBackColor = true;
            this.getStud_button.Click += new System.EventHandler(this.getStud_button_Click);
            // 
            // getSpec_button
            // 
            this.getSpec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getSpec_button.Location = new System.Drawing.Point(41, 122);
            this.getSpec_button.Name = "getSpec_button";
            this.getSpec_button.Size = new System.Drawing.Size(200, 49);
            this.getSpec_button.TabIndex = 15;
            this.getSpec_button.Text = "GetSpecialtys";
            this.getSpec_button.UseVisualStyleBackColor = true;
            this.getSpec_button.Click += new System.EventHandler(this.getSpec_button_Click);
            // 
            // getFac_button
            // 
            this.getFac_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getFac_button.Location = new System.Drawing.Point(41, 177);
            this.getFac_button.Name = "getFac_button";
            this.getFac_button.Size = new System.Drawing.Size(200, 49);
            this.getFac_button.TabIndex = 16;
            this.getFac_button.Text = "GetFacultys";
            this.getFac_button.UseVisualStyleBackColor = true;
            this.getFac_button.Click += new System.EventHandler(this.getFac_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(695, 315);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(95, 49);
            this.clear_button.TabIndex = 17;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 380);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.getFac_button);
            this.Controls.Add(this.getSpec_button);
            this.Controls.Add(this.getStud_button);
            this.Controls.Add(this.console);
            this.Controls.Add(this.doReportButton);
            this.Controls.Add(this.addTestDataButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.resetButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button addTestDataButton;

        private System.Windows.Forms.Button doReportButton;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button getStud_button;
        private System.Windows.Forms.Button getSpec_button;
        private System.Windows.Forms.Button getFac_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

