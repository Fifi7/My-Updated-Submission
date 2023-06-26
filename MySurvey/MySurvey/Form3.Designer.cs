namespace MySurvey
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTotalSurveys = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblOldestPerson = new System.Windows.Forms.Label();
            this.lblYoungestPerson = new System.Windows.Forms.Label();
            this.lblPizzaPercentage = new System.Windows.Forms.Label();
            this.lblPastaPercentage = new System.Windows.Forms.Label();
            this.lblPapAndWorsPercentage = new System.Windows.Forms.Label();
            this.lblEatOutRating = new System.Windows.Forms.Label();
            this.lblMoviesRating = new System.Windows.Forms.Label();
            this.lblTVRating = new System.Windows.Forms.Label();
            this.lblRadioRating = new System.Windows.Forms.Label();
            this.okay_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.database1DataSet = new MySurvey.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSurveys
            // 
            this.lblTotalSurveys.AutoSize = true;
            this.lblTotalSurveys.Location = new System.Drawing.Point(50, 37);
            this.lblTotalSurveys.Name = "lblTotalSurveys";
            this.lblTotalSurveys.Size = new System.Drawing.Size(126, 13);
            this.lblTotalSurveys.TabIndex = 0;
            this.lblTotalSurveys.Text = "Total number of surveys: ";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(50, 61);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(71, 13);
            this.lblAverageAge.TabIndex = 1;
            this.lblAverageAge.Text = "Average age:\r\n";
            // 
            // lblOldestPerson
            // 
            this.lblOldestPerson.AutoSize = true;
            this.lblOldestPerson.Location = new System.Drawing.Point(50, 85);
            this.lblOldestPerson.Name = "lblOldestPerson";
            this.lblOldestPerson.Size = new System.Drawing.Size(198, 13);
            this.lblOldestPerson.TabIndex = 2;
            this.lblOldestPerson.Text = "Oldest person who participated in survey\r\n";
            // 
            // lblYoungestPerson
            // 
            this.lblYoungestPerson.AutoSize = true;
            this.lblYoungestPerson.Location = new System.Drawing.Point(50, 110);
            this.lblYoungestPerson.Name = "lblYoungestPerson";
            this.lblYoungestPerson.Size = new System.Drawing.Size(213, 13);
            this.lblYoungestPerson.TabIndex = 3;
            this.lblYoungestPerson.Text = "Youngest person who participated in survey\r\n";
            // 
            // lblPizzaPercentage
            // 
            this.lblPizzaPercentage.AutoSize = true;
            this.lblPizzaPercentage.Location = new System.Drawing.Point(50, 168);
            this.lblPizzaPercentage.Name = "lblPizzaPercentage";
            this.lblPizzaPercentage.Size = new System.Drawing.Size(182, 13);
            this.lblPizzaPercentage.TabIndex = 4;
            this.lblPizzaPercentage.Text = "Percentage of people who like Pizza:\r\n";
            // 
            // lblPastaPercentage
            // 
            this.lblPastaPercentage.AutoSize = true;
            this.lblPastaPercentage.Location = new System.Drawing.Point(50, 194);
            this.lblPastaPercentage.Name = "lblPastaPercentage";
            this.lblPastaPercentage.Size = new System.Drawing.Size(184, 13);
            this.lblPastaPercentage.TabIndex = 5;
            this.lblPastaPercentage.Text = "Percentage of people who like Pasta:\r\n";
            // 
            // lblPapAndWorsPercentage
            // 
            this.lblPapAndWorsPercentage.AutoSize = true;
            this.lblPapAndWorsPercentage.Location = new System.Drawing.Point(50, 219);
            this.lblPapAndWorsPercentage.Name = "lblPapAndWorsPercentage";
            this.lblPapAndWorsPercentage.Size = new System.Drawing.Size(225, 13);
            this.lblPapAndWorsPercentage.TabIndex = 6;
            this.lblPapAndWorsPercentage.Text = "Percentage of people who like Pap and Wors:\r\n";
            // 
            // lblEatOutRating
            // 
            this.lblEatOutRating.AutoSize = true;
            this.lblEatOutRating.Location = new System.Drawing.Point(50, 258);
            this.lblEatOutRating.Name = "lblEatOutRating";
            this.lblEatOutRating.Size = new System.Drawing.Size(110, 13);
            this.lblEatOutRating.TabIndex = 7;
            this.lblEatOutRating.Text = "People like to eat out:\r\n";
            // 
            // lblMoviesRating
            // 
            this.lblMoviesRating.AutoSize = true;
            this.lblMoviesRating.Location = new System.Drawing.Point(50, 282);
            this.lblMoviesRating.Name = "lblMoviesRating";
            this.lblMoviesRating.Size = new System.Drawing.Size(142, 13);
            this.lblMoviesRating.TabIndex = 8;
            this.lblMoviesRating.Text = "People like to watch movies:\r\n";
            // 
            // lblTVRating
            // 
            this.lblTVRating.AutoSize = true;
            this.lblTVRating.Location = new System.Drawing.Point(50, 306);
            this.lblTVRating.Name = "lblTVRating";
            this.lblTVRating.Size = new System.Drawing.Size(126, 13);
            this.lblTVRating.TabIndex = 9;
            this.lblTVRating.Text = "People like to watch TV: \r\n";
            // 
            // lblRadioRating
            // 
            this.lblRadioRating.AutoSize = true;
            this.lblRadioRating.Location = new System.Drawing.Point(50, 328);
            this.lblRadioRating.Name = "lblRadioRating";
            this.lblRadioRating.Size = new System.Drawing.Size(160, 26);
            this.lblRadioRating.TabIndex = 10;
            this.lblRadioRating.Text = "People like to listen to the radio: \r\n\r\n";
            // 
            // okay_btn
            // 
            this.okay_btn.Location = new System.Drawing.Point(318, 383);
            this.okay_btn.Name = "okay_btn";
            this.okay_btn.Size = new System.Drawing.Size(88, 44);
            this.okay_btn.TabIndex = 11;
            this.okay_btn.Text = "OK";
            this.okay_btn.UseVisualStyleBackColor = true;
            this.okay_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(365, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(415, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(7, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(415, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 17;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.okay_btn);
            this.Controls.Add(this.lblRadioRating);
            this.Controls.Add(this.lblTVRating);
            this.Controls.Add(this.lblMoviesRating);
            this.Controls.Add(this.lblEatOutRating);
            this.Controls.Add(this.lblPapAndWorsPercentage);
            this.Controls.Add(this.lblPastaPercentage);
            this.Controls.Add(this.lblPizzaPercentage);
            this.Controls.Add(this.lblYoungestPerson);
            this.Controls.Add(this.lblOldestPerson);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblTotalSurveys);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSurveys;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblOldestPerson;
        private System.Windows.Forms.Label lblYoungestPerson;
        private System.Windows.Forms.Label lblPizzaPercentage;
        private System.Windows.Forms.Label lblPastaPercentage;
        private System.Windows.Forms.Label lblPapAndWorsPercentage;
        private System.Windows.Forms.Label lblEatOutRating;
        private System.Windows.Forms.Label lblMoviesRating;
        private System.Windows.Forms.Label lblTVRating;
        private System.Windows.Forms.Label lblRadioRating;
        private System.Windows.Forms.Button okay_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
    }
}