using DemoApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppVar1
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var employee = db.Employees.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text);

                if (employee == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    var main = new Main(this);
                    main.Show();
                    this.Hide();
                }
            }
        }
    }
}
