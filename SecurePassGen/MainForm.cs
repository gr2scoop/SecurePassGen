using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int length = (int)numericUpDownLength.Value;
                bool upper = checkBoxUpper.Checked;
                bool lower = checkBoxLower.Checked;
                bool digit = checkBoxDigit.Checked;
                bool symbol = checkBoxSymbol.Checked;
                bool excludeSimilar = checkBoxExcludeSimilar.Checked;
                bool requireEach = checkBoxRequireEachType.Checked;
                string customSymbols = textBoxCustomSymbols.Text.Trim();

                string password = PasswordGenerator.Generate(
                    length,
                    upper,
                    lower,
                    digit,
                    symbol,
                    excludeSimilar,
                    requireEach,
                    customSymbols
                );

                textBoxResult.Text = password;
                labelStatus.Text = "패스워드가 생성되었습니다.";
            }
            catch (Exception ex)
            {
                textBoxResult.Text = "";
                labelStatus.Text = "오류: " + ex.Message;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string text = textBoxResult.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
                labelStatus.Text = "패스워드가 클립보드에 복사되었습니다.";
            }
            else
            {
                labelStatus.Text = "복사할 패스워드가 없습니다.";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 설정 불러오기
            checkBoxUpper.Checked = Properties.Settings.Default.UseUpper;
            checkBoxLower.Checked = Properties.Settings.Default.UseLower;
            checkBoxDigit.Checked = Properties.Settings.Default.UseDigits;
            checkBoxSymbol.Checked = Properties.Settings.Default.UseSymbols;
            checkBoxExcludeSimilar.Checked = Properties.Settings.Default.ExcludeSimilar;
            checkBoxRequireEachType.Checked = Properties.Settings.Default.RequireEachType;
            numericUpDownLength.Value = Properties.Settings.Default.PasswordLength;
            textBoxCustomSymbols.Text = Properties.Settings.Default.CustomSymbols;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Properties.Settings.Default.UseUpper = checkBoxUpper.Checked;
            Properties.Settings.Default.UseLower = checkBoxLower.Checked;
            Properties.Settings.Default.UseDigits = checkBoxDigit.Checked;
            Properties.Settings.Default.UseSymbols = checkBoxSymbol.Checked;
            Properties.Settings.Default.ExcludeSimilar = checkBoxExcludeSimilar.Checked;
            Properties.Settings.Default.RequireEachType = checkBoxRequireEachType.Checked;
            Properties.Settings.Default.PasswordLength = (int)numericUpDownLength.Value;
            Properties.Settings.Default.CustomSymbols = textBoxCustomSymbols.Text.Trim();

            Properties.Settings.Default.Save();

            base.OnFormClosing(e);
        }

        private void textBoxCustomSymbols_TextChanged(object sender, EventArgs e)
        {
            string allowed = "!@#$%^&*()_+-=[]{}|;:',.<>?/";
            string input = textBoxCustomSymbols.Text;

            if (input.Any(c => !allowed.Contains(c)))
            {
                MessageBox.Show("특수문자만 입력 가능합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // 특수문자만 남기고 나머지 제거
                textBoxCustomSymbols.Text = new string(input.Where(c => allowed.Contains(c)).ToArray());
                // 커서 맨 뒤로
                textBoxCustomSymbols.SelectionStart = textBoxCustomSymbols.Text.Length;
            }
        }
    }
}
