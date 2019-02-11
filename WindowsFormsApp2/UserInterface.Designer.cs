namespace WindowsFormsApp2
{
    partial class UserInterface
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
            this.uxTextbox = new System.Windows.Forms.TextBox();
            this.uxD = new System.Windows.Forms.Button();
            this.uxE = new System.Windows.Forms.Button();
            this.uxF = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxAnd = new System.Windows.Forms.Button();
            this.uxOr = new System.Windows.Forms.Button();
            this.uxXor = new System.Windows.Forms.Button();
            this.uxNot = new System.Windows.Forms.Button();
            this.uxClosingParenthesis = new System.Windows.Forms.Button();
            this.uxC = new System.Windows.Forms.Button();
            this.uxNine = new System.Windows.Forms.Button();
            this.uxSix = new System.Windows.Forms.Button();
            this.uxThree = new System.Windows.Forms.Button();
            this.uxOpeningParenthesis = new System.Windows.Forms.Button();
            this.uxB = new System.Windows.Forms.Button();
            this.uxA = new System.Windows.Forms.Button();
            this.uxSeven = new System.Windows.Forms.Button();
            this.uxEight = new System.Windows.Forms.Button();
            this.uxFour = new System.Windows.Forms.Button();
            this.uxFive = new System.Windows.Forms.Button();
            this.uxOne = new System.Windows.Forms.Button();
            this.uxTwo = new System.Windows.Forms.Button();
            this.uxEquals = new System.Windows.Forms.Button();
            this.uxZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTextbox
            // 
            this.uxTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextbox.Location = new System.Drawing.Point(7, 12);
            this.uxTextbox.Name = "uxTextbox";
            this.uxTextbox.ReadOnly = true;
            this.uxTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxTextbox.Size = new System.Drawing.Size(369, 20);
            this.uxTextbox.TabIndex = 0;
            this.uxTextbox.UseWaitCursor = true;
            // 
            // uxD
            // 
            this.uxD.Location = new System.Drawing.Point(7, 38);
            this.uxD.Name = "uxD";
            this.uxD.Size = new System.Drawing.Size(80, 31);
            this.uxD.TabIndex = 1;
            this.uxD.Text = "d";
            this.uxD.UseVisualStyleBackColor = true;
            this.uxD.Click += new System.EventHandler(this.uxD_Click);
            // 
            // uxE
            // 
            this.uxE.Location = new System.Drawing.Point(95, 38);
            this.uxE.Name = "uxE";
            this.uxE.Size = new System.Drawing.Size(91, 31);
            this.uxE.TabIndex = 2;
            this.uxE.Text = "e";
            this.uxE.UseVisualStyleBackColor = true;
            this.uxE.Click += new System.EventHandler(this.uxE_Click);
            // 
            // uxF
            // 
            this.uxF.Location = new System.Drawing.Point(193, 38);
            this.uxF.Name = "uxF";
            this.uxF.Size = new System.Drawing.Size(84, 32);
            this.uxF.TabIndex = 3;
            this.uxF.Text = "f";
            this.uxF.UseVisualStyleBackColor = true;
            this.uxF.Click += new System.EventHandler(this.uxF_Click);
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(289, 38);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(87, 32);
            this.uxClear.TabIndex = 4;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxAnd
            // 
            this.uxAnd.Location = new System.Drawing.Point(289, 76);
            this.uxAnd.Name = "uxAnd";
            this.uxAnd.Size = new System.Drawing.Size(87, 31);
            this.uxAnd.TabIndex = 5;
            this.uxAnd.Text = "AND";
            this.uxAnd.UseVisualStyleBackColor = true;
            this.uxAnd.Click += new System.EventHandler(this.uxAnd_Click);
            // 
            // uxOr
            // 
            this.uxOr.Location = new System.Drawing.Point(289, 113);
            this.uxOr.Name = "uxOr";
            this.uxOr.Size = new System.Drawing.Size(87, 33);
            this.uxOr.TabIndex = 6;
            this.uxOr.Text = "OR";
            this.uxOr.UseVisualStyleBackColor = true;
            this.uxOr.Click += new System.EventHandler(this.uxOr_Click);
            // 
            // uxXor
            // 
            this.uxXor.Location = new System.Drawing.Point(289, 152);
            this.uxXor.Name = "uxXor";
            this.uxXor.Size = new System.Drawing.Size(87, 32);
            this.uxXor.TabIndex = 7;
            this.uxXor.Text = "XOR";
            this.uxXor.UseVisualStyleBackColor = true;
            this.uxXor.Click += new System.EventHandler(this.uxXor_Click);
            // 
            // uxNot
            // 
            this.uxNot.Location = new System.Drawing.Point(289, 190);
            this.uxNot.Name = "uxNot";
            this.uxNot.Size = new System.Drawing.Size(87, 35);
            this.uxNot.TabIndex = 8;
            this.uxNot.Text = "NOT";
            this.uxNot.UseVisualStyleBackColor = true;
            this.uxNot.Click += new System.EventHandler(this.uxNot_Click);
            // 
            // uxClosingParenthesis
            // 
            this.uxClosingParenthesis.Location = new System.Drawing.Point(289, 231);
            this.uxClosingParenthesis.Name = "uxClosingParenthesis";
            this.uxClosingParenthesis.Size = new System.Drawing.Size(87, 36);
            this.uxClosingParenthesis.TabIndex = 9;
            this.uxClosingParenthesis.Text = ")";
            this.uxClosingParenthesis.UseVisualStyleBackColor = true;
            this.uxClosingParenthesis.Click += new System.EventHandler(this.uxClosingParenthesis_Click);
            // 
            // uxC
            // 
            this.uxC.Location = new System.Drawing.Point(193, 76);
            this.uxC.Name = "uxC";
            this.uxC.Size = new System.Drawing.Size(84, 31);
            this.uxC.TabIndex = 10;
            this.uxC.Text = "c";
            this.uxC.UseVisualStyleBackColor = true;
            this.uxC.Click += new System.EventHandler(this.uxC_Click);
            // 
            // uxNine
            // 
            this.uxNine.Location = new System.Drawing.Point(194, 113);
            this.uxNine.Name = "uxNine";
            this.uxNine.Size = new System.Drawing.Size(84, 33);
            this.uxNine.TabIndex = 11;
            this.uxNine.Text = "9";
            this.uxNine.UseVisualStyleBackColor = true;
            this.uxNine.Click += new System.EventHandler(this.uxNine_Click);
            // 
            // uxSix
            // 
            this.uxSix.Location = new System.Drawing.Point(194, 152);
            this.uxSix.Name = "uxSix";
            this.uxSix.Size = new System.Drawing.Size(84, 32);
            this.uxSix.TabIndex = 12;
            this.uxSix.Text = "6";
            this.uxSix.UseVisualStyleBackColor = true;
            this.uxSix.Click += new System.EventHandler(this.uxSix_Click);
            // 
            // uxThree
            // 
            this.uxThree.Location = new System.Drawing.Point(194, 190);
            this.uxThree.Name = "uxThree";
            this.uxThree.Size = new System.Drawing.Size(84, 35);
            this.uxThree.TabIndex = 13;
            this.uxThree.Text = "3";
            this.uxThree.UseVisualStyleBackColor = true;
            this.uxThree.Click += new System.EventHandler(this.uxThree_Click);
            // 
            // uxOpeningParenthesis
            // 
            this.uxOpeningParenthesis.Location = new System.Drawing.Point(193, 231);
            this.uxOpeningParenthesis.Name = "uxOpeningParenthesis";
            this.uxOpeningParenthesis.Size = new System.Drawing.Size(84, 36);
            this.uxOpeningParenthesis.TabIndex = 14;
            this.uxOpeningParenthesis.Text = "(";
            this.uxOpeningParenthesis.UseVisualStyleBackColor = true;
            this.uxOpeningParenthesis.Click += new System.EventHandler(this.uxOpeningParenthesis_Click);
            // 
            // uxB
            // 
            this.uxB.Location = new System.Drawing.Point(96, 75);
            this.uxB.Name = "uxB";
            this.uxB.Size = new System.Drawing.Size(91, 31);
            this.uxB.TabIndex = 15;
            this.uxB.Text = "b";
            this.uxB.UseVisualStyleBackColor = true;
            this.uxB.Click += new System.EventHandler(this.uxB_Click);
            // 
            // uxA
            // 
            this.uxA.Location = new System.Drawing.Point(7, 76);
            this.uxA.Name = "uxA";
            this.uxA.Size = new System.Drawing.Size(80, 31);
            this.uxA.TabIndex = 16;
            this.uxA.Text = "a";
            this.uxA.UseVisualStyleBackColor = true;
            this.uxA.Click += new System.EventHandler(this.uxA_Click);
            // 
            // uxSeven
            // 
            this.uxSeven.Location = new System.Drawing.Point(7, 113);
            this.uxSeven.Name = "uxSeven";
            this.uxSeven.Size = new System.Drawing.Size(80, 33);
            this.uxSeven.TabIndex = 17;
            this.uxSeven.Text = "7";
            this.uxSeven.UseVisualStyleBackColor = true;
            this.uxSeven.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxEight
            // 
            this.uxEight.Location = new System.Drawing.Point(96, 113);
            this.uxEight.Name = "uxEight";
            this.uxEight.Size = new System.Drawing.Size(90, 33);
            this.uxEight.TabIndex = 18;
            this.uxEight.Text = "8";
            this.uxEight.UseVisualStyleBackColor = true;
            this.uxEight.Click += new System.EventHandler(this.uxEight_Click);
            // 
            // uxFour
            // 
            this.uxFour.Location = new System.Drawing.Point(6, 152);
            this.uxFour.Name = "uxFour";
            this.uxFour.Size = new System.Drawing.Size(80, 32);
            this.uxFour.TabIndex = 19;
            this.uxFour.Text = "4";
            this.uxFour.UseVisualStyleBackColor = true;
            this.uxFour.Click += new System.EventHandler(this.uxFour_Click);
            // 
            // uxFive
            // 
            this.uxFive.Location = new System.Drawing.Point(96, 152);
            this.uxFive.Name = "uxFive";
            this.uxFive.Size = new System.Drawing.Size(90, 32);
            this.uxFive.TabIndex = 20;
            this.uxFive.Text = "5";
            this.uxFive.UseVisualStyleBackColor = true;
            this.uxFive.Click += new System.EventHandler(this.uxFive_Click);
            // 
            // uxOne
            // 
            this.uxOne.Location = new System.Drawing.Point(6, 190);
            this.uxOne.Name = "uxOne";
            this.uxOne.Size = new System.Drawing.Size(80, 35);
            this.uxOne.TabIndex = 21;
            this.uxOne.Text = "1";
            this.uxOne.UseVisualStyleBackColor = true;
            this.uxOne.Click += new System.EventHandler(this.uxOne_Click);
            // 
            // uxTwo
            // 
            this.uxTwo.Location = new System.Drawing.Point(96, 190);
            this.uxTwo.Name = "uxTwo";
            this.uxTwo.Size = new System.Drawing.Size(91, 35);
            this.uxTwo.TabIndex = 22;
            this.uxTwo.Text = "2";
            this.uxTwo.UseVisualStyleBackColor = true;
            this.uxTwo.Click += new System.EventHandler(this.uxTwo_Click);
            // 
            // uxEquals
            // 
            this.uxEquals.Location = new System.Drawing.Point(6, 231);
            this.uxEquals.Name = "uxEquals";
            this.uxEquals.Size = new System.Drawing.Size(80, 36);
            this.uxEquals.TabIndex = 23;
            this.uxEquals.Text = "=";
            this.uxEquals.UseVisualStyleBackColor = true;
            this.uxEquals.Click += new System.EventHandler(this.uxEquals_Click);
            // 
            // uxZero
            // 
            this.uxZero.Location = new System.Drawing.Point(96, 231);
            this.uxZero.Name = "uxZero";
            this.uxZero.Size = new System.Drawing.Size(90, 36);
            this.uxZero.TabIndex = 24;
            this.uxZero.Text = "0";
            this.uxZero.UseVisualStyleBackColor = true;
            this.uxZero.Click += new System.EventHandler(this.uxZero_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 275);
            this.Controls.Add(this.uxZero);
            this.Controls.Add(this.uxEquals);
            this.Controls.Add(this.uxTwo);
            this.Controls.Add(this.uxOne);
            this.Controls.Add(this.uxFive);
            this.Controls.Add(this.uxFour);
            this.Controls.Add(this.uxEight);
            this.Controls.Add(this.uxSeven);
            this.Controls.Add(this.uxA);
            this.Controls.Add(this.uxB);
            this.Controls.Add(this.uxOpeningParenthesis);
            this.Controls.Add(this.uxThree);
            this.Controls.Add(this.uxSix);
            this.Controls.Add(this.uxNine);
            this.Controls.Add(this.uxC);
            this.Controls.Add(this.uxClosingParenthesis);
            this.Controls.Add(this.uxNot);
            this.Controls.Add(this.uxXor);
            this.Controls.Add(this.uxOr);
            this.Controls.Add(this.uxAnd);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxF);
            this.Controls.Add(this.uxE);
            this.Controls.Add(this.uxD);
            this.Controls.Add(this.uxTextbox);
            this.Name = "UserInterface";
            this.Text = "Hex Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextbox;
        private System.Windows.Forms.Button uxD;
        private System.Windows.Forms.Button uxE;
        private System.Windows.Forms.Button uxF;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxAnd;
        private System.Windows.Forms.Button uxOr;
        private System.Windows.Forms.Button uxXor;
        private System.Windows.Forms.Button uxNot;
        private System.Windows.Forms.Button uxClosingParenthesis;
        private System.Windows.Forms.Button uxC;
        private System.Windows.Forms.Button uxNine;
        private System.Windows.Forms.Button uxSix;
        private System.Windows.Forms.Button uxThree;
        private System.Windows.Forms.Button uxOpeningParenthesis;
        private System.Windows.Forms.Button uxB;
        private System.Windows.Forms.Button uxA;
        private System.Windows.Forms.Button uxSeven;
        private System.Windows.Forms.Button uxEight;
        private System.Windows.Forms.Button uxFour;
        private System.Windows.Forms.Button uxFive;
        private System.Windows.Forms.Button uxOne;
        private System.Windows.Forms.Button uxTwo;
        private System.Windows.Forms.Button uxEquals;
        private System.Windows.Forms.Button uxZero;
    }
}

