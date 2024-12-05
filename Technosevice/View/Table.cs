using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Technosevice.Model;

namespace Technosevice.View
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }


        public void ShowRequest(List<Model.Request> requests)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (Model.Request request in requests)
            {
                this.dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = request.RequestId;
                dataGridView1.Rows[i].Cells[1].Value = request.RequestDate;
                dataGridView1.Rows[i].Cells[2].Value = request.RequestDeviceId;
                dataGridView1.Rows[i].Cells[3].Value = request.RequestDefectId;
                dataGridView1.Rows[i].Cells[4].Value = request.RequestClientId;
                dataGridView1.Rows[i].Cells[5].Value = request.RequestDescription;
                dataGridView1.Rows[i].Cells[6].Value = request.RequestStatusId;
                dataGridView1.Rows[i].Cells[7].Value = request.RequestMasterId;
                dataGridView1.Rows[i].Cells[8].Value = request.RequestTime;
                dataGridView1.Rows[i].Cells[9].Value = request.RequestPriorityId;
                dataGridView1.Rows[i].Cells[10].Value = request.RequestStageId;
                dataGridView1.Rows[i].Cells[11].Value = request.RequestComment;
                i++;
            }

        }

        private void Table_Load(object sender, EventArgs e)
        {
            List<Model.Request> requests = Classes.Helper.DBRequest.Request.ToList();
            ShowRequest(requests);

            List<Model.Status> statusList = Classes.Helper.DBRequest.Status.ToList();
            Model.Status status = new Model.Status();
            status.StatusId = 0;
            status.StatusName = "Все статусы";
            statusList.Insert(0, status);
            comboBox1.DataSource = statusList;
            comboBox1.DisplayMember = "StatusName";
            comboBox1.ValueMember = "StatusId";
            comboBox1.SelectedIndex = 0;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Model.Request> requests = Classes.Helper.DBRequest.Request.ToList();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ShowRequest(requests);
                    break;
                case 1:
                    List<Model.Request> filter1 = requests.Where(x => x.RequestStatusId == 1).ToList();
                    ShowRequest(filter1);
                    break;
                case 2:
                    List<Model.Request> filter2 = requests.Where(x => x.RequestStatusId == 2).ToList();
                    ShowRequest(filter2);
                    break;
                case 3:
                    List<Model.Request> filter3 = requests.Where(x => x.RequestStatusId == 3).ToList();
                    ShowRequest(filter3);
                    break;
            }
        }
    }
}
