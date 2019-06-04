namespace MysteryGenerator
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
            this.txtLocationNumber = new System.Windows.Forms.TextBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstMonsters = new System.Windows.Forms.ListBox();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.txtMonstersNum = new System.Windows.Forms.TextBox();
            this.txtTypesNum = new System.Windows.Forms.TextBox();
            this.btnReloadData = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLocationNumber
            // 
            this.txtLocationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationNumber.Location = new System.Drawing.Point(13, 13);
            this.txtLocationNumber.Name = "txtLocationNumber";
            this.txtLocationNumber.ReadOnly = true;
            this.txtLocationNumber.Size = new System.Drawing.Size(150, 44);
            this.txtLocationNumber.TabIndex = 0;
            this.txtLocationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(12, 63);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(150, 147);
            this.lstLocations.Sorted = true;
            this.lstLocations.TabIndex = 1;
            // 
            // lstMonsters
            // 
            this.lstMonsters.FormattingEnabled = true;
            this.lstMonsters.Location = new System.Drawing.Point(168, 63);
            this.lstMonsters.Name = "lstMonsters";
            this.lstMonsters.Size = new System.Drawing.Size(150, 147);
            this.lstMonsters.TabIndex = 3;
            // 
            // lstTypes
            // 
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.Location = new System.Drawing.Point(324, 63);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(150, 147);
            this.lstTypes.TabIndex = 4;
            // 
            // txtMonstersNum
            // 
            this.txtMonstersNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonstersNum.Location = new System.Drawing.Point(169, 13);
            this.txtMonstersNum.Name = "txtMonstersNum";
            this.txtMonstersNum.ReadOnly = true;
            this.txtMonstersNum.Size = new System.Drawing.Size(150, 44);
            this.txtMonstersNum.TabIndex = 5;
            this.txtMonstersNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTypesNum
            // 
            this.txtTypesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypesNum.Location = new System.Drawing.Point(325, 13);
            this.txtTypesNum.Name = "txtTypesNum";
            this.txtTypesNum.ReadOnly = true;
            this.txtTypesNum.Size = new System.Drawing.Size(150, 44);
            this.txtTypesNum.TabIndex = 6;
            this.txtTypesNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReloadData
            // 
            this.btnReloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadData.Location = new System.Drawing.Point(481, 63);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(150, 45);
            this.btnReloadData.TabIndex = 7;
            this.btnReloadData.Text = "Reload";
            this.btnReloadData.UseVisualStyleBackColor = true;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(481, 114);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(150, 45);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(481, 165);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(13, 216);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(618, 121);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 349);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnReloadData);
            this.Controls.Add(this.txtTypesNum);
            this.Controls.Add(this.txtMonstersNum);
            this.Controls.Add(this.lstTypes);
            this.Controls.Add(this.lstMonsters);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.txtLocationNumber);
            this.Name = "Form1";
            this.Text = "Mystery Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocationNumber;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstMonsters;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.TextBox txtMonstersNum;
        private System.Windows.Forms.TextBox txtTypesNum;
        private System.Windows.Forms.Button btnReloadData;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

