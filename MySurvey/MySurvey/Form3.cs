using MySurvey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySurvey
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SurveyResultsForm_Load(object sender, EventArgs e)
        {
            // Retrieve the survey results
            int totalSurveys = RetrieveTotalSurveys();
            double averageAge = RetrieveAverageAge();
            int oldestPerson = RetrieveOldestPersonAge();
            int youngestPerson = RetrieveYoungestPersonAge();
            double pizzaPercentage = RetrievePizzaPercentage();
            double pastaPercentage = RetrievePastaPercentage();
            double papAndWorsPercentage = RetrievePapAndWorsPercentage();
            double eatOutRating = RetrieveAverageRating("EatOutRating");
            double moviesRating = RetrieveAverageRating("MoviesRating");
            double tvRating = RetrieveAverageRating("TVRating");
            double radioRating = RetrieveAverageRating("RadioRating");

            // Display the survey results on the form
            lblTotalSurveys.Text = $"Total number of surveys: {totalSurveys}";
            lblAverageAge.Text = $"Average age: {averageAge}";
            lblOldestPerson.Text = $"Oldest person who participated in survey: {oldestPerson}";
            lblYoungestPerson.Text = $"Youngest person who participated in survey: {youngestPerson}";
            lblPizzaPercentage.Text = $"Percentage of people who like Pizza: {pizzaPercentage}%";
            lblPastaPercentage.Text = $"Percentage of people who like Pasta: {pastaPercentage}%";
            lblPapAndWorsPercentage.Text = $"Percentage of people who like Pap and Wors: {papAndWorsPercentage}%";
            lblEatOutRating.Text = $"People like to eat out: {eatOutRating}";
            lblMoviesRating.Text = $"People like to watch movies: {moviesRating}";
            lblTVRating.Text = $"People like to watch TV: {tvRating}";
            lblRadioRating.Text = $"People like to listen to the radio: {radioRating}";
        }

        private int RetrieveTotalSurveys()
        {
            int totalSurveys = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SurveyResults";
                SqlCommand command = new SqlCommand(query, connection);
                totalSurveys = (int)command.ExecuteScalar();
            }
            return totalSurveys;
        }

        private double RetrieveAverageAge()
        {
            double averageAge = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT AVG(Age) FROM SurveyResults";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    averageAge = Convert.ToDouble(result);
                }
            }
            return averageAge;

        }

        private int RetrieveOldestPersonAge()
        {
            int oldestPerson = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT MAX(Age) FROM SurveyResults";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    oldestPerson = Convert.ToInt32(result);
                }
            }
            return oldestPerson;
        }

        private int RetrieveYoungestPersonAge()
        {
            int youngestPerson = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT MIN(Age) FROM SurveyResults";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    youngestPerson = Convert.ToInt32(result);
                }

            }
            return youngestPerson;
        }

        // NB. My Calculations :
        

        private double RetrievePizzaPercentage()
        {
            int pizzaLovers = 0;
            double pizzaPercentage = 0;
            int totalSurveys = RetrieveTotalSurveys();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SurveyResults WHERE FoodPreference = 'Pizza'";
                SqlCommand command = new SqlCommand(query, connection);
                pizzaLovers = (int)command.ExecuteScalar();
            }
            if (totalSurveys != 0)
            {
                pizzaPercentage = (pizzaLovers / (double)totalSurveys) * 100;
            }
            return Math.Round(pizzaPercentage, 1);
        }

        private double RetrievePastaPercentage()
        {
            int pastaLovers = 0;
            double pastaPercentage = 0;
            int totalSurveys = RetrieveTotalSurveys();

            using ( SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SurveyResults WHERE FoodPreference = 'Pasta'";
                SqlCommand command = new SqlCommand(query, connection);
                pastaLovers = (int)(command.ExecuteScalar());
            }
            if (totalSurveys != 0)
            {
                pastaPercentage = (pastaLovers / (double) totalSurveys) * 100;
            }
            return Math.Round(pastaPercentage, 1);
        }

        private double RetrievePapAndWorsPercentage()
        {
            int papAndWors = 0;
            double papAndWorsPercentage = 0;
            int totalSurveys = RetrieveTotalSurveys();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SurveyResults WHERE FoodPreference = 'Pap and Wors'";
                SqlCommand command = new SqlCommand(query, connection);
                papAndWors = (int)(command.ExecuteScalar());
            }
             if (totalSurveys != 0)
            {
                papAndWorsPercentage = (papAndWors / (double)totalSurveys) * 100;
            }
             return Math.Round(papAndWorsPercentage);
        }

        private double RetrieveAverageRating(string ratingColumnName)
        {
            double averageRating = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = $"SELECT AVG({ratingColumnName}) FROM SurveyResults";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    averageRating = Convert.ToDouble(result);
                }
            }
            return Math.Round(averageRating, 1);
        }

        private DataTable RetrieveSurveyResults()
        {
            DataTable surveyData = new DataTable();


          
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            
            string query = "SELECT * FROM SurveyResults";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    surveyData.Load(reader);

                    
                    reader.Close();
                    connection.Close();
                }
            }

            return surveyData;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Visible = false;
        }
    }
}