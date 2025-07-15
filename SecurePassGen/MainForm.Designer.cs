namespace SecurePassGen
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.CheckBox checkBoxUpper;
        private System.Windows.Forms.CheckBox checkBoxLower;
        private System.Windows.Forms.CheckBox checkBoxDigit;
        private System.Windows.Forms.CheckBox checkBoxSymbol;
        private System.Windows.Forms.CheckBox checkBoxExcludeSimilar;
        private System.Windows.Forms.CheckBox checkBoxRequireEachType;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelLengthInfo;
        private System.Windows.Forms.Label labelCustomSymbols;
        private System.Windows.Forms.TextBox textBoxCustomSymbols;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelLength = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.labelLengthInfo = new System.Windows.Forms.Label();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.checkBoxLower = new System.Windows.Forms.CheckBox();
            this.checkBoxDigit = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbol = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeSimilar = new System.Windows.Forms.CheckBox();
            this.checkBoxRequireEachType = new System.Windows.Forms.CheckBox();
            this.labelCustomSymbols = new System.Windows.Forms.Label();
            this.textBoxCustomSymbols = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.labelLength, 0, 0);
            this.tableLayout.Controls.Add(this.numericUpDownLength, 1, 0);
            this.tableLayout.Controls.Add(this.labelLengthInfo, 1, 1);
            this.tableLayout.Controls.Add(this.checkBoxUpper, 0, 2);
            this.tableLayout.Controls.Add(this.checkBoxLower, 1, 2);
            this.tableLayout.Controls.Add(this.checkBoxDigit, 0, 3);
            this.tableLayout.Controls.Add(this.checkBoxSymbol, 1, 3);
            this.tableLayout.Controls.Add(this.checkBoxExcludeSimilar, 0, 4);
            this.tableLayout.Controls.Add(this.checkBoxRequireEachType, 1, 4);
            this.tableLayout.Controls.Add(this.labelCustomSymbols, 0, 5);
            this.tableLayout.Controls.Add(this.textBoxCustomSymbols, 1, 5);
            this.tableLayout.Location = new System.Drawing.Point(12, 12);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(360, 180);
            this.tableLayout.TabIndex = 0;
            // 
            // labelLength
            // 
            this.labelLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLength.Location = new System.Drawing.Point(3, 0);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(174, 27);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "패스워드 길이:";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(183, 3);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(50, 21);
            this.numericUpDownLength.TabIndex = 1;
            this.numericUpDownLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelLengthInfo
            // 
            this.labelLengthInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLengthInfo.Location = new System.Drawing.Point(183, 27);
            this.labelLengthInfo.Name = "labelLengthInfo";
            this.labelLengthInfo.Size = new System.Drawing.Size(174, 27);
            this.labelLengthInfo.TabIndex = 8;
            this.labelLengthInfo.Text = "(최소 8, 최대 64, 기본값 12)";
            this.labelLengthInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxUpper
            // 
            this.checkBoxUpper.Checked = true;
            this.checkBoxUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpper.Location = new System.Drawing.Point(3, 57);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(104, 24);
            this.checkBoxUpper.TabIndex = 9;
            this.checkBoxUpper.Text = "대문자 포함";
            // 
            // checkBoxLower
            // 
            this.checkBoxLower.Checked = true;
            this.checkBoxLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLower.Location = new System.Drawing.Point(183, 57);
            this.checkBoxLower.Name = "checkBoxLower";
            this.checkBoxLower.Size = new System.Drawing.Size(104, 24);
            this.checkBoxLower.TabIndex = 10;
            this.checkBoxLower.Text = "소문자 포함";
            // 
            // checkBoxDigit
            // 
            this.checkBoxDigit.Checked = true;
            this.checkBoxDigit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDigit.Location = new System.Drawing.Point(3, 87);
            this.checkBoxDigit.Name = "checkBoxDigit";
            this.checkBoxDigit.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDigit.TabIndex = 11;
            this.checkBoxDigit.Text = "숫자 포함";
            // 
            // checkBoxSymbol
            // 
            this.checkBoxSymbol.Checked = true;
            this.checkBoxSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymbol.Location = new System.Drawing.Point(183, 87);
            this.checkBoxSymbol.Name = "checkBoxSymbol";
            this.checkBoxSymbol.Size = new System.Drawing.Size(104, 24);
            this.checkBoxSymbol.TabIndex = 12;
            this.checkBoxSymbol.Text = "특수문자 포함";
            // 
            // checkBoxExcludeSimilar
            // 
            this.checkBoxExcludeSimilar.Checked = true;
            this.checkBoxExcludeSimilar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcludeSimilar.Location = new System.Drawing.Point(3, 117);
            this.checkBoxExcludeSimilar.Name = "checkBoxExcludeSimilar";
            this.checkBoxExcludeSimilar.Size = new System.Drawing.Size(150, 24);
            this.checkBoxExcludeSimilar.TabIndex = 13;
            this.checkBoxExcludeSimilar.Text = "비슷한 문자 제외";
            // 
            // checkBoxRequireEachType
            // 
            this.checkBoxRequireEachType.Checked = true;
            this.checkBoxRequireEachType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRequireEachType.Location = new System.Drawing.Point(183, 117);
            this.checkBoxRequireEachType.Name = "checkBoxRequireEachType";
            this.checkBoxRequireEachType.Size = new System.Drawing.Size(150, 24);
            this.checkBoxRequireEachType.TabIndex = 14;
            this.checkBoxRequireEachType.Text = "각 타입 최소 1개 포함";
            // 
            // labelCustomSymbols
            // 
            this.labelCustomSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomSymbols.Location = new System.Drawing.Point(3, 144);
            this.labelCustomSymbols.Name = "labelCustomSymbols";
            this.labelCustomSymbols.Size = new System.Drawing.Size(174, 27);
            this.labelCustomSymbols.TabIndex = 15;
            this.labelCustomSymbols.Text = "사용자 정의 특수문자:";
            this.labelCustomSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCustomSymbols
            // 
            this.textBoxCustomSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomSymbols.Location = new System.Drawing.Point(183, 147);
            this.textBoxCustomSymbols.Name = "textBoxCustomSymbols";
            this.textBoxCustomSymbols.Size = new System.Drawing.Size(174, 21);
            this.textBoxCustomSymbols.TabIndex = 16;
            this.textBoxCustomSymbols.Text = "!@#$%^&*()_+-=[]{}|;:\',.<>?/";
            this.textBoxCustomSymbols.TextChanged += new System.EventHandler(this.textBoxCustomSymbols_TextChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 193);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(160, 25);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "패스워드 생성";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(212, 193);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(160, 25);
            this.buttonCopy.TabIndex = 10;
            this.buttonCopy.Text = "클립보드 복사";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 228);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(360, 21);
            this.textBoxResult.TabIndex = 11;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(12, 258);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(360, 15);
            this.labelStatus.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 293);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelStatus);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurePassGen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
