using StudentInfo.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace StudentInfo
{

    public partial class frmStudent : Form
    {
        private List<Student> studentlists = new List<Student>();

        public frmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
           /*dGVStudentList.Rows.Add(txtId.Text, 
                                    txtFirstName.Text,
                                    txtLastName.Text, 
                                    txtBirthDate.Text, 
                                    txtAddress.Text,
                                    deptComboBox.Text); */

           studentlists.Add(new Student(txtId.Text,txtFirstName.Text,txtLastName.Text,
                                       txtBirthDate.Text,txtAddress.Text, deptComboBox.Text));



           dGVStudentList.Columns.Clear();
            var columns = from std in studentlists
                          orderby std.firstName ascending
                          select new {
                                        StudentId = std.studentid,
                                        std.firstName,
                                        std.lastName,
                                        std.birthDate,
                                        std.address,
                                        std.dept
                          };

            dGVStudentList.DataSource = columns.ToList();
            clearFields();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = SearchTextBox.Text;

            var columns = from std in studentlists
                          where std.firstName == name
                          orderby std.firstName ascending
                          select new
                          {
                              StudentId = std.studentid,
                              std.firstName,
                              std.lastName,
                              std.birthDate,
                              std.address,
                              std.dept
                          };

            dGVStudentList.Columns.Clear();
            dGVStudentList.DataSource = columns.ToList();

        }

        public void clearFields()
        {
            foreach(Control ctrl in this.Controls){
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
