namespace MySurvey
{
    partial class Form1
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
            this.btn_Fill_Out_Click = new System.Windows.Forms.Button();
            this.btn_ViewResultsClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fill_Out_Click
            // 
            this.btn_Fill_Out_Click.Location = new System.Drawing.Point(147, 27);
            this.btn_Fill_Out_Click.Name = "btn_Fill_Out_Click";
            this.btn_Fill_Out_Click.Size = new System.Drawing.Size(167, 58);
            this.btn_Fill_Out_Click.TabIndex = 0;
            this.btn_Fill_Out_Click.Text = "Fill Out Survey";
            this.btn_Fill_Out_Click.UseVisualStyleBackColor = true;
            this.btn_Fill_Out_Click.Click += new System.EventHandler(this.btnFillOutClick_Click);
            // 
            // btn_ViewResultsClick
            // 
            this.btn_ViewResultsClick.Location = new System.Drawing.Point(147, 115);
            this.btn_ViewResultsClick.Name = "btn_ViewResultsClick";
            this.btn_ViewResultsClick.Size = new System.Drawing.Size(167, 60);
            this.btn_ViewResultsClick.TabIndex = 1;
            this.btn_ViewResultsClick.Text = "View Survey Results";
            this.btn_ViewResultsClick.UseVisualStyleBackColor = true;
            this.btn_ViewResultsClick.Click += new System.EventHandler(this.btn_ViewResultsClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ViewResultsClick);
            this.Controls.Add(this.btn_Fill_Out_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fill_Out_Click;
        private System.Windows.Forms.Button btn_ViewResultsClick;
    }
}

