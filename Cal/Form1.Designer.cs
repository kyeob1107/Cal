namespace Cal
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
            this.percentButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.digitButton9 = new System.Windows.Forms.Button();
            this.digitButton8 = new System.Windows.Forms.Button();
            this.digitButton7 = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.digitButton6 = new System.Windows.Forms.Button();
            this.digitButton5 = new System.Windows.Forms.Button();
            this.digitButton4 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.digitButton3 = new System.Windows.Forms.Button();
            this.digitButton2 = new System.Windows.Forms.Button();
            this.digitButton1 = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.decimalPointButton = new System.Windows.Forms.Button();
            this.digitButton0 = new System.Windows.Forms.Button();
            this.signChangeButton = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.textboxResult = new System.Windows.Forms.TextBox();
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // percentButton
            // 
            this.percentButton.Location = new System.Drawing.Point(22, 204);
            this.percentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(86, 29);
            this.percentButton.TabIndex = 0;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(114, 204);
            this.clearEntryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(86, 29);
            this.clearEntryButton.TabIndex = 1;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(207, 204);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 29);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // backspaceButton
            // 
            this.backspaceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("backspaceButton.Image")));
            this.backspaceButton.Location = new System.Drawing.Point(299, 204);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(86, 29);
            this.backspaceButton.TabIndex = 3;
            this.backspaceButton.UseVisualStyleBackColor = false;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(299, 240);
            this.divideButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(86, 29);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // squareRootButton
            // 
            this.squareRootButton.Location = new System.Drawing.Point(207, 240);
            this.squareRootButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(86, 29);
            this.squareRootButton.TabIndex = 6;
            this.squareRootButton.Text = "root(x)";
            this.squareRootButton.UseVisualStyleBackColor = true;
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(114, 240);
            this.squareButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(86, 29);
            this.squareButton.TabIndex = 5;
            this.squareButton.Text = "x^2";
            this.squareButton.UseVisualStyleBackColor = true;
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Location = new System.Drawing.Point(22, 240);
            this.reciprocalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(86, 29);
            this.reciprocalButton.TabIndex = 4;
            this.reciprocalButton.Text = "1/x";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(299, 276);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(86, 29);
            this.multiplyButton.TabIndex = 11;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // digitButton9
            // 
            this.digitButton9.Location = new System.Drawing.Point(207, 276);
            this.digitButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton9.Name = "digitButton9";
            this.digitButton9.Size = new System.Drawing.Size(86, 29);
            this.digitButton9.TabIndex = 10;
            this.digitButton9.Text = "9";
            this.digitButton9.UseVisualStyleBackColor = true;
            this.digitButton9.Click += new System.EventHandler(this.digitButton9_Click);
            // 
            // digitButton8
            // 
            this.digitButton8.Location = new System.Drawing.Point(114, 276);
            this.digitButton8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton8.Name = "digitButton8";
            this.digitButton8.Size = new System.Drawing.Size(86, 29);
            this.digitButton8.TabIndex = 9;
            this.digitButton8.Text = "8";
            this.digitButton8.UseVisualStyleBackColor = true;
            this.digitButton8.Click += new System.EventHandler(this.digitButton8_Click);
            // 
            // digitButton7
            // 
            this.digitButton7.Location = new System.Drawing.Point(22, 276);
            this.digitButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton7.Name = "digitButton7";
            this.digitButton7.Size = new System.Drawing.Size(86, 29);
            this.digitButton7.TabIndex = 8;
            this.digitButton7.Text = "7";
            this.digitButton7.UseVisualStyleBackColor = true;
            this.digitButton7.Click += new System.EventHandler(this.digitButton7_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(299, 312);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(86, 29);
            this.subtractButton.TabIndex = 15;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // digitButton6
            // 
            this.digitButton6.Location = new System.Drawing.Point(207, 312);
            this.digitButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton6.Name = "digitButton6";
            this.digitButton6.Size = new System.Drawing.Size(86, 29);
            this.digitButton6.TabIndex = 14;
            this.digitButton6.Text = "6";
            this.digitButton6.UseVisualStyleBackColor = true;
            this.digitButton6.Click += new System.EventHandler(this.digitButton6_Click);
            // 
            // digitButton5
            // 
            this.digitButton5.Location = new System.Drawing.Point(114, 312);
            this.digitButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton5.Name = "digitButton5";
            this.digitButton5.Size = new System.Drawing.Size(86, 29);
            this.digitButton5.TabIndex = 13;
            this.digitButton5.Text = "5";
            this.digitButton5.UseVisualStyleBackColor = true;
            this.digitButton5.Click += new System.EventHandler(this.digitButton5_Click);
            // 
            // digitButton4
            // 
            this.digitButton4.Location = new System.Drawing.Point(22, 312);
            this.digitButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton4.Name = "digitButton4";
            this.digitButton4.Size = new System.Drawing.Size(86, 29);
            this.digitButton4.TabIndex = 12;
            this.digitButton4.Text = "4";
            this.digitButton4.UseVisualStyleBackColor = true;
            this.digitButton4.Click += new System.EventHandler(this.digitButton4_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(299, 349);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 29);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // digitButton3
            // 
            this.digitButton3.Location = new System.Drawing.Point(207, 349);
            this.digitButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton3.Name = "digitButton3";
            this.digitButton3.Size = new System.Drawing.Size(86, 29);
            this.digitButton3.TabIndex = 18;
            this.digitButton3.Text = "3";
            this.digitButton3.UseVisualStyleBackColor = true;
            this.digitButton3.Click += new System.EventHandler(this.digitButton3_Click);
            // 
            // digitButton2
            // 
            this.digitButton2.Location = new System.Drawing.Point(114, 349);
            this.digitButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton2.Name = "digitButton2";
            this.digitButton2.Size = new System.Drawing.Size(86, 29);
            this.digitButton2.TabIndex = 17;
            this.digitButton2.Text = "2";
            this.digitButton2.UseVisualStyleBackColor = true;
            this.digitButton2.Click += new System.EventHandler(this.digitButton2_Click);
            // 
            // digitButton1
            // 
            this.digitButton1.Location = new System.Drawing.Point(22, 349);
            this.digitButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton1.Name = "digitButton1";
            this.digitButton1.Size = new System.Drawing.Size(86, 29);
            this.digitButton1.TabIndex = 16;
            this.digitButton1.Text = "1";
            this.digitButton1.UseVisualStyleBackColor = true;
            this.digitButton1.Click += new System.EventHandler(this.digitButton1_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(299, 385);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(86, 29);
            this.equalsButton.TabIndex = 23;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // decimalPointButton
            // 
            this.decimalPointButton.Location = new System.Drawing.Point(207, 385);
            this.decimalPointButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decimalPointButton.Name = "decimalPointButton";
            this.decimalPointButton.Size = new System.Drawing.Size(86, 29);
            this.decimalPointButton.TabIndex = 22;
            this.decimalPointButton.Text = ".";
            this.decimalPointButton.UseVisualStyleBackColor = true;
            // 
            // digitButton0
            // 
            this.digitButton0.Location = new System.Drawing.Point(114, 385);
            this.digitButton0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.digitButton0.Name = "digitButton0";
            this.digitButton0.Size = new System.Drawing.Size(86, 29);
            this.digitButton0.TabIndex = 21;
            this.digitButton0.Text = "0";
            this.digitButton0.UseVisualStyleBackColor = true;
            this.digitButton0.Click += new System.EventHandler(this.digitButton0_Click);
            // 
            // signChangeButton
            // 
            this.signChangeButton.Location = new System.Drawing.Point(22, 385);
            this.signChangeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signChangeButton.Name = "signChangeButton";
            this.signChangeButton.Size = new System.Drawing.Size(86, 29);
            this.signChangeButton.TabIndex = 20;
            this.signChangeButton.Text = "+/-";
            this.signChangeButton.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(328, 168);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(57, 29);
            this.button29.TabIndex = 29;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(266, 168);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(57, 29);
            this.button25.TabIndex = 30;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(145, 168);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(57, 29);
            this.button26.TabIndex = 32;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(207, 168);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(57, 29);
            this.button27.TabIndex = 31;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(22, 168);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(57, 29);
            this.button28.TabIndex = 34;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(83, 168);
            this.button30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(57, 29);
            this.button30.TabIndex = 33;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // textboxResult
            // 
            this.textboxResult.Font = new System.Drawing.Font("Gulim", 20F);
            this.textboxResult.Location = new System.Drawing.Point(240, 99);
            this.textboxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxResult.Name = "textboxResult";
            this.textboxResult.Size = new System.Drawing.Size(140, 46);
            this.textboxResult.TabIndex = 35;
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Location = new System.Drawing.Point(191, 65);
            this.textBoxCalculation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.Size = new System.Drawing.Size(189, 25);
            this.textBoxCalculation.TabIndex = 36;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(299, 29);
            this.button31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(81, 29);
            this.button31.TabIndex = 37;
            this.button31.Text = "History";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(22, 29);
            this.button32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(57, 29);
            this.button32.TabIndex = 38;
            this.button32.Text = "button32";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(86, 29);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 25);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "Standard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 432);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.textBoxCalculation);
            this.Controls.Add(this.textboxResult);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.decimalPointButton);
            this.Controls.Add(this.digitButton0);
            this.Controls.Add(this.signChangeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.digitButton3);
            this.Controls.Add(this.digitButton2);
            this.Controls.Add(this.digitButton1);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.digitButton6);
            this.Controls.Add(this.digitButton5);
            this.Controls.Add(this.digitButton4);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.digitButton9);
            this.Controls.Add(this.digitButton8);
            this.Controls.Add(this.digitButton7);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.reciprocalButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.percentButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button squareRootButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button digitButton9;
        private System.Windows.Forms.Button digitButton8;
        private System.Windows.Forms.Button digitButton7;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button digitButton6;
        private System.Windows.Forms.Button digitButton5;
        private System.Windows.Forms.Button digitButton4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button digitButton3;
        private System.Windows.Forms.Button digitButton2;
        private System.Windows.Forms.Button digitButton1;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button decimalPointButton;
        private System.Windows.Forms.Button digitButton0;
        private System.Windows.Forms.Button signChangeButton;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TextBox textboxResult;
        private System.Windows.Forms.TextBox textBoxCalculation;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.TextBox textBox3;
    }
}

