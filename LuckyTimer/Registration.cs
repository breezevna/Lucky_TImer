using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LuckyTimer
{
    public partial class Registration : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        public Registration()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.myFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.myFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.myFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            NameText.Font = new Font(fonts.Families[0], 20);
            SurnameText.Font = new Font(fonts.Families[0], 20);
            PasswordText.Font = new Font(fonts.Families[0], 20);
            UsernameText.Font = new Font(fonts.Families[0], 20);
            SignUpButton.Font = new Font(fonts.Families[0], 20);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            string userLogin = UsernameText.Text; ////the data entered from text boxes is stored in variables
            string passLogin = PasswordText.Text;
            string userName = NameText.Text;
            string userSurname = SurnameText.Text;

            //if some of the fields will be empty, then it shows message boxes
            if (userLogin == "")
            {
                MessageBox.Show("Enter your username");
                return;
            }
            if (passLogin == "")
            {
                MessageBox.Show("Enter your Password");
                return;
            }
            if (userName == "")
            {
                MessageBox.Show("Enter your name");
                return;
            }
            if (userSurname == "")
            {
                MessageBox.Show("Enter your Surname");
                return;
            }
            if (IsUserExists() == true)
                return;

            Database database = new Database(); //accessing the database
            SqlCommand command = new SqlCommand("INSERT INTO Users (Login, Name, Surname, Password, Points) VALUES (@login,@name,@surname,@password,@points)", database.getConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = userLogin; //assigning a data from text box
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = passLogin;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = userSurname;
            command.Parameters.Add("@points", SqlDbType.Float).Value = 200;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1) //if the SQL command is executed, the account will be created 
            {
                MessageBox.Show("Account was created.You were given 200 game points");
                this.Hide();
                AutorizationFrom autorization = new AutorizationFrom(); //after creating an account autorizatioon winow will be opened
                autorization.Show();
            }
            else
            {
                MessageBox.Show("Account wasn't created. Try again");
            }

            database.CloseConnection();
        }
        public Boolean IsUserExists() //A method that determines whether a user exists 
        {
            Database database = new Database();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @UL", database.getConnection());
            command.Parameters.Add("@UL", SqlDbType.VarChar).Value = UsernameText.Text;

            adapter.SelectCommand = command; 
            adapter.Fill(table); 

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This username already exists");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
