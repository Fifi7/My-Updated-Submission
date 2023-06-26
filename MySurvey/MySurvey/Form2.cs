using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySurvey
{
    public partial class Form2 : Form
    {
        private string connectionString; 

        public Form2()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string surname = tb_Surname.Text;
            string names = tb_Names.Text;
            string numbers = tb_Numbers.Text;
            string dates = tb_Dates.Text;
            string age = tb_Age.Text;
            int foodPreference = GetSelectedFoodPreference();
            int eatOutRating = GetSelectedRating(rb_EatOut_1, rb_EatOut_2, rb_EatOut_3, rb_EatOut_4, rb_EatOut_5);
            int moviesRating = GetSelectedRating(rb_Movies_1, rb_Movies_2, rb_Movies_3, rb_Movies_4, rb_Movies_5);
            int tvRating = GetSelectedRating(rb_TV_1, rb_TV_2, rb_TV_3, rb_TV_4, rb_TV_5);
            int radioRating = GetSelectedRating(rb_Radio_1, rb_Radio_2, rb_Radio_3, rb_Radio_4, rb_Radio_5);

            StoreSurveyResults(surname, names, numbers, dates, age, foodPreference, eatOutRating, moviesRating, tvRating, radioRating);

            MessageBox.Show("Survey responses submitted successfully!");

      

            Form1 obj1 = new Form1();
            obj1.Show();
            this.Visible = false;
        }
        private int GetSelectedFoodPreference()
        {
            if (rb_Pizza.Checked)
                return 1;
            else if (rb_Pasta.Checked)
                return 2;
            else if (rb_PapWors.Checked)
                return 3;
            else if (rb_Chicken.Checked)
                return 4;
            else if (rb_Beef.Checked)
                return 5;
            else if (rb_Other.Checked)
                return 6;

            return -1; // No option selected
        }
        private int GetSelectedRating(params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                    return i + 1;
            }

            return -1; // No option selected
        }
        private void StoreSurveyResults(string surname, string names, string numbers, string dates, string age, int foodPreference, int eatOutRating, int moviesRating, int tvRating, int radioRating)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //SQL command to insert the survey responses into the database
                    SqlCommand command = new SqlCommand("INSERT INTO SurveyResponses (Surname, Names, Numbers, Dates, Age, FoodPreference, EatOutRating, MoviesRating, TvRating, RadioRating) " +
                                                        "VALUES (@Surname, @Names, @Numbers, @Dates, @Age, @FoodPreference, @EatOutRating, @MoviesRating, @TvRating, @RadioRating)", connection);

                    // Add parameter values to the command
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Names", names);
                    command.Parameters.AddWithValue("@Numbers", numbers);
                    command.Parameters.AddWithValue("@Dates", dates);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@FoodPreference", foodPreference);
                    command.Parameters.AddWithValue("@EatOutRating", eatOutRating);
                    command.Parameters.AddWithValue("@MoviesRating", moviesRating);
                    command.Parameters.AddWithValue("@TvRating", tvRating);
                    command.Parameters.AddWithValue("@RadioRating", radioRating);

                    
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to store survey responses: " + ex.Message);
                }
            }
        } 

        
         private void ResetForm()
{
         tb_Surname.Text = string.Empty;
         tb_Names.Text = string.Empty;
         tb_Numbers.Text = string.Empty;
         tb_Dates.Text = string.Empty;
         tb_Age.Text = string.Empty;
         rb_Pizza.Checked = false;
         rb_Pasta.Checked = false;
         rb_PapWors.Checked = false;
        rb_Chicken.Checked = false;
         rb_Beef.Checked = false;
        rb_Other.Checked = false;
       UncheckRadioButtons(panelEatOut.Controls);
       UncheckRadioButtons(panelMovies.Controls);
       UncheckRadioButtons(panelTV.Controls);
       UncheckRadioButtons(panelRadio.Controls);
}

        private void UncheckRadioButtons(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is RadioButton radioButton)
                    radioButton.Checked = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rb_Movies_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        

   
    }
}

