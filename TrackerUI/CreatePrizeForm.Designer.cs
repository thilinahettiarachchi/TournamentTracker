﻿
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(240, 102);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(130, 20);
            this.placeNumberValue.TabIndex = 26;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(57, 96);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(147, 25);
            this.placeNumberLabel.TabIndex = 25;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(30, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(203, 37);
            this.headerLabel.TabIndex = 27;
            this.headerLabel.Text = "Create Team";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(240, 148);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(130, 20);
            this.placeNameValue.TabIndex = 29;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(57, 142);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(128, 25);
            this.placeNameLabel.TabIndex = 28;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(240, 193);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(130, 20);
            this.prizeAmountValue.TabIndex = 31;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountLabel.Location = new System.Drawing.Point(57, 187);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(140, 25);
            this.prizeAmountLabel.TabIndex = 30;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(240, 289);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(130, 20);
            this.prizePercentageValue.TabIndex = 33;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(57, 283);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(177, 25);
            this.prizePercentageLabel.TabIndex = 32;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(188, 234);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(45, 25);
            this.orLabel.TabIndex = 34;
            this.orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(92, 353);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(244, 39);
            this.createPrizeButton.TabIndex = 39;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}