using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Text;

namespace LuckyTimer
{
    public partial class GameForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        System.Timers.Timer timer; //createing timer event
        double sec, milisec;
        string gamePoints;
        double enteredGamePoints, gamePointsInteger;
        public GameForm()
        {
            InitializeComponent();
            //to make the font work on onther PCs
            byte[] fontData = Properties.Resources.myFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.myFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.myFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            TimerResult.Font = new Font(fonts.Families[0],30); //initializing the font
            points.Font = new Font(fonts.Families[0], 30);
            BetTextBox.Font = new Font(fonts.Families[0], 23);
            betButton.Font = new Font(fonts.Families[0],20,FontStyle.Bold);
            PickUpButton.Font = new Font(fonts.Families[0],20,FontStyle.Bold);
            Username.Font = new Font(fonts.Families[0], 14);
        }

        public void PointsToTextBox() //A method that outputs data from the database to the text box under the timer
        {

            Database database = new Database(); //accessing the databse
            database.openConnection(); //openning connection to database
            SqlDataReader dataReader = null; 
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT Points FROM Users WHERE Login = @user", database.getConnection());
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = Username.Text; //assigning a data from text box named Username to @user
                adapter.SelectCommand = command; //Executes the specified command (SQL Query)

                dataReader = command.ExecuteReader(); 

                while (dataReader.Read()) //reads rows one by one
                {
                    gamePoints = dataReader["Points"].ToString(); //assigning data from databse ('points' column) to the variable
                    this.points.Text = gamePoints; //assigning gamePoints variable to a Text box named points
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //if any error ocurs, a message box will appear
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close(); //closes connection if everything works
                }
            }
        }
        public void DataBaseUpdating() //A method that updates database
        {
            Database database = new Database(); 
            DataTable table = new DataTable(); 
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("UPDATE Users SET Points = @points1 WHERE Login = @username", database.getConnection());
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username.Text; //assigning a variable to @username and @points1
            command.Parameters.Add("@points1", SqlDbType.Float).Value = gamePointsInteger;

            adapter.SelectCommand = command;
            adapter.Fill(table); //updates database
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            AutorizationFrom form = (AutorizationFrom)this.Owner;
            this.Username.Text = form.loginField.Text; //Shows the username in upper left corner through which the program was logged in

            PointsToTextBox(); 

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += OnTimeEvent; //calls method every 100 miliseconds
            PickUpButton.Enabled = false; //the button will not be available until the bet has been placed
        }

        private void ButtonsAvailability() //method that controls when buttons are available
        {
            Invoke(new Action(() =>
            {
                PickUpButton.Enabled = false; 
                betButton.Enabled = true;
            }));
            tRexRunning.Image = Properties.Resources.dead;
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    milisec += 1;
                    if (milisec == 60)
                    {
                        milisec = 0;
                        sec += 1;
                    }
                    TimerResult.Text = string.Format("{0}:{1}", sec.ToString().PadLeft(2, '0'), milisec.ToString().PadLeft(2, '0'));
                    //outputs data to the textbox
                }));
            }
            catch (Exception)
            {
                Application.Exit();
            }
           
            Random random = new Random(DateTime.Now.Millisecond);

            int randomizer = random.Next(1, 4); //randomizer to complicate the game
            int randomSecond;
            if (randomizer == 1)
            {
                //Example: if the variable randomSecond wil be 15(random number), then milliseconds will reach 15 and the timer will stop
                randomSecond = random.Next(0, 30); 
                if (milisec == randomSecond)
                {
                    ButtonsAvailability(); //when timmer starts the Bet button will be not available, Pick up button will be available
                    timer.Stop();
                    milisec = 0; //returning the timer to the starting points
                    sec = 0;
                }
            }
            if(randomizer == 2)
            {
                randomSecond = random.Next(0, 90);
                if (milisec == randomSecond)
                {
                    timer.Stop();
                    ButtonsAvailability();
                    milisec = 0;
                    sec = 0;
                }
            }
            if(randomizer == 3)
            {
                randomSecond = random.Next(0, 100);
                if (milisec == randomSecond)
                {
                    timer.Stop();
                    ButtonsAvailability();
                    milisec = 0;
                    sec = 0;
                }
            }
            if(randomizer == 4)
            {
                randomSecond = random.Next(0, 1000);
                if (milisec == randomSecond)
                {
                    timer.Stop();
                    ButtonsAvailability();
                    milisec = 0;
                    sec = 0;
                }
            }         
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To make a bet, you need to input amount and click 'Bet' button." +
                " To withdraw the winning, you need to click the 'Pick Up' button." +
                " Your winnings are made up of the sum-total of your bet multiplied by the cashout multiplier." +
                " If you don't pick up the bet before timer stops, then the bet will be lost");
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            
            PickUpButton.Enabled = false; //after pressing the pick up button it will not be available
            if (sec == 0) //adding winning to the "wallet" and updating database 
            {   
                gamePointsInteger += (enteredGamePoints * (milisec/100)) + enteredGamePoints;
                gamePointsInteger = Math.Round(gamePointsInteger,2);
            }
            
            if(sec >= 1)
            {
                gamePointsInteger += (enteredGamePoints * (sec + milisec / 100)) + enteredGamePoints;
                gamePointsInteger = Math.Round(gamePointsInteger, 2);
            }

            DataBaseUpdating();
            PointsToTextBox();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
       
            PickUpButton.Enabled = true; //bet button is available if timer is not working

            try
            {
                if (BetTextBox.Text == "")
                {
                    MessageBox.Show("Enter points");
                    return;
                }
                enteredGamePoints = double.Parse(BetTextBox.Text); //assigning entered points from the Text Box to the variable
                gamePointsInteger = double.Parse(gamePoints); //assigning game points from database to the variable 

                if (gamePointsInteger < enteredGamePoints)
                {
                    MessageBox.Show("You can't bet more than the money you have in your account");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Enter the number correctly or use ',' instead of other sign :)");
                return;
            }


            timer.Start(); //starts the timer when the button is pressed
            tRexRunning.Image = Properties.Resources.running; 
            betButton.Enabled = false;
            gamePointsInteger -= enteredGamePoints; //when a bet is placed, it's substracted from amount in the databse

            DataBaseUpdating();
            PointsToTextBox();

        }

    }
}
