namespace CeilInn1
{
    partial class RoomEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.cbxRoomTypes = new System.Windows.Forms.ComboBox();
            this.cbxBedTypes = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cbxOccupanciesStatus = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtRoomNumber
            // 
            resources.ApplyResources(this.txtRoomNumber, "txtRoomNumber");
            this.txtRoomNumber.Name = "txtRoomNumber";
            // 
            // cbxRoomTypes
            // 
            resources.ApplyResources(this.cbxRoomTypes, "cbxRoomTypes");
            this.cbxRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomTypes.FormattingEnabled = true;
            this.cbxRoomTypes.Items.AddRange(new object[] {
            resources.GetString("cbxRoomTypes.Items"),
            resources.GetString("cbxRoomTypes.Items1"),
            resources.GetString("cbxRoomTypes.Items2")});
            this.cbxRoomTypes.Name = "cbxRoomTypes";
            // 
            // cbxBedTypes
            // 
            resources.ApplyResources(this.cbxBedTypes, "cbxBedTypes");
            this.cbxBedTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBedTypes.FormattingEnabled = true;
            this.cbxBedTypes.Items.AddRange(new object[] {
            resources.GetString("cbxBedTypes.Items"),
            resources.GetString("cbxBedTypes.Items1"),
            resources.GetString("cbxBedTypes.Items2"),
            resources.GetString("cbxBedTypes.Items3")});
            this.cbxBedTypes.Name = "cbxBedTypes";
            // 
            // txtRate
            // 
            resources.ApplyResources(this.txtRate, "txtRate");
            this.txtRate.Name = "txtRate";
            // 
            // cbxOccupanciesStatus
            // 
            resources.ApplyResources(this.cbxOccupanciesStatus, "cbxOccupanciesStatus");
            this.cbxOccupanciesStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOccupanciesStatus.FormattingEnabled = true;
            this.cbxOccupanciesStatus.Items.AddRange(new object[] {
            resources.GetString("cbxOccupanciesStatus.Items"),
            resources.GetString("cbxOccupanciesStatus.Items1"),
            resources.GetString("cbxOccupanciesStatus.Items2")});
            this.cbxOccupanciesStatus.Name = "cbxOccupanciesStatus";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RoomEditor
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxOccupanciesStatus);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.cbxBedTypes);
            this.Controls.Add(this.cbxRoomTypes);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomEditor";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRoomNumber;
        public ComboBox cbxRoomTypes;
        public ComboBox cbxBedTypes;
        public TextBox txtRate;
        public ComboBox cbxOccupanciesStatus;
        private Button btnOK;
        private Button btnCancel;
    }
}