namespace winFormCalc
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
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(408, 12);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(100, 21);
            this.txtExp.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(408, 39);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 1;
            // 
            // btnMC
            // 
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMC.Location = new System.Drawing.Point(12, 124);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(100, 38);
            this.btnMC.TabIndex = 2;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMR.Location = new System.Drawing.Point(141, 124);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(100, 38);
            this.btnMR.TabIndex = 3;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(258, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "M+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(345, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "M-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(534, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(12, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(141, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 38);
            this.button7.TabIndex = 8;
            this.button7.Text = "√";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(289, 168);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 38);
            this.button8.TabIndex = 9;
            this.button8.Text = "x²";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(408, 168);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 38);
            this.button9.TabIndex = 10;
            this.button9.Text = "1/x";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(23, 217);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 38);
            this.button10.TabIndex = 11;
            this.button10.Text = "CE";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(146, 225);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(106, 38);
            this.button11.TabIndex = 12;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(262, 217);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 38);
            this.button12.TabIndex = 13;
            this.button12.Text = "Del";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(374, 225);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(106, 38);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(23, 261);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(106, 38);
            this.button14.TabIndex = 15;
            this.button14.Text = "7";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(150, 261);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(106, 38);
            this.button15.TabIndex = 16;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(262, 261);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(106, 38);
            this.button16.TabIndex = 17;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.FlatAppearance.BorderSize = 0;
            this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimes.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTimes.Location = new System.Drawing.Point(374, 265);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(106, 38);
            this.btnTimes.TabIndex = 18;
            this.btnTimes.Text = "×";
            this.btnTimes.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button18.Location = new System.Drawing.Point(23, 309);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(106, 38);
            this.button18.TabIndex = 19;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button19.Location = new System.Drawing.Point(150, 313);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(106, 38);
            this.button19.TabIndex = 20;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button20.Location = new System.Drawing.Point(262, 313);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(106, 38);
            this.button20.TabIndex = 21;
            this.button20.Text = "6";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(374, 309);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(106, 38);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button22.Location = new System.Drawing.Point(23, 353);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(106, 38);
            this.button22.TabIndex = 23;
            this.button22.Text = "1";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button23.Location = new System.Drawing.Point(150, 353);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(106, 38);
            this.button23.TabIndex = 24;
            this.button23.Text = "2";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button24
            // 
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button24.Location = new System.Drawing.Point(262, 357);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(106, 38);
            this.button24.TabIndex = 25;
            this.button24.Text = "3";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(374, 353);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(106, 38);
            this.btnPlus.TabIndex = 26;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button26.Location = new System.Drawing.Point(10, 397);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(106, 38);
            this.button26.TabIndex = 27;
            this.button26.Text = "±";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button27.Location = new System.Drawing.Point(150, 397);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(106, 38);
            this.button27.TabIndex = 28;
            this.button27.Text = "0";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button28
            // 
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.button28.Location = new System.Drawing.Point(258, 397);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(106, 38);
            this.button28.TabIndex = 29;
            this.button28.Text = ".";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Location = new System.Drawing.Point(374, 397);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(106, 38);
            this.btnEqual.TabIndex = 30;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnMS
            // 
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMS.Location = new System.Drawing.Point(438, 124);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(100, 38);
            this.btnMS.TabIndex = 31;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMS;
    }
}

