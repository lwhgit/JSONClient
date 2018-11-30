namespace JSONClient {
    partial class JsonPropertyForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doubleType = new System.Windows.Forms.RadioButton();
            this.intType = new System.Windows.Forms.RadioButton();
            this.stringType = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(139, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 21);
            this.nameInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doubleType);
            this.groupBox1.Controls.Add(this.intType);
            this.groupBox1.Controls.Add(this.stringType);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Type";
            // 
            // doubleType
            // 
            this.doubleType.AutoSize = true;
            this.doubleType.Location = new System.Drawing.Point(6, 64);
            this.doubleType.Name = "doubleType";
            this.doubleType.Size = new System.Drawing.Size(61, 16);
            this.doubleType.TabIndex = 5;
            this.doubleType.Text = "double";
            this.doubleType.UseVisualStyleBackColor = true;
            // 
            // intType
            // 
            this.intType.AutoSize = true;
            this.intType.Location = new System.Drawing.Point(6, 42);
            this.intType.Name = "intType";
            this.intType.Size = new System.Drawing.Size(36, 16);
            this.intType.TabIndex = 4;
            this.intType.Text = "int";
            this.intType.UseVisualStyleBackColor = true;
            // 
            // stringType
            // 
            this.stringType.AutoSize = true;
            this.stringType.Checked = true;
            this.stringType.Location = new System.Drawing.Point(6, 20);
            this.stringType.Name = "stringType";
            this.stringType.Size = new System.Drawing.Size(54, 16);
            this.stringType.TabIndex = 3;
            this.stringType.TabStop = true;
            this.stringType.Text = "string";
            this.stringType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property Value";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(139, 33);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 21);
            this.valueInput.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(245, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 48);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // JsonPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 156);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "JsonPropertyForm";
            this.Text = "JsonPropertyForm";
            this.Load += new System.EventHandler(this.JsonPropertyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stringType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.RadioButton doubleType;
        private System.Windows.Forms.RadioButton intType;
        private System.Windows.Forms.Button okButton;
    }
}