using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LuckyTimer
{
    public partial class AutorizationFrom : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        
        public AutorizationFrom()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Width, 34 );

            //to make the font work on onther PCs
            byte[] fontData = Properties.Resources.myFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.myFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.myFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            AutorizationLabel.Font = new Font(fonts.Families[0], 30);
            signIn_button.Font = new Font(fonts.Families[0], 14);
            loginField.Font = new Font(fonts.Families[0], 18);

        }

        Point lastPoint;
        //when the left mouse button is pressed, you can move the window
        private void BottomPanel_MouseMove(object sender, MouseEventArgs e) 
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); //coordinates of mouse
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void signIn_button_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text; //the data entered from login field is stored in variable userLogin
            string passLogin = passwordField.Text; //the data entered from password field is stored in variable passLogin


            Database database = new Database(); //accessing the database
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @UL AND Password = @PL", database.getConnection());
            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = userLogin;
            command.Parameters.Add("@PL", SqlDbType.NVarChar).Value = passLogin;

            adapter.SelectCommand = command; //Executes the specified command (SQL Query)
            adapter.Fill(table);
            if (table.Rows.Count > 0) //if there is a suitable row, then table.Rows.count = 1 and autarization will be complited and vice versa
            {
                MessageBox.Show("Autorization completed");
                this.Hide();
                GameForm form2 = new GameForm(); //if the autrization completed, then it opens the window with a game
                form2.Owner = this;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Autorization not completed :(. Try again.");
                
            }
        }
        private void SignUpBox_Click(object sender, EventArgs e) //Opens the registration window if the sign up button is pressed
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
