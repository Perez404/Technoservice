using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Technosevice.Classes;
using Technosevice.View;

namespace Technosevice
{
    public partial class Authorizathion : Form
    {
        public Authorizathion()
        {
            InitializeComponent();

            try
            {
                Helper.DBRequest = new Model.DBConnectRequest();
                MessageBox.Show("Соединнение есть");
            }
            catch
            {
                MessageBox.Show("Соединения нет");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login, password;
            Table form2 = new Table();
            login = textBox1.Text;
            password = textBox2.Text;
            List<Model.User> users = Classes.Helper.DBRequest.User.ToList();
            Model.User user = null;
            foreach (Model.User u in users)
            {
                if (u.UserLogin == login && u.UserPassword == password)
                {
                    user = u;
                }
                if (user != null)
                {
                    MessageBox.Show("Найдено. Вы вошли с ролью" + " " + user.Role.RoleName);
                    this.Hide();
                    form2.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Не найдено");
                    break;
                }
            }
        }
    }
}
