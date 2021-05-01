
namespace FormsUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwTasks = new System.Windows.Forms.DataGridView();
            this.gbxEditList = new System.Windows.Forms.GroupBox();
            this.gbxUpdateTask = new System.Windows.Forms.GroupBox();
            this.tbxReminderDateUpdate = new System.Windows.Forms.TextBox();
            this.lblReminderDateUpdate = new System.Windows.Forms.Label();
            this.cbxPriorityUpdate = new System.Windows.Forms.ComboBox();
            this.cbxStatusUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDetailsUpdate = new System.Windows.Forms.Label();
            this.tbxDetailsUpdate = new System.Windows.Forms.TextBox();
            this.tbxDueDateUpdate = new System.Windows.Forms.TextBox();
            this.tbxTaskNameUpdate = new System.Windows.Forms.TextBox();
            this.lblDueDateUpdate = new System.Windows.Forms.Label();
            this.lblPriorityUpdate = new System.Windows.Forms.Label();
            this.lblStatusUpdate = new System.Windows.Forms.Label();
            this.lblTaskNameUpdate = new System.Windows.Forms.Label();
            this.gbxAddTask = new System.Windows.Forms.GroupBox();
            this.tbxReminderDateAdd = new System.Windows.Forms.TextBox();
            this.lblReminderDateAdd = new System.Windows.Forms.Label();
            this.cbxStatusAdd = new System.Windows.Forms.ComboBox();
            this.cbxPriorityAdd = new System.Windows.Forms.ComboBox();
            this.lblDetailsAdd = new System.Windows.Forms.Label();
            this.tbxDueDateAdd = new System.Windows.Forms.TextBox();
            this.tbxDetailsAdd = new System.Windows.Forms.TextBox();
            this.tbxTaskNameAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDueDateAdd = new System.Windows.Forms.Label();
            this.lblPriorityAdd = new System.Windows.Forms.Label();
            this.lblStatusAdd = new System.Windows.Forms.Label();
            this.lblTaskNameAdd = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearchByPriority = new System.Windows.Forms.Label();
            this.cbxSearchByPriority = new System.Windows.Forms.ComboBox();
            this.cbxSearchByStatus = new System.Windows.Forms.ComboBox();
            this.lblSearchByStatus = new System.Windows.Forms.Label();
            this.gbxReminder = new System.Windows.Forms.GroupBox();
            this.lblReminder = new System.Windows.Forms.Label();
            this.tbxReminder = new System.Windows.Forms.TextBox();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTasks)).BeginInit();
            this.gbxEditList.SuspendLayout();
            this.gbxUpdateTask.SuspendLayout();
            this.gbxAddTask.SuspendLayout();
            this.gbxReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTasks
            // 
            this.dgwTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTasks.Location = new System.Drawing.Point(21, 58);
            this.dgwTasks.Name = "dgwTasks";
            this.dgwTasks.Size = new System.Drawing.Size(753, 127);
            this.dgwTasks.TabIndex = 2;
            this.dgwTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTasks_CellClick);
            // 
            // gbxEditList
            // 
            this.gbxEditList.Controls.Add(this.gbxUpdateTask);
            this.gbxEditList.Controls.Add(this.gbxAddTask);
            this.gbxEditList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditList.Location = new System.Drawing.Point(21, 191);
            this.gbxEditList.Name = "gbxEditList";
            this.gbxEditList.Size = new System.Drawing.Size(567, 295);
            this.gbxEditList.TabIndex = 3;
            this.gbxEditList.TabStop = false;
            this.gbxEditList.Text = "Edit List";
            // 
            // gbxUpdateTask
            // 
            this.gbxUpdateTask.Controls.Add(this.tbxReminderDateUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblReminderDateUpdate);
            this.gbxUpdateTask.Controls.Add(this.cbxPriorityUpdate);
            this.gbxUpdateTask.Controls.Add(this.cbxStatusUpdate);
            this.gbxUpdateTask.Controls.Add(this.btnUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblDetailsUpdate);
            this.gbxUpdateTask.Controls.Add(this.tbxDetailsUpdate);
            this.gbxUpdateTask.Controls.Add(this.tbxDueDateUpdate);
            this.gbxUpdateTask.Controls.Add(this.tbxTaskNameUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblDueDateUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblPriorityUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblStatusUpdate);
            this.gbxUpdateTask.Controls.Add(this.lblTaskNameUpdate);
            this.gbxUpdateTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateTask.Location = new System.Drawing.Point(12, 158);
            this.gbxUpdateTask.Name = "gbxUpdateTask";
            this.gbxUpdateTask.Size = new System.Drawing.Size(533, 130);
            this.gbxUpdateTask.TabIndex = 17;
            this.gbxUpdateTask.TabStop = false;
            this.gbxUpdateTask.Text = "Edit Task";
            // 
            // tbxReminderDateUpdate
            // 
            this.tbxReminderDateUpdate.Location = new System.Drawing.Point(269, 88);
            this.tbxReminderDateUpdate.Name = "tbxReminderDateUpdate";
            this.tbxReminderDateUpdate.Size = new System.Drawing.Size(106, 22);
            this.tbxReminderDateUpdate.TabIndex = 20;
            // 
            // lblReminderDateUpdate
            // 
            this.lblReminderDateUpdate.AutoSize = true;
            this.lblReminderDateUpdate.Location = new System.Drawing.Point(206, 85);
            this.lblReminderDateUpdate.Name = "lblReminderDateUpdate";
            this.lblReminderDateUpdate.Size = new System.Drawing.Size(63, 32);
            this.lblReminderDateUpdate.TabIndex = 20;
            this.lblReminderDateUpdate.Text = "Reminder\r\n   Time";
            // 
            // cbxPriorityUpdate
            // 
            this.cbxPriorityUpdate.FormattingEnabled = true;
            this.cbxPriorityUpdate.Location = new System.Drawing.Point(70, 85);
            this.cbxPriorityUpdate.Name = "cbxPriorityUpdate";
            this.cbxPriorityUpdate.Size = new System.Drawing.Size(106, 24);
            this.cbxPriorityUpdate.TabIndex = 18;
            // 
            // cbxStatusUpdate
            // 
            this.cbxStatusUpdate.FormattingEnabled = true;
            this.cbxStatusUpdate.Location = new System.Drawing.Point(70, 55);
            this.cbxStatusUpdate.Name = "cbxStatusUpdate";
            this.cbxStatusUpdate.Size = new System.Drawing.Size(106, 24);
            this.cbxStatusUpdate.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11.55F);
            this.btnUpdate.Location = new System.Drawing.Point(402, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDetailsUpdate
            // 
            this.lblDetailsUpdate.AutoSize = true;
            this.lblDetailsUpdate.Location = new System.Drawing.Point(208, 55);
            this.lblDetailsUpdate.Name = "lblDetailsUpdate";
            this.lblDetailsUpdate.Size = new System.Drawing.Size(48, 16);
            this.lblDetailsUpdate.TabIndex = 16;
            this.lblDetailsUpdate.Text = "Details";
            // 
            // tbxDetailsUpdate
            // 
            this.tbxDetailsUpdate.Location = new System.Drawing.Point(269, 57);
            this.tbxDetailsUpdate.Name = "tbxDetailsUpdate";
            this.tbxDetailsUpdate.Size = new System.Drawing.Size(106, 22);
            this.tbxDetailsUpdate.TabIndex = 15;
            // 
            // tbxDueDateUpdate
            // 
            this.tbxDueDateUpdate.Location = new System.Drawing.Point(269, 27);
            this.tbxDueDateUpdate.Name = "tbxDueDateUpdate";
            this.tbxDueDateUpdate.Size = new System.Drawing.Size(106, 22);
            this.tbxDueDateUpdate.TabIndex = 14;
            // 
            // tbxTaskNameUpdate
            // 
            this.tbxTaskNameUpdate.Location = new System.Drawing.Point(70, 27);
            this.tbxTaskNameUpdate.Name = "tbxTaskNameUpdate";
            this.tbxTaskNameUpdate.Size = new System.Drawing.Size(106, 22);
            this.tbxTaskNameUpdate.TabIndex = 10;
            // 
            // lblDueDateUpdate
            // 
            this.lblDueDateUpdate.AutoSize = true;
            this.lblDueDateUpdate.Location = new System.Drawing.Point(208, 27);
            this.lblDueDateUpdate.Name = "lblDueDateUpdate";
            this.lblDueDateUpdate.Size = new System.Drawing.Size(62, 16);
            this.lblDueDateUpdate.TabIndex = 8;
            this.lblDueDateUpdate.Text = "Due Date";
            // 
            // lblPriorityUpdate
            // 
            this.lblPriorityUpdate.AutoSize = true;
            this.lblPriorityUpdate.Location = new System.Drawing.Point(16, 88);
            this.lblPriorityUpdate.Name = "lblPriorityUpdate";
            this.lblPriorityUpdate.Size = new System.Drawing.Size(49, 16);
            this.lblPriorityUpdate.TabIndex = 7;
            this.lblPriorityUpdate.Text = "Priority";
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Location = new System.Drawing.Point(16, 58);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(46, 16);
            this.lblStatusUpdate.TabIndex = 5;
            this.lblStatusUpdate.Text = "Status";
            // 
            // lblTaskNameUpdate
            // 
            this.lblTaskNameUpdate.AutoSize = true;
            this.lblTaskNameUpdate.Location = new System.Drawing.Point(19, 30);
            this.lblTaskNameUpdate.Name = "lblTaskNameUpdate";
            this.lblTaskNameUpdate.Size = new System.Drawing.Size(35, 16);
            this.lblTaskNameUpdate.TabIndex = 4;
            this.lblTaskNameUpdate.Text = "Task";
            // 
            // gbxAddTask
            // 
            this.gbxAddTask.Controls.Add(this.tbxReminderDateAdd);
            this.gbxAddTask.Controls.Add(this.lblReminderDateAdd);
            this.gbxAddTask.Controls.Add(this.cbxStatusAdd);
            this.gbxAddTask.Controls.Add(this.cbxPriorityAdd);
            this.gbxAddTask.Controls.Add(this.lblDetailsAdd);
            this.gbxAddTask.Controls.Add(this.tbxDueDateAdd);
            this.gbxAddTask.Controls.Add(this.tbxDetailsAdd);
            this.gbxAddTask.Controls.Add(this.tbxTaskNameAdd);
            this.gbxAddTask.Controls.Add(this.btnAdd);
            this.gbxAddTask.Controls.Add(this.lblDueDateAdd);
            this.gbxAddTask.Controls.Add(this.lblPriorityAdd);
            this.gbxAddTask.Controls.Add(this.lblStatusAdd);
            this.gbxAddTask.Controls.Add(this.lblTaskNameAdd);
            this.gbxAddTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddTask.Location = new System.Drawing.Point(12, 24);
            this.gbxAddTask.Name = "gbxAddTask";
            this.gbxAddTask.Size = new System.Drawing.Size(533, 128);
            this.gbxAddTask.TabIndex = 0;
            this.gbxAddTask.TabStop = false;
            this.gbxAddTask.Text = "Add Task";
            // 
            // tbxReminderDateAdd
            // 
            this.tbxReminderDateAdd.Location = new System.Drawing.Point(269, 85);
            this.tbxReminderDateAdd.Name = "tbxReminderDateAdd";
            this.tbxReminderDateAdd.Size = new System.Drawing.Size(106, 22);
            this.tbxReminderDateAdd.TabIndex = 19;
            // 
            // lblReminderDateAdd
            // 
            this.lblReminderDateAdd.AutoSize = true;
            this.lblReminderDateAdd.Location = new System.Drawing.Point(206, 85);
            this.lblReminderDateAdd.Name = "lblReminderDateAdd";
            this.lblReminderDateAdd.Size = new System.Drawing.Size(63, 32);
            this.lblReminderDateAdd.TabIndex = 18;
            this.lblReminderDateAdd.Text = "Reminder\r\n   Time";
            // 
            // cbxStatusAdd
            // 
            this.cbxStatusAdd.FormattingEnabled = true;
            this.cbxStatusAdd.Location = new System.Drawing.Point(70, 55);
            this.cbxStatusAdd.Name = "cbxStatusAdd";
            this.cbxStatusAdd.Size = new System.Drawing.Size(106, 24);
            this.cbxStatusAdd.TabIndex = 17;
            // 
            // cbxPriorityAdd
            // 
            this.cbxPriorityAdd.FormattingEnabled = true;
            this.cbxPriorityAdd.Location = new System.Drawing.Point(70, 85);
            this.cbxPriorityAdd.Name = "cbxPriorityAdd";
            this.cbxPriorityAdd.Size = new System.Drawing.Size(106, 24);
            this.cbxPriorityAdd.TabIndex = 9;
            // 
            // lblDetailsAdd
            // 
            this.lblDetailsAdd.AutoSize = true;
            this.lblDetailsAdd.Location = new System.Drawing.Point(212, 58);
            this.lblDetailsAdd.Name = "lblDetailsAdd";
            this.lblDetailsAdd.Size = new System.Drawing.Size(48, 16);
            this.lblDetailsAdd.TabIndex = 16;
            this.lblDetailsAdd.Text = "Details";
            // 
            // tbxDueDateAdd
            // 
            this.tbxDueDateAdd.Location = new System.Drawing.Point(269, 24);
            this.tbxDueDateAdd.Name = "tbxDueDateAdd";
            this.tbxDueDateAdd.Size = new System.Drawing.Size(106, 22);
            this.tbxDueDateAdd.TabIndex = 14;
            // 
            // tbxDetailsAdd
            // 
            this.tbxDetailsAdd.Location = new System.Drawing.Point(269, 55);
            this.tbxDetailsAdd.Name = "tbxDetailsAdd";
            this.tbxDetailsAdd.Size = new System.Drawing.Size(106, 22);
            this.tbxDetailsAdd.TabIndex = 15;
            // 
            // tbxTaskNameAdd
            // 
            this.tbxTaskNameAdd.Location = new System.Drawing.Point(70, 27);
            this.tbxTaskNameAdd.Name = "tbxTaskNameAdd";
            this.tbxTaskNameAdd.Size = new System.Drawing.Size(106, 22);
            this.tbxTaskNameAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11.55F);
            this.btnAdd.Location = new System.Drawing.Point(402, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDueDateAdd
            // 
            this.lblDueDateAdd.AutoSize = true;
            this.lblDueDateAdd.Location = new System.Drawing.Point(208, 27);
            this.lblDueDateAdd.Name = "lblDueDateAdd";
            this.lblDueDateAdd.Size = new System.Drawing.Size(62, 16);
            this.lblDueDateAdd.TabIndex = 8;
            this.lblDueDateAdd.Text = "Due Date";
            // 
            // lblPriorityAdd
            // 
            this.lblPriorityAdd.AutoSize = true;
            this.lblPriorityAdd.Location = new System.Drawing.Point(15, 88);
            this.lblPriorityAdd.Name = "lblPriorityAdd";
            this.lblPriorityAdd.Size = new System.Drawing.Size(49, 16);
            this.lblPriorityAdd.TabIndex = 7;
            this.lblPriorityAdd.Text = "Priority";
            // 
            // lblStatusAdd
            // 
            this.lblStatusAdd.AutoSize = true;
            this.lblStatusAdd.Location = new System.Drawing.Point(16, 58);
            this.lblStatusAdd.Name = "lblStatusAdd";
            this.lblStatusAdd.Size = new System.Drawing.Size(46, 16);
            this.lblStatusAdd.TabIndex = 5;
            this.lblStatusAdd.Text = "Status";
            // 
            // lblTaskNameAdd
            // 
            this.lblTaskNameAdd.AutoSize = true;
            this.lblTaskNameAdd.Location = new System.Drawing.Point(19, 30);
            this.lblTaskNameAdd.Name = "lblTaskNameAdd";
            this.lblTaskNameAdd.Size = new System.Drawing.Size(35, 16);
            this.lblTaskNameAdd.TabIndex = 4;
            this.lblTaskNameAdd.Text = "Task";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.55F);
            this.btnDelete.Location = new System.Drawing.Point(633, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 37);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearchByPriority
            // 
            this.lblSearchByPriority.AutoSize = true;
            this.lblSearchByPriority.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByPriority.Location = new System.Drawing.Point(326, 18);
            this.lblSearchByPriority.Name = "lblSearchByPriority";
            this.lblSearchByPriority.Size = new System.Drawing.Size(112, 16);
            this.lblSearchByPriority.TabIndex = 5;
            this.lblSearchByPriority.Text = "Search by Priority";
            // 
            // cbxSearchByPriority
            // 
            this.cbxSearchByPriority.FormattingEnabled = true;
            this.cbxSearchByPriority.Location = new System.Drawing.Point(445, 17);
            this.cbxSearchByPriority.Name = "cbxSearchByPriority";
            this.cbxSearchByPriority.Size = new System.Drawing.Size(137, 21);
            this.cbxSearchByPriority.TabIndex = 6;
            this.cbxSearchByPriority.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByPriority_SelectedIndexChanged);
            // 
            // cbxSearchByStatus
            // 
            this.cbxSearchByStatus.FormattingEnabled = true;
            this.cbxSearchByStatus.Location = new System.Drawing.Point(132, 17);
            this.cbxSearchByStatus.Name = "cbxSearchByStatus";
            this.cbxSearchByStatus.Size = new System.Drawing.Size(137, 21);
            this.cbxSearchByStatus.TabIndex = 7;
            this.cbxSearchByStatus.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByStatus_SelectedIndexChanged);
            // 
            // lblSearchByStatus
            // 
            this.lblSearchByStatus.AutoSize = true;
            this.lblSearchByStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByStatus.Location = new System.Drawing.Point(18, 18);
            this.lblSearchByStatus.Name = "lblSearchByStatus";
            this.lblSearchByStatus.Size = new System.Drawing.Size(109, 16);
            this.lblSearchByStatus.TabIndex = 8;
            this.lblSearchByStatus.Text = "Search by Status\r\n";
            // 
            // gbxReminder
            // 
            this.gbxReminder.Controls.Add(this.btnStart);
            this.gbxReminder.Controls.Add(this.btnStop);
            this.gbxReminder.Controls.Add(this.lblReminder);
            this.gbxReminder.Controls.Add(this.tbxReminder);
            this.gbxReminder.Controls.Add(this.lblDateTimeNow);
            this.gbxReminder.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReminder.Location = new System.Drawing.Point(605, 191);
            this.gbxReminder.Name = "gbxReminder";
            this.gbxReminder.Size = new System.Drawing.Size(307, 295);
            this.gbxReminder.TabIndex = 9;
            this.gbxReminder.TabStop = false;
            this.gbxReminder.Text = "Reminder Alarm";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 11.75F);
            this.lblReminder.Location = new System.Drawing.Point(6, 121);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(114, 18);
            this.lblReminder.TabIndex = 2;
            this.lblReminder.Text = "Reminder Time";
            // 
            // tbxReminder
            // 
            this.tbxReminder.Location = new System.Drawing.Point(126, 114);
            this.tbxReminder.Name = "tbxReminder";
            this.tbxReminder.Size = new System.Drawing.Size(159, 27);
            this.tbxReminder.TabIndex = 1;
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.AutoSize = true;
            this.lblDateTimeNow.Font = new System.Drawing.Font("Arial", 17.75F);
            this.lblDateTimeNow.Location = new System.Drawing.Point(37, 50);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(71, 27);
            this.lblDateTimeNow.TabIndex = 0;
            this.lblDateTimeNow.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 14.75F);
            this.btnStop.Location = new System.Drawing.Point(174, 171);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 38);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 14.75F);
            this.btnStart.Location = new System.Drawing.Point(28, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 505);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxReminder);
            this.Controls.Add(this.lblSearchByStatus);
            this.Controls.Add(this.cbxSearchByStatus);
            this.Controls.Add(this.cbxSearchByPriority);
            this.Controls.Add(this.lblSearchByPriority);
            this.Controls.Add(this.gbxEditList);
            this.Controls.Add(this.dgwTasks);
            this.Name = "Form1";
            this.Text = "To do Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTasks)).EndInit();
            this.gbxEditList.ResumeLayout(false);
            this.gbxUpdateTask.ResumeLayout(false);
            this.gbxUpdateTask.PerformLayout();
            this.gbxAddTask.ResumeLayout(false);
            this.gbxAddTask.PerformLayout();
            this.gbxReminder.ResumeLayout(false);
            this.gbxReminder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwTasks;
        private System.Windows.Forms.GroupBox gbxEditList;
        private System.Windows.Forms.GroupBox gbxAddTask;
        private System.Windows.Forms.TextBox tbxDueDateAdd;
        private System.Windows.Forms.TextBox tbxTaskNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDueDateAdd;
        private System.Windows.Forms.Label lblPriorityAdd;
        private System.Windows.Forms.Label lblStatusAdd;
        private System.Windows.Forms.Label lblTaskNameAdd;
        private System.Windows.Forms.Label lblDetailsAdd;
        private System.Windows.Forms.TextBox tbxDetailsAdd;
        private System.Windows.Forms.GroupBox gbxUpdateTask;
        private System.Windows.Forms.Label lblDetailsUpdate;
        private System.Windows.Forms.TextBox tbxDetailsUpdate;
        private System.Windows.Forms.TextBox tbxDueDateUpdate;
        private System.Windows.Forms.TextBox tbxTaskNameUpdate;
        private System.Windows.Forms.Label lblDueDateUpdate;
        private System.Windows.Forms.Label lblPriorityUpdate;
        private System.Windows.Forms.Label lblStatusUpdate;
        private System.Windows.Forms.Label lblTaskNameUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxPriorityUpdate;
        private System.Windows.Forms.ComboBox cbxStatusUpdate;
        private System.Windows.Forms.ComboBox cbxStatusAdd;
        private System.Windows.Forms.ComboBox cbxPriorityAdd;
        private System.Windows.Forms.Label lblSearchByPriority;
        private System.Windows.Forms.ComboBox cbxSearchByPriority;
        private System.Windows.Forms.ComboBox cbxSearchByStatus;
        private System.Windows.Forms.Label lblSearchByStatus;
        private System.Windows.Forms.Label lblReminderDateAdd;
        private System.Windows.Forms.TextBox tbxReminderDateAdd;
        private System.Windows.Forms.TextBox tbxReminderDateUpdate;
        private System.Windows.Forms.Label lblReminderDateUpdate;
        private System.Windows.Forms.GroupBox gbxReminder;
        private System.Windows.Forms.Label lblDateTimeNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.TextBox tbxReminder;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

