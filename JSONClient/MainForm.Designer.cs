namespace JSONClient {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.savedJsonListView = new System.Windows.Forms.ListBox();
            this.eventLogView = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.currentJsonView = new System.Windows.Forms.ListView();
            this.propertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removePropertyButton = new System.Windows.Forms.Button();
            this.savedJsonView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.receivedDataListView = new System.Windows.Forms.ListBox();
            this.receivedDataView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(45, 10);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(100, 21);
            this.ipInput.TabIndex = 2;
            this.ipInput.Text = "127.0.0.1";
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(45, 37);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(100, 21);
            this.portInput.TabIndex = 3;
            this.portInput.Text = "8762";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectButton.Location = new System.Drawing.Point(151, 10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(86, 21);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // savedJsonListView
            // 
            this.savedJsonListView.FormattingEnabled = true;
            this.savedJsonListView.ItemHeight = 12;
            this.savedJsonListView.Location = new System.Drawing.Point(242, 83);
            this.savedJsonListView.Name = "savedJsonListView";
            this.savedJsonListView.Size = new System.Drawing.Size(110, 208);
            this.savedJsonListView.TabIndex = 7;
            this.savedJsonListView.SelectedIndexChanged += new System.EventHandler(this.savedJsonListView_SelectedIndexChanged);
            this.savedJsonListView.DoubleClick += new System.EventHandler(this.savedJsonListView_DoubleClick);
            // 
            // eventLogView
            // 
            this.eventLogView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLogView.Location = new System.Drawing.Point(14, 83);
            this.eventLogView.Multiline = true;
            this.eventLogView.Name = "eventLogView";
            this.eventLogView.ReadOnly = true;
            this.eventLogView.Size = new System.Drawing.Size(223, 435);
            this.eventLogView.TabIndex = 9;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.disconnectButton.Location = new System.Drawing.Point(151, 37);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(86, 21);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(589, 310);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(25, 25);
            this.addPropertyButton.TabIndex = 12;
            this.addPropertyButton.Text = "+";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(589, 491);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(25, 25);
            this.sendButton.TabIndex = 14;
            this.sendButton.Text = "S";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // currentJsonView
            // 
            this.currentJsonView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propertyName,
            this.propertyValue,
            this.propertyType});
            this.currentJsonView.Location = new System.Drawing.Point(358, 310);
            this.currentJsonView.MultiSelect = false;
            this.currentJsonView.Name = "currentJsonView";
            this.currentJsonView.Size = new System.Drawing.Size(225, 208);
            this.currentJsonView.TabIndex = 17;
            this.currentJsonView.UseCompatibleStateImageBehavior = false;
            this.currentJsonView.View = System.Windows.Forms.View.Details;
            this.currentJsonView.DoubleClick += new System.EventHandler(this.currentJsonView_DoubleClick);
            // 
            // propertyName
            // 
            this.propertyName.Text = "Name";
            this.propertyName.Width = 80;
            // 
            // propertyValue
            // 
            this.propertyValue.Text = "Value";
            this.propertyValue.Width = 80;
            // 
            // propertyType
            // 
            this.propertyType.Text = "Type";
            // 
            // removePropertyButton
            // 
            this.removePropertyButton.Location = new System.Drawing.Point(589, 341);
            this.removePropertyButton.Name = "removePropertyButton";
            this.removePropertyButton.Size = new System.Drawing.Size(25, 25);
            this.removePropertyButton.TabIndex = 18;
            this.removePropertyButton.Text = "-";
            this.removePropertyButton.UseVisualStyleBackColor = true;
            this.removePropertyButton.Click += new System.EventHandler(this.removePropertyButton_Click);
            // 
            // savedJsonView
            // 
            this.savedJsonView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.savedJsonView.Location = new System.Drawing.Point(358, 83);
            this.savedJsonView.Name = "savedJsonView";
            this.savedJsonView.Size = new System.Drawing.Size(225, 208);
            this.savedJsonView.TabIndex = 19;
            this.savedJsonView.UseCompatibleStateImageBehavior = false;
            this.savedJsonView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // receivedDataListView
            // 
            this.receivedDataListView.FormattingEnabled = true;
            this.receivedDataListView.ItemHeight = 12;
            this.receivedDataListView.Location = new System.Drawing.Point(620, 83);
            this.receivedDataListView.Name = "receivedDataListView";
            this.receivedDataListView.Size = new System.Drawing.Size(110, 208);
            this.receivedDataListView.TabIndex = 20;
            this.receivedDataListView.SelectedIndexChanged += new System.EventHandler(this.receivedDataListView_SelectedIndexChanged);
            // 
            // receivedDataView
            // 
            this.receivedDataView.Location = new System.Drawing.Point(736, 83);
            this.receivedDataView.Multiline = true;
            this.receivedDataView.Name = "receivedDataView";
            this.receivedDataView.Size = new System.Drawing.Size(225, 208);
            this.receivedDataView.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Send Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Receive Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Event Log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.receivedDataView);
            this.Controls.Add(this.receivedDataListView);
            this.Controls.Add(this.savedJsonView);
            this.Controls.Add(this.removePropertyButton);
            this.Controls.Add(this.currentJsonView);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.eventLogView);
            this.Controls.Add(this.savedJsonListView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.ipInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox savedJsonListView;
        private System.Windows.Forms.TextBox eventLogView;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListView currentJsonView;
        private System.Windows.Forms.ColumnHeader propertyName;
        private System.Windows.Forms.ColumnHeader propertyValue;
        private System.Windows.Forms.ColumnHeader propertyType;
        private System.Windows.Forms.Button removePropertyButton;
        private System.Windows.Forms.ListView savedJsonView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox receivedDataListView;
        private System.Windows.Forms.TextBox receivedDataView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

