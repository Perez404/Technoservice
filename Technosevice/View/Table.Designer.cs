namespace Technosevice.View
{
    partial class Table
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDefectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestPriorityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestStageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(939, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(988, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestId,
            this.RequestDate,
            this.RequestDeviceId,
            this.RequestDefectId,
            this.RequestClientId,
            this.RequestDescription,
            this.RequestStatusId,
            this.RequestMasterId,
            this.RequestTime,
            this.RequestPriorityId,
            this.RequestStageId,
            this.RequestComment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1412, 279);
            this.dataGridView1.TabIndex = 6;
            // 
            // RequestId
            // 
            this.RequestId.HeaderText = "№";
            this.RequestId.Name = "RequestId";
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "Дата";
            this.RequestDate.Name = "RequestDate";
            // 
            // RequestDeviceId
            // 
            this.RequestDeviceId.HeaderText = "Устройство №";
            this.RequestDeviceId.Name = "RequestDeviceId";
            // 
            // RequestDefectId
            // 
            this.RequestDefectId.HeaderText = "Дефекты №";
            this.RequestDefectId.Name = "RequestDefectId";
            // 
            // RequestClientId
            // 
            this.RequestClientId.HeaderText = "Клиент №";
            this.RequestClientId.Name = "RequestClientId";
            // 
            // RequestDescription
            // 
            this.RequestDescription.HeaderText = "Описание";
            this.RequestDescription.Name = "RequestDescription";
            // 
            // RequestStatusId
            // 
            this.RequestStatusId.HeaderText = "Статус №";
            this.RequestStatusId.Name = "RequestStatusId";
            // 
            // RequestMasterId
            // 
            this.RequestMasterId.HeaderText = "Мастер №";
            this.RequestMasterId.Name = "RequestMasterId";
            // 
            // RequestTime
            // 
            this.RequestTime.HeaderText = "Время";
            this.RequestTime.Name = "RequestTime";
            // 
            // RequestPriorityId
            // 
            this.RequestPriorityId.HeaderText = "Приоритет №";
            this.RequestPriorityId.Name = "RequestPriorityId";
            // 
            // RequestStageId
            // 
            this.RequestStageId.HeaderText = "Этап";
            this.RequestStageId.Name = "RequestStageId";
            // 
            // RequestComment
            // 
            this.RequestComment.HeaderText = "Комментарий";
            this.RequestComment.Name = "RequestComment";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDefectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestPriorityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestComment;
    }
}