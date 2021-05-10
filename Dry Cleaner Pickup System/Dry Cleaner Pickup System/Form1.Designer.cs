
namespace Dry_Cleaner_Pickup_System
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
            this.tbxTicketNumber = new System.Windows.Forms.TextBox();
            this.lblNewTicket = new System.Windows.Forms.Label();
            this.rbLaundry = new System.Windows.Forms.RadioButton();
            this.rbDryCleaning = new System.Windows.Forms.RadioButton();
            this.rbShoeRepair = new System.Windows.Forms.RadioButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblTicketNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTicketRetrieval = new System.Windows.Forms.Label();
            this.tbxTicketNumberRetrieval = new System.Windows.Forms.TextBox();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxFoundItems = new System.Windows.Forms.ListBox();
            this.btnReturnItems = new System.Windows.Forms.Button();
            this.lblClientNameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTicketNumber
            // 
            this.tbxTicketNumber.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTicketNumber.Location = new System.Drawing.Point(164, 47);
            this.tbxTicketNumber.Name = "tbxTicketNumber";
            this.tbxTicketNumber.Size = new System.Drawing.Size(243, 30);
            this.tbxTicketNumber.TabIndex = 0;
            // 
            // lblNewTicket
            // 
            this.lblNewTicket.AutoSize = true;
            this.lblNewTicket.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTicket.Location = new System.Drawing.Point(9, 9);
            this.lblNewTicket.Name = "lblNewTicket";
            this.lblNewTicket.Size = new System.Drawing.Size(109, 22);
            this.lblNewTicket.TabIndex = 1;
            this.lblNewTicket.Text = "New Ticket";
            // 
            // rbLaundry
            // 
            this.rbLaundry.AutoSize = true;
            this.rbLaundry.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaundry.Location = new System.Drawing.Point(13, 164);
            this.rbLaundry.Name = "rbLaundry";
            this.rbLaundry.Size = new System.Drawing.Size(104, 26);
            this.rbLaundry.TabIndex = 2;
            this.rbLaundry.TabStop = true;
            this.rbLaundry.Text = "Laundry";
            this.rbLaundry.UseVisualStyleBackColor = true;
            // 
            // rbDryCleaning
            // 
            this.rbDryCleaning.AutoSize = true;
            this.rbDryCleaning.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDryCleaning.Location = new System.Drawing.Point(123, 164);
            this.rbDryCleaning.Name = "rbDryCleaning";
            this.rbDryCleaning.Size = new System.Drawing.Size(147, 26);
            this.rbDryCleaning.TabIndex = 3;
            this.rbDryCleaning.TabStop = true;
            this.rbDryCleaning.Text = "Dry Cleaning";
            this.rbDryCleaning.UseVisualStyleBackColor = true;
            // 
            // rbShoeRepair
            // 
            this.rbShoeRepair.AutoSize = true;
            this.rbShoeRepair.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShoeRepair.Location = new System.Drawing.Point(276, 164);
            this.rbShoeRepair.Name = "rbShoeRepair";
            this.rbShoeRepair.Size = new System.Drawing.Size(131, 26);
            this.rbShoeRepair.TabIndex = 4;
            this.rbShoeRepair.TabStop = true;
            this.rbShoeRepair.Text = "Shoe repair";
            this.rbShoeRepair.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(12, 248);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(395, 33);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblTicketNumber
            // 
            this.lblTicketNumber.AutoSize = true;
            this.lblTicketNumber.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumber.Location = new System.Drawing.Point(9, 50);
            this.lblTicketNumber.Name = "lblTicketNumber";
            this.lblTicketNumber.Size = new System.Drawing.Size(149, 22);
            this.lblTicketNumber.TabIndex = 6;
            this.lblTicketNumber.Text = "Ticket number: ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(9, 91);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(131, 22);
            this.lblClientName.TabIndex = 8;
            this.lblClientName.Text = "Client name: ";
            // 
            // tbxClientName
            // 
            this.tbxClientName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientName.Location = new System.Drawing.Point(164, 91);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(243, 30);
            this.tbxClientName.TabIndex = 7;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(12, 139);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(51, 22);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(9, 215);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(120, 22);
            this.lblItemName.TabIndex = 11;
            this.lblItemName.Text = "Item name: ";
            // 
            // tbxItemName
            // 
            this.tbxItemName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxItemName.Location = new System.Drawing.Point(164, 212);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(243, 30);
            this.tbxItemName.TabIndex = 10;
            // 
            // lbxItems
            // 
            this.lbxItems.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 22;
            this.lbxItems.Location = new System.Drawing.Point(12, 299);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(395, 334);
            this.lbxItems.TabIndex = 12;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(12, 639);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(395, 33);
            this.btnCreateTicket.TabIndex = 13;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ticket number: ";
            // 
            // lblTicketRetrieval
            // 
            this.lblTicketRetrieval.AutoSize = true;
            this.lblTicketRetrieval.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketRetrieval.Location = new System.Drawing.Point(439, 12);
            this.lblTicketRetrieval.Name = "lblTicketRetrieval";
            this.lblTicketRetrieval.Size = new System.Drawing.Size(148, 22);
            this.lblTicketRetrieval.TabIndex = 15;
            this.lblTicketRetrieval.Text = "Ticket Retrieval";
            // 
            // tbxTicketNumberRetrieval
            // 
            this.tbxTicketNumberRetrieval.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTicketNumberRetrieval.Location = new System.Drawing.Point(594, 50);
            this.tbxTicketNumberRetrieval.Name = "tbxTicketNumberRetrieval";
            this.tbxTicketNumberRetrieval.Size = new System.Drawing.Size(243, 30);
            this.tbxTicketNumberRetrieval.TabIndex = 14;
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTicket.Location = new System.Drawing.Point(843, 48);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(199, 33);
            this.btnSearchTicket.TabIndex = 17;
            this.btnSearchTicket.Text = "Search Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Client name: ";
            // 
            // lbxFoundItems
            // 
            this.lbxFoundItems.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFoundItems.FormattingEnabled = true;
            this.lbxFoundItems.ItemHeight = 22;
            this.lbxFoundItems.Location = new System.Drawing.Point(443, 139);
            this.lbxFoundItems.Name = "lbxFoundItems";
            this.lbxFoundItems.Size = new System.Drawing.Size(599, 488);
            this.lbxFoundItems.TabIndex = 20;
            // 
            // btnReturnItems
            // 
            this.btnReturnItems.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItems.Location = new System.Drawing.Point(443, 640);
            this.btnReturnItems.Name = "btnReturnItems";
            this.btnReturnItems.Size = new System.Drawing.Size(599, 33);
            this.btnReturnItems.TabIndex = 21;
            this.btnReturnItems.Text = "Return Items";
            this.btnReturnItems.UseVisualStyleBackColor = true;
            this.btnReturnItems.Click += new System.EventHandler(this.btnReturnItems_Click);
            // 
            // lblClientNameValue
            // 
            this.lblClientNameValue.AutoSize = true;
            this.lblClientNameValue.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameValue.Location = new System.Drawing.Point(590, 114);
            this.lblClientNameValue.Name = "lblClientNameValue";
            this.lblClientNameValue.Size = new System.Drawing.Size(181, 22);
            this.lblClientNameValue.TabIndex = 22;
            this.lblClientNameValue.Text = "Client name Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 685);
            this.Controls.Add(this.lblClientNameValue);
            this.Controls.Add(this.btnReturnItems);
            this.Controls.Add(this.lbxFoundItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTicketRetrieval);
            this.Controls.Add(this.tbxTicketNumberRetrieval);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbxItemName);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.tbxClientName);
            this.Controls.Add(this.lblTicketNumber);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.rbShoeRepair);
            this.Controls.Add(this.rbDryCleaning);
            this.Controls.Add(this.rbLaundry);
            this.Controls.Add(this.lblNewTicket);
            this.Controls.Add(this.tbxTicketNumber);
            this.Name = "Form1";
            this.Text = "Dry Cleaners";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTicketNumber;
        private System.Windows.Forms.Label lblNewTicket;
        private System.Windows.Forms.RadioButton rbLaundry;
        private System.Windows.Forms.RadioButton rbDryCleaning;
        private System.Windows.Forms.RadioButton rbShoeRepair;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblTicketNumber;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicketRetrieval;
        private System.Windows.Forms.TextBox tbxTicketNumberRetrieval;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxFoundItems;
        private System.Windows.Forms.Button btnReturnItems;
        private System.Windows.Forms.Label lblClientNameValue;
    }
}

