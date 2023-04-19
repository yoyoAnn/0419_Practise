namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.weightTextBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bmiLabel = new System.Windows.Forms.Label();
			this.noteLabel = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "身高";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "體重";
			// 
			// heightTextBox
			// 
			this.heightTextBox.Location = new System.Drawing.Point(128, 41);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(100, 30);
			this.heightTextBox.TabIndex = 0;
			// 
			// weightTextBox
			// 
			this.weightTextBox.Location = new System.Drawing.Point(128, 87);
			this.weightTextBox.Name = "weightTextBox";
			this.weightTextBox.Size = new System.Drawing.Size(100, 30);
			this.weightTextBox.TabIndex = 1;
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(119, 150);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(109, 33);
			this.calcButton.TabIndex = 2;
			this.calcButton.Text = "計算BMI";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "BMI:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "說明:";
			// 
			// bmiLabel
			// 
			this.bmiLabel.AutoSize = true;
			this.bmiLabel.Location = new System.Drawing.Point(141, 242);
			this.bmiLabel.Name = "bmiLabel";
			this.bmiLabel.Size = new System.Drawing.Size(78, 19);
			this.bmiLabel.TabIndex = 4;
			this.bmiLabel.Text = "bmiLabel";
			// 
			// noteLabel
			// 
			this.noteLabel.AutoSize = true;
			this.noteLabel.Location = new System.Drawing.Point(141, 283);
			this.noteLabel.Name = "noteLabel";
			this.noteLabel.Size = new System.Drawing.Size(81, 19);
			this.noteLabel.TabIndex = 4;
			this.noteLabel.Text = "noteLabel";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 385);
			this.Controls.Add(this.noteLabel);
			this.Controls.Add(this.bmiLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.weightTextBox);
			this.Controls.Add(this.heightTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("新細明體", 14F);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label bmiLabel;
		private System.Windows.Forms.Label noteLabel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}

