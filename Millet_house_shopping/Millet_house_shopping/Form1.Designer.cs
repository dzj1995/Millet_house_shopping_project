namespace Millet_house_shopping
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.START_BUTTON = new System.Windows.Forms.Button();
            this.product_price = new System.Windows.Forms.TextBox();
            this.input_message = new System.Windows.Forms.TextBox();
            this.product_kind = new System.Windows.Forms.TextBox();
            this.total_money = new System.Windows.Forms.TextBox();
            this.result_textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Location = new System.Drawing.Point(12, 12);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(106, 23);
            this.START_BUTTON.TabIndex = 0;
            this.START_BUTTON.Text = "START";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            this.START_BUTTON.Click += new System.EventHandler(this.START_BUTTON_Click);
            // 
            // product_price
            // 
            this.product_price.Location = new System.Drawing.Point(12, 75);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(106, 25);
            this.product_price.TabIndex = 2;
            this.product_price.Text = "每种产品价格";
            // 
            // input_message
            // 
            this.input_message.Location = new System.Drawing.Point(124, 41);
            this.input_message.Multiline = true;
            this.input_message.Name = "input_message";
            this.input_message.Size = new System.Drawing.Size(146, 95);
            this.input_message.TabIndex = 0;
            // 
            // product_kind
            // 
            this.product_kind.Location = new System.Drawing.Point(12, 41);
            this.product_kind.Name = "product_kind";
            this.product_kind.Size = new System.Drawing.Size(106, 25);
            this.product_kind.TabIndex = 4;
            this.product_kind.Text = "产品种类数";
            this.product_kind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_money
            // 
            this.total_money.Location = new System.Drawing.Point(11, 106);
            this.total_money.Name = "total_money";
            this.total_money.Size = new System.Drawing.Size(107, 25);
            this.total_money.TabIndex = 5;
            this.total_money.Text = "预算金额";
            this.total_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_textBox1
            // 
            this.result_textBox1.Location = new System.Drawing.Point(281, 41);
            this.result_textBox1.Multiline = true;
            this.result_textBox1.Name = "result_textBox1";
            this.result_textBox1.Size = new System.Drawing.Size(164, 95);
            this.result_textBox1.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 12);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 23);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "计算结果";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "输入数据";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 146);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.result_textBox1);
            this.Controls.Add(this.total_money);
            this.Controls.Add(this.product_kind);
            this.Controls.Add(this.input_message);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.START_BUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.init_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button START_BUTTON;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.TextBox input_message;
        private System.Windows.Forms.TextBox product_kind;
        private System.Windows.Forms.TextBox total_money;
        private System.Windows.Forms.TextBox result_textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

