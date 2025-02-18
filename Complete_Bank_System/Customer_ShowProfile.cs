using Complete_Bank_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Complete_Bank_System
{
    public partial class Customer_ShowProfile : Form
    {
        int Id;
        Complete_Bank_SystemContext context;
        Customer c;

        public Customer_ShowProfile(int id)
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            Id = id;
        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            c = context.customers.SingleOrDefault(c => c.CustomerId == Id);
            if (c != null)
            {
                txt_Name.Text = c.FullName;
                txt_Address.Text = c.Address;
                txt_CNN.Text = c.CNN;
                txt_Email.Text = c.Email;
                txt_PhoneNumber.Text = c.PhoneNumber;
                DatePicker_BD.Value = c.BirthDate.ToDateTime(TimeOnly.MinValue);
                lbl_OldPassword.Visible = false;
                txt_OldPassword.Visible = false;
                panel_PasswordContainer.Visible = false;
                txt_NewPassword.Visible = false;
                lbl_NewPassword.Visible = false;
                txt_ConfirmPassword.Visible = false;
                btn_UploadPic.Visible = false;
                if (c.Image != null && c.Image.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(c.Image))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }


                }
                else
                {
                    pictureBox1.Image = Properties.Resources.userrr;
                }

                SetInputFieldsReadOnly(true);
            }
        }

        private void SetInputFieldsReadOnly(bool isReadOnly)
        {
            txt_Name.ReadOnly = isReadOnly;
            txt_Address.ReadOnly = isReadOnly;
            txt_CNN.ReadOnly = isReadOnly;
            txt_Email.ReadOnly = isReadOnly;
            txt_PhoneNumber.ReadOnly = isReadOnly;
            DatePicker_BD.Enabled = !isReadOnly;
        }

        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            if (btn_EditProfile.Text == "Edit Profile")
            {
                btn_EditProfile.Text = "Save";
                SetInputFieldsReadOnly(false);
                btn_UploadPic.Visible = true;
                pictureBox1.Visible = true;
            }
            else if (btn_EditProfile.Text == "Save")
            {
                if (c != null)
                {
                    c.FullName = txt_Name.Text;
                    c.Email = txt_Email.Text;
                    c.PhoneNumber = txt_PhoneNumber.Text;
                    c.CNN = txt_CNN.Text;
                    c.Address = txt_Address.Text;
                    c.BirthDate = DateOnly.FromDateTime(DatePicker_BD.Value);
                    context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Id).FullName} edited profile data" });
                    context.SaveChanges();
                    MessageBox.Show("Info Saved Successfully");
                    btn_EditProfile.Text = "Edit Profile";
                    SetInputFieldsReadOnly(true);
                }
            }
        }

        private void btn_ReturnToHome_Click(object sender, EventArgs e)
        {
            CustomerDashBoard dashboard = new CustomerDashBoard(Id);
            this.Hide();
            dashboard.Show();
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            lbl_OldPassword.Visible = true;
            txt_OldPassword.Visible = true;
            if (!string.IsNullOrEmpty(txt_OldPassword.Text))
            {
                if (txt_OldPassword.Text == c.Password)
                {
                    panel_PasswordContainer.Visible = true;
                    txt_NewPassword.Visible = true;
                    lbl_NewPassword.Visible = true;
                    txt_ConfirmPassword.Visible = true;

                    btn_ChangePassword.Text = "Save Password";
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (btn_ChangePassword.Text == "Save Password")
            {
                if (!string.IsNullOrEmpty(txt_NewPassword.Text))
                {
                    if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                    {
                        MessageBox.Show("Passwords should match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   
                    c.Password = txt_NewPassword.Text;
                    context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Id).FullName} Changed password" });
                    context.SaveChanges();
                    MessageBox.Show("Password Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel_PasswordContainer.Visible = false;
                    lbl_OldPassword.Visible = false;
                    txt_OldPassword.Visible = false;
                    txt_NewPassword.Visible = false;
                    lbl_NewPassword.Visible = false;
                    txt_ConfirmPassword.Visible = false;

                    btn_ChangePassword.Text = "Change Password";
                }

            }
        }

        private void btn_UploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Select An Image";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    byte[] imageData = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    if (c != null)
                    {
                        c.Image = imageData;
                        context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Id).FullName} Changed his Profile Picture" });
                        context.SaveChanges();
                        MessageBox.Show("Image Profile Uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}