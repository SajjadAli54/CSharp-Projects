using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQlLinq
{
    public partial class Form : System.Windows.Forms.Form
    {
        
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            getData();
        }

        void getData()
        {
            DataClassesDataContext context = new DataClassesDataContext();
            listBox.Items.Clear();
            var data = from user in context.Usernames select user;
            listBox.Items.AddRange(data.ToArray<Username>());
            context.Dispose();
            listBox.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Username user = listBox.SelectedItem as Username;
            txtId.Text = user.Id + "";
            txtUsername.Text = user.Username1;
            txtPassword.Text = user.Password;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataClassesDataContext context = new DataClassesDataContext();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Username user = new Username();
            user.Id = (from obj in context.Usernames
                       orderby obj.Id descending
                       select obj.Id + 1).First();

            user.Username1 = username;
            user.Password = password;

            context.Usernames.InsertOnSubmit(user);
            context.SubmitChanges();
            context.Dispose();
            MessageBox.Show("Record added");
            getData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataClassesDataContext context = new DataClassesDataContext();
            int id = int.Parse(txtId.Text);
            Username username = (from user in context.Usernames
                                where user.Id == id
                                select user).First();
            username.Username1 = txtUsername.Text;
            username.Password = txtPassword.Text;

            context.SubmitChanges();
            context.Dispose();
            getData();
            MessageBox.Show("Updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            using(var context = new DataClassesDataContext())
            {
                var user = context.Usernames.SingleOrDefault<Username>(record => record.Id == id);
                context.Usernames.DeleteOnSubmit(user);
                context.SubmitChanges();
                MessageBox.Show("Deleted record");
                getData();
            }
        }
    }
}
