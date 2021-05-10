
namespace Linked_List_Of_People
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
            this.lblName = new System.Windows.Forms.Label();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.nudIndex = new System.Windows.Forms.NumericUpDown();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnSelectName = new System.Windows.Forms.Button();
            this.lblAmountOfNames = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSelectedNameValue = new System.Windows.Forms.Label();
            this.lblSelectedName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lbxNames
            // 
            this.lbxNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.ItemHeight = 21;
            this.lbxNames.Location = new System.Drawing.Point(16, 198);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(432, 256);
            this.lbxNames.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(84, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(364, 27);
            this.tbxName.TabIndex = 2;
            // 
            // nudIndex
            // 
            this.nudIndex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIndex.Location = new System.Drawing.Point(84, 106);
            this.nudIndex.Name = "nudIndex";
            this.nudIndex.Size = new System.Drawing.Size(120, 27);
            this.nudIndex.TabIndex = 3;
            // 
            // btnAddName
            // 
            this.btnAddName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddName.Location = new System.Drawing.Point(84, 42);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(179, 31);
            this.btnAddName.TabIndex = 4;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFirst.Location = new System.Drawing.Point(269, 42);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(179, 31);
            this.btnRemoveFirst.TabIndex = 5;
            this.btnRemoveFirst.Text = "Remove First Name";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnSelectName
            // 
            this.btnSelectName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectName.Location = new System.Drawing.Point(210, 106);
            this.btnSelectName.Name = "btnSelectName";
            this.btnSelectName.Size = new System.Drawing.Size(238, 31);
            this.btnSelectName.TabIndex = 6;
            this.btnSelectName.Text = "Select name at index";
            this.btnSelectName.UseVisualStyleBackColor = true;
            this.btnSelectName.Click += new System.EventHandler(this.btnSelectName_Click);
            // 
            // lblAmountOfNames
            // 
            this.lblAmountOfNames.AutoSize = true;
            this.lblAmountOfNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfNames.Location = new System.Drawing.Point(12, 174);
            this.lblAmountOfNames.Name = "lblAmountOfNames";
            this.lblAmountOfNames.Size = new System.Drawing.Size(158, 21);
            this.lblAmountOfNames.TabIndex = 7;
            this.lblAmountOfNames.Text = "Amount of names: ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(167, 174);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(19, 21);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "0";
            // 
            // lblSelectedNameValue
            // 
            this.lblSelectedNameValue.AutoSize = true;
            this.lblSelectedNameValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedNameValue.Location = new System.Drawing.Point(345, 140);
            this.lblSelectedNameValue.Name = "lblSelectedNameValue";
            this.lblSelectedNameValue.Size = new System.Drawing.Size(50, 21);
            this.lblSelectedNameValue.TabIndex = 10;
            this.lblSelectedNameValue.Text = "none";
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedName.Location = new System.Drawing.Point(206, 140);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(133, 21);
            this.lblSelectedName.TabIndex = 9;
            this.lblSelectedName.Text = "Selected name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 471);
            this.Controls.Add(this.lblSelectedNameValue);
            this.Controls.Add(this.lblSelectedName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountOfNames);
            this.Controls.Add(this.btnSelectName);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.nudIndex);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Names Collector";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnSelectName;
        private System.Windows.Forms.Label lblAmountOfNames;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSelectedNameValue;
        private System.Windows.Forms.Label lblSelectedName;
    }
}

