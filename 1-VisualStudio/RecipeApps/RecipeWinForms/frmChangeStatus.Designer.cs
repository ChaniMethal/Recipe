namespace RecipeWinForm
{
    partial class frmChangeStatus
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
            tblMain = new TableLayoutPanel();
            lblHeader = new Label();
            lblSubHeader = new Label();
            tblStatus = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDrafted = new TextBox();
            txtPublished = new TextBox();
            txtArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblStatus.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblSubHeader, 0, 1);
            tblMain.Controls.Add(tblStatus, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.SteelBlue;
            lblHeader.Location = new Point(3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1094, 157);
            lblHeader.TabIndex = 0;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubHeader
            // 
            lblSubHeader.AutoSize = true;
            lblSubHeader.Dock = DockStyle.Fill;
            lblSubHeader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeader.ForeColor = Color.SteelBlue;
            lblSubHeader.Location = new Point(3, 157);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(1094, 157);
            lblSubHeader.TabIndex = 1;
            lblSubHeader.Text = "Current Status: ";
            lblSubHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 4;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.Controls.Add(lblStatusDates, 0, 1);
            tblStatus.Controls.Add(lblDrafted, 1, 0);
            tblStatus.Controls.Add(lblPublished, 2, 0);
            tblStatus.Controls.Add(lblArchived, 3, 0);
            tblStatus.Controls.Add(txtDrafted, 1, 1);
            tblStatus.Controls.Add(txtPublished, 2, 1);
            tblStatus.Controls.Add(txtArchived, 3, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(3, 317);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatus.Size = new Size(1094, 151);
            tblStatus.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 75);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(267, 76);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(276, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(267, 75);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(549, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(267, 75);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(822, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(269, 75);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDrafted
            // 
            txtDrafted.BackColor = Color.AliceBlue;
            txtDrafted.BorderStyle = BorderStyle.None;
            txtDrafted.Dock = DockStyle.Fill;
            txtDrafted.Location = new Point(276, 78);
            txtDrafted.Name = "txtDrafted";
            txtDrafted.Size = new Size(267, 27);
            txtDrafted.TabIndex = 4;
            txtDrafted.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPublished
            // 
            txtPublished.BackColor = Color.AliceBlue;
            txtPublished.BorderStyle = BorderStyle.None;
            txtPublished.Dock = DockStyle.Fill;
            txtPublished.Location = new Point(549, 78);
            txtPublished.Name = "txtPublished";
            txtPublished.Size = new Size(267, 27);
            txtPublished.TabIndex = 5;
            txtPublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtArchived
            // 
            txtArchived.BackColor = Color.AliceBlue;
            txtArchived.BorderStyle = BorderStyle.None;
            txtArchived.Dock = DockStyle.Fill;
            txtArchived.Location = new Point(822, 78);
            txtArchived.Name = "txtArchived";
            txtArchived.Size = new Size(269, 27);
            txtArchived.TabIndex = 6;
            txtArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 474);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.Size = new Size(1094, 153);
            tblButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.BackColor = Color.LightSteelBlue;
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Font = new Font("Segoe UI", 16.2F);
            btnDraft.Location = new Point(3, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(358, 147);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // btnPublish
            // 
            btnPublish.BackColor = Color.LightSteelBlue;
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Font = new Font("Segoe UI", 16.2F);
            btnPublish.Location = new Point(367, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(358, 147);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.LightSteelBlue;
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Font = new Font("Segoe UI", 16.2F);
            btnArchive.Location = new Point(731, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(360, 147);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblSubHeader;
        private TableLayoutPanel tblStatus;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDrafted;
        private TextBox txtPublished;
        private TextBox txtArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}