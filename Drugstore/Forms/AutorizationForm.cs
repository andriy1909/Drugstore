using System;
using System.Text;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Drugstore
{
    public partial class AutorizationForm : Form
    {
        int user = -1;

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lbErrors.ForeColor = Color.Black;
            lbErrors.Text = "З'єднання з базою данних...";
            lbErrors.Visible = true;
            bool check1 = true;
            try
            {
                SqlConnection bd = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Drugstore;Integrated Security=True");
                bd.Open();
                string sql = "SELECT Код, Логін, Пароль " +
                            "FROM Працівники ";
                SqlCommand command1 = new SqlCommand(sql, bd);
                SqlDataReader dataReader1 = command1.ExecuteReader();
                while (dataReader1.Read())
                {
                    if (dataReader1["Логін"].ToString().Trim() == tbLogin.Text.Trim())
                        if (dataReader1["Пароль"].ToString().Trim() == tbPassword.Text.Trim())
                        {
                            check1 = false;
                            lbErrors.Visible = false;
                            user = (int)dataReader1["Код"];
                            break;
                        }
                }
                bd.Close();
                if (check1)
                {
                    lbErrors.Visible = true;
                    lbErrors.ForeColor = Color.Red;
                    lbErrors.Text = "Введеий невірний логін або пароль";
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                lbErrors.Visible = true;
                lbErrors.ForeColor = Color.Red;
                lbErrors.Text = "Помилка з'єднання з базою даних";
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCheck.PerformClick();
        }
        
        public int getUserId()
        {
            return user;
        }
    }
}
