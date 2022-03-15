
namespace TheGalactical_ATM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_withdraw = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(12, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(307, 88);
            this.title.TabIndex = 0;
            this.title.Text = "The Galactical ATM";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_deposit
            // 
            this.button_deposit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_deposit.Location = new System.Drawing.Point(12, 130);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(307, 47);
            this.button_deposit.TabIndex = 1;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = true;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // button_withdraw
            // 
            this.button_withdraw.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_withdraw.Location = new System.Drawing.Point(12, 183);
            this.button_withdraw.Name = "button_withdraw";
            this.button_withdraw.Size = new System.Drawing.Size(307, 47);
            this.button_withdraw.TabIndex = 2;
            this.button_withdraw.Text = "Withdraw";
            this.button_withdraw.UseVisualStyleBackColor = true;
            this.button_withdraw.Click += new System.EventHandler(this.button_withdraw_Click);
            // 
            // button_info
            // 
            this.button_info.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_info.Location = new System.Drawing.Point(12, 236);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(307, 47);
            this.button_info.TabIndex = 3;
            this.button_info.Text = "Info";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Display.ForeColor = System.Drawing.Color.Lime;
            this.Display.Location = new System.Drawing.Point(345, 15);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(335, 88);
            this.Display.TabIndex = 4;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(345, 130);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(69, 47);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "AC";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_decimal
            // 
            this.button_decimal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_decimal.Location = new System.Drawing.Point(345, 183);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(69, 47);
            this.button_decimal.TabIndex = 6;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = true;
            this.button_decimal.Click += new System.EventHandler(this.button_decimal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(435, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(510, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(585, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 47);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(435, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 47);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(510, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 47);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(585, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 47);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(435, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 47);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(510, 130);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 47);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(585, 130);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 47);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_0.Location = new System.Drawing.Point(345, 236);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(69, 47);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(711, 293);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_decimal);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_withdraw);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Button button_withdraw;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_0;
    }
}

