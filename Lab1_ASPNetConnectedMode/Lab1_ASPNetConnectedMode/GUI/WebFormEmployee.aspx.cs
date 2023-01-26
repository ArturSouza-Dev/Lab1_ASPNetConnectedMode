using Lab1_ASPNetConnectedMode.BLL;
using Lab1_ASPNetConnectedMode.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1_ASPNetConnectedMode.BLL;
using System.Web.UI.WebControls;
using System.Windows;
using Lab1_ASPNetConnectedMode.DAL;

namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Employee emp = new Employee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string tempInput = "";
            tempInput = txtEmployeeID.Text.Trim();
            if (!Validator.IsValidId(tempInput, 4))
            {
                MessageBox.Show("Student ID must be 4-digit number.", "Invalid Id");
                txtEmployeeID.Text = "";
                txtEmployeeID.Focus();
                return;
            }
            tempInput = txtFirstName.Text.Trim();            
            if (!Validator.IsValidName(tempInput))
            {
                MessageBox.Show("First Name contains letters or space to separate name components.", "Invalid First Name");
                txtFirstName.Text = "";
                txtFirstName.Focus();
                return;
            }
            tempInput = txtLastName.Text.Trim();
            if (!Validator.IsValidName(tempInput))
            {
                MessageBox.Show("Last Name contains letters or space to separate name components.", "Invalid Last Name");
                txtLastName.Text = "";
                txtLastName.Focus();
                return;
            }      
                        
            emp.EmployeeId = Convert.ToInt32(txtEmployeeID.Text);
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.JobTitle = txtJobTitle.Text;
            emp.SaveEmployee();
            MessageBox.Show("Employee saved.");
        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {
            gvEmployees.DataSource = emp.GetEmployees();
            gvEmployees.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (Validator.IsValidId(txtEmployeeID.Text, 4))
            {
                if (Validator.IsValidName(txtFirstName.Text)) { flag += 1; }                                                    
                else if (txtFirstName.Text.Length > 0) { MessageBox.Show("Invalid FirstName input!"); return; }

                if (Validator.IsValidName(txtLastName.Text)) { flag += 2; }
                else if (txtLastName.Text.Length > 0) { MessageBox.Show("Invalid LastName input!"); return; }

                if (Validator.IsValidName(txtJobTitle.Text)) { flag += 4; }
                else if (txtJobTitle.Text.Length > 0) { MessageBox.Show("Invalid JobTitle input!"); return; }

                string msg = "Update completed:\n\n";
                int affectedRows = 0;
                switch (flag)
                {
                    case 1:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtFirstName.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    case 2:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtLastName.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    case 3:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtFirstName.Text, txtLastName.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    case 4:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtJobTitle.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    case 5:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtFirstName.Text, txtJobTitle.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    case 6:
                        affectedRows = emp.UpdateEmployee(txtEmployeeID.Text, txtLastName.Text, txtJobTitle.Text);
                        if (affectedRows > 0) { MessageBox.Show(msg + emp.ToString()); }
                        else { MessageBox.Show("EmployeeId not found!"); }
                        break;
                    default:
                        MessageBox.Show("One or more fields have invalid input!");
                        break;
                }
            }
            else 
            {
                MessageBox.Show("Invalid ID input!");
            }            
        }
    }
}