using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using Tulpep.NotificationWindow;
using System.Media;

namespace FormsUI
{
    public partial class Form1 : Form
    {
       
        private IPriorityService _priorityService;
        private ITaskService _taskService;
        private IStatusService _statusService;
        

        public Form1()
        {
            _taskService = InstanceFactory.GetInstance<ITaskService>();
            _priorityService = InstanceFactory.GetInstance<IPriorityService>();
            _statusService = InstanceFactory.GetInstance<IStatusService>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
            LoadPriorities();
            LoadStatuses();
        }

        private void LoadPriorities()
        {
            cbxSearchByPriority.DataSource = _priorityService.GetAll();
            cbxSearchByPriority.DisplayMember = "PriorityName";
            cbxSearchByPriority.ValueMember = "PriorityId";
            cbxSearchByPriority.Text = "Choose priority";

            cbxPriorityAdd.DataSource = _priorityService.GetAll();
            cbxPriorityAdd.DisplayMember = "PriorityName";
            cbxPriorityAdd.ValueMember = "PriorityId";

            cbxPriorityUpdate.DataSource = _priorityService.GetAll();
            cbxPriorityUpdate.DisplayMember = "PriorityName";
            cbxPriorityUpdate.ValueMember = "PriorityId";

            
        }

        private void LoadStatuses()
        {
            cbxSearchByStatus.DataSource = _statusService.GetAll();
            cbxSearchByStatus.DisplayMember = "StatusName";
            cbxSearchByStatus.ValueMember = "StatusId";
            cbxSearchByStatus.Text = "Choose status";


            cbxStatusAdd.DataSource = _statusService.GetAll();
            cbxStatusAdd.DisplayMember = "StatusName";
            cbxStatusAdd.ValueMember = "StatusId";

            cbxStatusUpdate.DataSource = _statusService.GetAll();
            cbxStatusUpdate.DisplayMember = "StatusName";
            cbxStatusUpdate.ValueMember = "StatusId";




        }
        private void LoadTasks()
        {
            dgwTasks.DataSource = _taskService.GetTaskDetails();
        }

        private void cbxSearchByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwTasks.DataSource = _taskService.GetByStatus(Convert.ToInt32(cbxSearchByStatus.SelectedValue));
            }
            catch
            {
                
            }
        }
        private void cbxSearchByPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwTasks.DataSource = _taskService.GetByPriority(Convert.ToInt32(cbxSearchByPriority.SelectedValue));
                
            }
            catch 
            {
               
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _taskService.Add(new Task
                {
                    TaskName = tbxTaskNameAdd.Text,
                    StatusId = Convert.ToInt32(cbxStatusAdd.SelectedValue),
                    PriorityId = Convert.ToInt32(cbxPriorityAdd.SelectedValue),
                    DueDate = Convert.ToDateTime(tbxDueDateAdd.Text),
                    Details = tbxDetailsAdd.Text,
                    ReminderDate = Convert.ToDateTime(tbxReminderDateAdd.Text)

                });
                MessageBox.Show("New task added!", "Message");
                LoadTasks();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _taskService.Update(new Task
            {
                Id = Convert.ToInt32(dgwTasks.CurrentRow.Cells[0].Value),
                TaskName = tbxTaskNameUpdate.Text,
                StatusId = Convert.ToInt32(cbxStatusUpdate.SelectedValue),
                PriorityId = Convert.ToInt32(cbxPriorityUpdate.SelectedValue),
                DueDate = Convert.ToDateTime(tbxDueDateUpdate.Text),
                Details = tbxDetailsUpdate.Text,
                ReminderDate = Convert.ToDateTime(tbxReminderDateUpdate.Text)
            });
            MessageBox.Show("Task updated!", "Message");
            LoadTasks();
        }

        private void dgwTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dgwTasks.CurrentRow.Cells;
            tbxTaskNameUpdate.Text = temp[1].Value.ToString();
            cbxStatusUpdate.SelectedValue = temp[2].Value;
            cbxPriorityUpdate.SelectedValue = temp[3].Value;
            DateTime.Parse(tbxDueDateUpdate.Text = temp[4].Value.ToString());
            tbxDetailsUpdate.Text = temp[5].Value.ToString();
            DateTime.Parse(tbxReminderDateUpdate.Text = temp[6].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _taskService.Delete(new Task
            {
                Id = Convert.ToInt32(dgwTasks.CurrentRow.Cells[0].Value)
            });

            MessageBox.Show("Task deleted!", "Message");
            LoadTasks();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimeNow.Text = DateTime.Now.ToShortDateString()+" "+ DateTime.Now.ToLongTimeString();
        }

        SoundPlayer sound = new SoundPlayer();
        private void timer2_Tick(object sender, EventArgs e)
        {
            tbxReminder.Text = dgwTasks.CurrentRow.Cells[6].Value.ToString();
            if (lblDateTimeNow.Text == tbxReminder.Text)
            {
                sound.SoundLocation = "alarm.wav";
                sound.Play();
                var text = dgwTasks.CurrentRow.Cells[1].Value.ToString()+ " task not completed!";
                MessageBox.Show(text,"Reminder Message");
            }
        }

        

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            sound.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }

}
