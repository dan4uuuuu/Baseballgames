﻿namespace BaseballClientGames
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.label1 = new System.Windows.Forms.Label();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seasonTagID = new System.Windows.Forms.TextBox();
            this.teamIDs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientGamesLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.scoutGamesLabel = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iGameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTeamIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTeamIDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strGameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameIDsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // radDropDownList1
            // 
            radListDataItem1.Tag = "1";
            radListDataItem1.Text = "Production";
            radListDataItem2.Tag = "2";
            radListDataItem2.Text = "Test";
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(157, 37);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(215, 20);
            this.radDropDownList1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISeasonTagId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client TeamIds (CSV)";
            // 
            // seasonTagID
            // 
            this.seasonTagID.Location = new System.Drawing.Point(157, 86);
            this.seasonTagID.Name = "seasonTagID";
            this.seasonTagID.Size = new System.Drawing.Size(215, 20);
            this.seasonTagID.TabIndex = 4;
            // 
            // teamIDs
            // 
            this.teamIDs.Location = new System.Drawing.Point(157, 126);
            this.teamIDs.Name = "teamIDs";
            this.teamIDs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teamIDs.Size = new System.Drawing.Size(355, 20);
            this.teamIDs.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientGamesLabel
            // 
            this.clientGamesLabel.AutoSize = true;
            this.clientGamesLabel.Location = new System.Drawing.Point(13, 329);
            this.clientGamesLabel.Name = "clientGamesLabel";
            this.clientGamesLabel.Size = new System.Drawing.Size(69, 13);
            this.clientGamesLabel.TabIndex = 8;
            this.clientGamesLabel.Text = "Client Games";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iGameIDDataGridViewTextBoxColumn,
            this.iTeamIDADataGridViewTextBoxColumn,
            this.iTeamIDBDataGridViewTextBoxColumn,
            this.strGameNameDataGridViewTextBoxColumn,
            this.dtGameDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameIDsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 478);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.gameIDsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(777, 357);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 478);
            this.dataGridView2.TabIndex = 10;
            // 
            // scoutGamesLabel
            // 
            this.scoutGamesLabel.AutoSize = true;
            this.scoutGamesLabel.Location = new System.Drawing.Point(774, 329);
            this.scoutGamesLabel.Name = "scoutGamesLabel";
            this.scoutGamesLabel.Size = new System.Drawing.Size(71, 13);
            this.scoutGamesLabel.TabIndex = 11;
            this.scoutGamesLabel.Text = "Scout Games";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(157, 167);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 12;
            this.dateTimeFrom.Value = new System.DateTime(2018, 1, 17, 2, 32, 23, 0);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(157, 203);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date from";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date to";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Export Client Games to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(932, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Export Scout Games to Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iGameID";
            this.dataGridViewTextBoxColumn1.HeaderText = "iGameID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "iTeamIDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "iTeamIDA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "iTeamIDB";
            this.dataGridViewTextBoxColumn3.HeaderText = "iTeamIDB";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "strGameName";
            this.dataGridViewTextBoxColumn4.HeaderText = "strGameName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dtGameDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "dtGameDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // gameIDsBindingSource
            // 
            this.gameIDsBindingSource.DataSource = typeof(DAL.Models.GameIDs);
            // 
            // iGameIDDataGridViewTextBoxColumn
            // 
            this.iGameIDDataGridViewTextBoxColumn.DataPropertyName = "iGameID";
            this.iGameIDDataGridViewTextBoxColumn.HeaderText = "iGameID";
            this.iGameIDDataGridViewTextBoxColumn.Name = "iGameIDDataGridViewTextBoxColumn";
            this.iGameIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTeamIDADataGridViewTextBoxColumn
            // 
            this.iTeamIDADataGridViewTextBoxColumn.DataPropertyName = "iTeamIDA";
            this.iTeamIDADataGridViewTextBoxColumn.HeaderText = "iTeamIDA";
            this.iTeamIDADataGridViewTextBoxColumn.Name = "iTeamIDADataGridViewTextBoxColumn";
            this.iTeamIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTeamIDBDataGridViewTextBoxColumn
            // 
            this.iTeamIDBDataGridViewTextBoxColumn.DataPropertyName = "iTeamIDB";
            this.iTeamIDBDataGridViewTextBoxColumn.HeaderText = "iTeamIDB";
            this.iTeamIDBDataGridViewTextBoxColumn.Name = "iTeamIDBDataGridViewTextBoxColumn";
            this.iTeamIDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strGameNameDataGridViewTextBoxColumn
            // 
            this.strGameNameDataGridViewTextBoxColumn.DataPropertyName = "strGameName";
            this.strGameNameDataGridViewTextBoxColumn.HeaderText = "strGameName";
            this.strGameNameDataGridViewTextBoxColumn.Name = "strGameNameDataGridViewTextBoxColumn";
            this.strGameNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.strGameNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // dtGameDateDataGridViewTextBoxColumn
            // 
            this.dtGameDateDataGridViewTextBoxColumn.DataPropertyName = "dtGameDate";
            this.dtGameDateDataGridViewTextBoxColumn.HeaderText = "dtGameDate";
            this.dtGameDateDataGridViewTextBoxColumn.Name = "dtGameDateDataGridViewTextBoxColumn";
            this.dtGameDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 847);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.scoutGamesLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clientGamesLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamIDs);
            this.Controls.Add(this.seasonTagID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameIDsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seasonTagID;
        private System.Windows.Forms.TextBox teamIDs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label clientGamesLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gameIDsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTeamIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTeamIDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strGameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtGameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label scoutGamesLabel;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
