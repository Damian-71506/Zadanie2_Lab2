
namespace Zadanie2
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDzielenie = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMnozenie = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPrzecinek = new System.Windows.Forms.Button();
            this.buttonRowna = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(318, 44);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = " ";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(12, 84);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(237, 69);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "AC";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // buttonDzielenie
            // 
            this.buttonDzielenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.buttonDzielenie.FlatAppearance.BorderSize = 0;
            this.buttonDzielenie.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDzielenie.ForeColor = System.Drawing.Color.White;
            this.buttonDzielenie.Location = new System.Drawing.Point(255, 84);
            this.buttonDzielenie.Name = "buttonDzielenie";
            this.buttonDzielenie.Size = new System.Drawing.Size(75, 69);
            this.buttonDzielenie.TabIndex = 4;
            this.buttonDzielenie.Text = "/";
            this.buttonDzielenie.UseVisualStyleBackColor = false;
            this.buttonDzielenie.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 69);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(93, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 69);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(174, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 69);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // buttonMnozenie
            // 
            this.buttonMnozenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.buttonMnozenie.FlatAppearance.BorderSize = 0;
            this.buttonMnozenie.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMnozenie.ForeColor = System.Drawing.Color.White;
            this.buttonMnozenie.Location = new System.Drawing.Point(255, 159);
            this.buttonMnozenie.Name = "buttonMnozenie";
            this.buttonMnozenie.Size = new System.Drawing.Size(75, 69);
            this.buttonMnozenie.TabIndex = 8;
            this.buttonMnozenie.Text = "x";
            this.buttonMnozenie.UseVisualStyleBackColor = false;
            this.buttonMnozenie.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 69);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(93, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 69);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(174, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 69);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(255, 234);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 69);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(93, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(174, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 69);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(255, 309);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 69);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // buttonPrzecinek
            // 
            this.buttonPrzecinek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.buttonPrzecinek.FlatAppearance.BorderSize = 0;
            this.buttonPrzecinek.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrzecinek.ForeColor = System.Drawing.Color.White;
            this.buttonPrzecinek.Location = new System.Drawing.Point(174, 384);
            this.buttonPrzecinek.Name = "buttonPrzecinek";
            this.buttonPrzecinek.Size = new System.Drawing.Size(75, 69);
            this.buttonPrzecinek.TabIndex = 17;
            this.buttonPrzecinek.Text = ",";
            this.buttonPrzecinek.UseVisualStyleBackColor = false;
            this.buttonPrzecinek.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // buttonRowna
            // 
            this.buttonRowna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.buttonRowna.FlatAppearance.BorderSize = 0;
            this.buttonRowna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRowna.ForeColor = System.Drawing.Color.White;
            this.buttonRowna.Location = new System.Drawing.Point(255, 384);
            this.buttonRowna.Name = "buttonRowna";
            this.buttonRowna.Size = new System.Drawing.Size(75, 69);
            this.buttonRowna.TabIndex = 18;
            this.buttonRowna.Text = "=";
            this.buttonRowna.UseVisualStyleBackColor = false;
            this.buttonRowna.Click += new System.EventHandler(this.resultButtonClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(12, 384);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(156, 69);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(343, 468);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonRowna);
            this.Controls.Add(this.buttonPrzecinek);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMnozenie);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDzielenie);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDzielenie;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMnozenie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonPrzecinek;
        private System.Windows.Forms.Button buttonRowna;
        private System.Windows.Forms.Button button0;
    }
}

