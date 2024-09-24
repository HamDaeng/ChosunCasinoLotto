namespace ChosunCasinoLotto
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lottoNumbersListBox = new System.Windows.Forms.ListBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.lottoRoundTextBox = new System.Windows.Forms.TextBox();
            this.lottoRoundLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lottoNumbersListBox
            // 
            this.lottoNumbersListBox.BackColor = System.Drawing.SystemColors.Window;
            this.lottoNumbersListBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lottoNumbersListBox.FormattingEnabled = true;
            this.lottoNumbersListBox.ItemHeight = 30;
            this.lottoNumbersListBox.Location = new System.Drawing.Point(9, 225);
            this.lottoNumbersListBox.Name = "lottoNumbersListBox";
            this.lottoNumbersListBox.Size = new System.Drawing.Size(364, 94);
            this.lottoNumbersListBox.TabIndex = 1;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyButton.Location = new System.Drawing.Point(193, 150);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(180, 50);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "복사";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameLabel.Location = new System.Drawing.Point(9, 108);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(178, 25);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "로또 구매자 닉네임";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNameTextBox.Location = new System.Drawing.Point(193, 108);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(180, 29);
            this.userNameTextBox.TabIndex = 4;
            // 
            // lottoRoundTextBox
            // 
            this.lottoRoundTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lottoRoundTextBox.Location = new System.Drawing.Point(193, 68);
            this.lottoRoundTextBox.Name = "lottoRoundTextBox";
            this.lottoRoundTextBox.Size = new System.Drawing.Size(180, 29);
            this.lottoRoundTextBox.TabIndex = 6;
            // 
            // lottoRoundLabel
            // 
            this.lottoRoundLabel.AutoSize = true;
            this.lottoRoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.lottoRoundLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lottoRoundLabel.Location = new System.Drawing.Point(12, 69);
            this.lottoRoundLabel.Name = "lottoRoundLabel";
            this.lottoRoundLabel.Size = new System.Drawing.Size(173, 25);
            this.lottoRoundLabel.TabIndex = 5;
            this.lottoRoundLabel.Text = "로또 회차 (숫자만)";
            this.lottoRoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "조선 노름판 로또번호 생성기";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.generateButton.Location = new System.Drawing.Point(9, 150);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(180, 50);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "생성";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::ChosunCasinoLotto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lottoRoundTextBox);
            this.Controls.Add(this.lottoRoundLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.lottoNumbersListBox);
            this.Controls.Add(this.generateButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "조선 노름판 로또 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox lottoNumbersListBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox lottoRoundTextBox;
        private System.Windows.Forms.Label lottoRoundLabel;
        private System.Windows.Forms.Label label3;
    }
}

