namespace Seq.MonteCarloSimulation
{
    partial class Simulator
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.textBoxSimulations = new System.Windows.Forms.TextBox();
            this.textBoxPeriods = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.textBoxDownGrowth = new System.Windows.Forms.TextBox();
            this.textBoxUpGrowth = new System.Windows.Forms.TextBox();
            this.textBoxExercisePrice = new System.Windows.Forms.TextBox();
            this.textBoxInitialPrice = new System.Windows.Forms.TextBox();
            this.labelSimulations = new System.Windows.Forms.Label();
            this.labelPeriods = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelDownGrowth = new System.Windows.Forms.Label();
            this.labelUpGrowth = new System.Windows.Forms.Label();
            this.labelExercisePrice = new System.Windows.Forms.Label();
            this.labelInitialPrice = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.textBoxSimulations);
            this.groupBoxParameters.Controls.Add(this.textBoxPeriods);
            this.groupBoxParameters.Controls.Add(this.textBoxInterestRate);
            this.groupBoxParameters.Controls.Add(this.textBoxDownGrowth);
            this.groupBoxParameters.Controls.Add(this.textBoxUpGrowth);
            this.groupBoxParameters.Controls.Add(this.textBoxExercisePrice);
            this.groupBoxParameters.Controls.Add(this.textBoxInitialPrice);
            this.groupBoxParameters.Controls.Add(this.labelSimulations);
            this.groupBoxParameters.Controls.Add(this.labelPeriods);
            this.groupBoxParameters.Controls.Add(this.labelInterestRate);
            this.groupBoxParameters.Controls.Add(this.labelDownGrowth);
            this.groupBoxParameters.Controls.Add(this.labelUpGrowth);
            this.groupBoxParameters.Controls.Add(this.labelExercisePrice);
            this.groupBoxParameters.Controls.Add(this.labelInitialPrice);
            this.groupBoxParameters.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxParameters.Location = new System.Drawing.Point(225, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(241, 229);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Simulation Parameters";
            // 
            // textBoxSimulations
            // 
            this.textBoxSimulations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSimulations.Location = new System.Drawing.Point(124, 196);
            this.textBoxSimulations.Name = "textBoxSimulations";
            this.textBoxSimulations.Size = new System.Drawing.Size(111, 23);
            this.textBoxSimulations.TabIndex = 7;
            this.textBoxSimulations.Text = "2000000";
            // 
            // textBoxPeriods
            // 
            this.textBoxPeriods.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPeriods.Location = new System.Drawing.Point(124, 167);
            this.textBoxPeriods.Name = "textBoxPeriods";
            this.textBoxPeriods.Size = new System.Drawing.Size(111, 23);
            this.textBoxPeriods.TabIndex = 7;
            this.textBoxPeriods.Text = "41";
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInterestRate.Location = new System.Drawing.Point(124, 138);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(111, 23);
            this.textBoxInterestRate.TabIndex = 7;
            this.textBoxInterestRate.Text = "0.14";
            // 
            // textBoxDownGrowth
            // 
            this.textBoxDownGrowth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDownGrowth.Location = new System.Drawing.Point(124, 109);
            this.textBoxDownGrowth.Name = "textBoxDownGrowth";
            this.textBoxDownGrowth.Size = new System.Drawing.Size(111, 23);
            this.textBoxDownGrowth.TabIndex = 7;
            this.textBoxDownGrowth.Text = "0.9";
            // 
            // textBoxUpGrowth
            // 
            this.textBoxUpGrowth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpGrowth.Location = new System.Drawing.Point(124, 80);
            this.textBoxUpGrowth.Name = "textBoxUpGrowth";
            this.textBoxUpGrowth.Size = new System.Drawing.Size(111, 23);
            this.textBoxUpGrowth.TabIndex = 7;
            this.textBoxUpGrowth.Text = "1.6";
            // 
            // textBoxExercisePrice
            // 
            this.textBoxExercisePrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxExercisePrice.Location = new System.Drawing.Point(124, 51);
            this.textBoxExercisePrice.Name = "textBoxExercisePrice";
            this.textBoxExercisePrice.Size = new System.Drawing.Size(111, 23);
            this.textBoxExercisePrice.TabIndex = 7;
            this.textBoxExercisePrice.Text = "33.0";
            // 
            // textBoxInitialPrice
            // 
            this.textBoxInitialPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInitialPrice.Location = new System.Drawing.Point(124, 22);
            this.textBoxInitialPrice.Name = "textBoxInitialPrice";
            this.textBoxInitialPrice.Size = new System.Drawing.Size(111, 23);
            this.textBoxInitialPrice.TabIndex = 7;
            this.textBoxInitialPrice.Text = "33.0";
            // 
            // labelSimulations
            // 
            this.labelSimulations.AutoSize = true;
            this.labelSimulations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSimulations.Location = new System.Drawing.Point(27, 200);
            this.labelSimulations.Name = "labelSimulations";
            this.labelSimulations.Size = new System.Drawing.Size(91, 15);
            this.labelSimulations.TabIndex = 6;
            this.labelSimulations.Text = "Simulations:";
            // 
            // labelPeriods
            // 
            this.labelPeriods.AutoSize = true;
            this.labelPeriods.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPeriods.Location = new System.Drawing.Point(55, 171);
            this.labelPeriods.Name = "labelPeriods";
            this.labelPeriods.Size = new System.Drawing.Size(63, 15);
            this.labelPeriods.TabIndex = 5;
            this.labelPeriods.Text = "Periods:";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInterestRate.Location = new System.Drawing.Point(13, 142);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(105, 15);
            this.labelInterestRate.TabIndex = 4;
            this.labelInterestRate.Text = "Interest Rate:";
            // 
            // labelDownGrowth
            // 
            this.labelDownGrowth.AutoSize = true;
            this.labelDownGrowth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDownGrowth.Location = new System.Drawing.Point(27, 113);
            this.labelDownGrowth.Name = "labelDownGrowth";
            this.labelDownGrowth.Size = new System.Drawing.Size(91, 15);
            this.labelDownGrowth.TabIndex = 3;
            this.labelDownGrowth.Text = "Down Growth:";
            // 
            // labelUpGrowth
            // 
            this.labelUpGrowth.AutoSize = true;
            this.labelUpGrowth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUpGrowth.Location = new System.Drawing.Point(41, 84);
            this.labelUpGrowth.Name = "labelUpGrowth";
            this.labelUpGrowth.Size = new System.Drawing.Size(77, 15);
            this.labelUpGrowth.TabIndex = 2;
            this.labelUpGrowth.Text = "Up Growth:";
            // 
            // labelExercisePrice
            // 
            this.labelExercisePrice.AutoSize = true;
            this.labelExercisePrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExercisePrice.Location = new System.Drawing.Point(6, 55);
            this.labelExercisePrice.Name = "labelExercisePrice";
            this.labelExercisePrice.Size = new System.Drawing.Size(112, 15);
            this.labelExercisePrice.TabIndex = 1;
            this.labelExercisePrice.Text = "Exercise Price:";
            // 
            // labelInitialPrice
            // 
            this.labelInitialPrice.AutoSize = true;
            this.labelInitialPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInitialPrice.Location = new System.Drawing.Point(13, 26);
            this.labelInitialPrice.Name = "labelInitialPrice";
            this.labelInitialPrice.Size = new System.Drawing.Size(105, 15);
            this.labelInitialPrice.TabIndex = 0;
            this.labelInitialPrice.Text = "Initial Price:";
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 15;
            this.listBoxResults.Location = new System.Drawing.Point(12, 12);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(207, 229);
            this.listBoxResults.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(12, 247);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(65, 37);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.Location = new System.Drawing.Point(401, 247);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 37);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 291);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.groupBoxParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monte Carlo Simulator";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TextBox textBoxSimulations;
        private System.Windows.Forms.TextBox textBoxPeriods;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.TextBox textBoxDownGrowth;
        private System.Windows.Forms.TextBox textBoxUpGrowth;
        private System.Windows.Forms.TextBox textBoxExercisePrice;
        private System.Windows.Forms.TextBox textBoxInitialPrice;
        private System.Windows.Forms.Label labelSimulations;
        private System.Windows.Forms.Label labelPeriods;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelDownGrowth;
        private System.Windows.Forms.Label labelUpGrowth;
        private System.Windows.Forms.Label labelExercisePrice;
        private System.Windows.Forms.Label labelInitialPrice;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}

