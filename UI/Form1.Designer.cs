﻿

// namespace ElevatorControlSystem.UI
// {
//     partial class Form1
//     {
//         /// <summary>
//         /// Required designer variable.
//         /// </summary>
//         private System.ComponentModel.IContainer components = null;

//         /// <summary>
//         /// Clean up any resources being used.
//         /// </summary>
//         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//         protected override void Dispose(bool disposing)
//         {
//             if (disposing && (components != null))
//             {
//                 components.Dispose();
//             }
//             base.Dispose(disposing);
//         }

//         #region Windows Form Designer generated code

//         /// <summary>
//         /// Required method for Designer support - do not modify
//         /// the contents of this method with the code editor.
//         /// </summary>
//         private void InitializeComponent()
//         {
//             this.components = new System.ComponentModel.Container();
//             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//             this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
//             this.closeDoorTimer = new System.Windows.Forms.Timer(this.components);
//             this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
//             this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
//             this.openDoorTimer = new System.Windows.Forms.Timer(this.components);
//             this.panel1 = new System.Windows.Forms.Panel();
//             this.lblFloorDisplay = new System.Windows.Forms.Label();
//             this.label1 = new System.Windows.Forms.Label();
//             this.label2 = new System.Windows.Forms.Label();
//             this.btnDelete = new System.Windows.Forms.Button();
//             this.btnCancel = new System.Windows.Forms.Button();
//             this.btnCall1 = new System.Windows.Forms.Button();
//             this.btnCall2 = new System.Windows.Forms.Button();
//             this.doorRight_1 = new System.Windows.Forms.PictureBox();
//             this.doorLeft_1 = new System.Windows.Forms.PictureBox();
//             this.doorLeft_G = new System.Windows.Forms.PictureBox();
//             this.doorRight_G = new System.Windows.Forms.PictureBox();
//             this.mainElevator = new System.Windows.Forms.PictureBox();
//             this.pictureBox2 = new System.Windows.Forms.PictureBox();
//             this.pictureBox1 = new System.Windows.Forms.PictureBox();
//             this.btn_Close = new System.Windows.Forms.Button();
//             this.btn_Open = new System.Windows.Forms.Button();
//             this.btn_G = new System.Windows.Forms.Button();
//             this.btn_1 = new System.Windows.Forms.Button();
//             this.liftPanel = new System.Windows.Forms.PictureBox();
//             this.autoDoorTimer = new System.Windows.Forms.Timer(this.components);
//             ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
//             this.panel1.SuspendLayout();
//             ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//             ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
//             this.SuspendLayout();
//             // 
//             // liftTimerUp
//             // 
//             this.liftTimerUp.Interval = 50;
//             this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
//             // 
//             // closeDoorTimer
//             // 
//             this.closeDoorTimer.Tick += new System.EventHandler(this.closeDoorTimer_Tick);
//             // 
//             // dataGridViewLogs - ULTRA PREMIUM STYLING
//             // 
//             this.dataGridViewLogs.AllowUserToAddRows = false;
//             this.dataGridViewLogs.AllowUserToDeleteRows = false;
//             this.dataGridViewLogs.AllowUserToResizeRows = false;
//             this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//             | System.Windows.Forms.AnchorStyles.Left)
//             | System.Windows.Forms.AnchorStyles.Right)));
//             this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//             this.dataGridViewLogs.BackgroundColor = System.Drawing.Color.White;
//             this.dataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
//             this.dataGridViewLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
//             this.dataGridViewLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//             dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//             dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
//             dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
//             dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
//             dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//             this.dataGridViewLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//             this.dataGridViewLogs.ColumnHeadersHeight = 50;
//             this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
//             dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//             dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
//             dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
//             dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
//             dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
//             dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//             this.dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle2;
//             this.dataGridViewLogs.EnableHeadersVisualStyles = false;
//             this.dataGridViewLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
//             this.dataGridViewLogs.Location = new System.Drawing.Point(968, 12);
//             this.dataGridViewLogs.MultiSelect = false;
//             this.dataGridViewLogs.Name = "dataGridViewLogs";
//             this.dataGridViewLogs.ReadOnly = true;
//             dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//             dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
//             dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
//             dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
//             dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//             this.dataGridViewLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
//             this.dataGridViewLogs.RowHeadersVisible = false;
//             this.dataGridViewLogs.RowHeadersWidth = 51;
//             this.dataGridViewLogs.RowTemplate.Height = 40;
//             this.dataGridViewLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//             this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//             this.dataGridViewLogs.ShowCellErrors = false;
//             this.dataGridViewLogs.ShowCellToolTips = false;
//             this.dataGridViewLogs.ShowEditingIcon = false;
//             this.dataGridViewLogs.ShowRowErrors = false;
//             this.dataGridViewLogs.Size = new System.Drawing.Size(552, 645);
//             this.dataGridViewLogs.TabIndex = 10;
//             this.dataGridViewLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogs_CellContentClick);
//             // 
//             // liftTimerDown
//             // 
//             this.liftTimerDown.Interval = 50;
//             this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
//             // 
//             // openDoorTimer
//             // 
//             this.openDoorTimer.Tick += new System.EventHandler(this.openDoorTimer_Tick);
//             // 
//             // panel1 - ENHANCED LED DISPLAY
//             // 
//             this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
//             this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//             this.panel1.Controls.Add(this.lblFloorDisplay);
//             this.panel1.Location = new System.Drawing.Point(646, 131);
//             this.panel1.Name = "panel1";
//             this.panel1.Size = new System.Drawing.Size(114, 101);
//             this.panel1.TabIndex = 15;
//             this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
//             // 
//             // lblFloorDisplay - ENHANCED LED STYLE
//             // 
//             this.lblFloorDisplay.AutoSize = true;
//             this.lblFloorDisplay.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.lblFloorDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
//             this.lblFloorDisplay.Location = new System.Drawing.Point(15, 15);
//             this.lblFloorDisplay.Name = "lblFloorDisplay";
//             this.lblFloorDisplay.Size = new System.Drawing.Size(0, 63);
//             this.lblFloorDisplay.TabIndex = 0;
//             // 
//             // label1 - ENHANCED FLOOR LABEL
//             // 
//             this.label1.AutoSize = true;
//             this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.label1.ForeColor = System.Drawing.Color.White;
//             this.label1.Location = new System.Drawing.Point(-6, 9);
//             this.label1.Name = "label1";
//             this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
//             this.label1.Size = new System.Drawing.Size(99, 38);
//             this.label1.TabIndex = 16;
//             this.label1.Text = "Floor 2";
//             // 
//             // label2 - ENHANCED FLOOR LABEL
//             // 
//             this.label2.AutoSize = true;
//             this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
//             this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.label2.ForeColor = System.Drawing.Color.White;
//             this.label2.Location = new System.Drawing.Point(-6, 423);
//             this.label2.Name = "label2";
//             this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
//             this.label2.Size = new System.Drawing.Size(99, 38);
//             this.label2.TabIndex = 17;
//             this.label2.Text = "Floor 1";
//             // 
//             // btnDelete - ENHANCED MODERN BUTTON
//             // 
//             this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
//             this.btnDelete.FlatAppearance.BorderSize = 0;
//             this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
//             this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(68)))), ((int)(((byte)(52)))));
//             this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//             this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.btnDelete.ForeColor = System.Drawing.Color.White;
//             this.btnDelete.Location = new System.Drawing.Point(1062, 663);
//             this.btnDelete.Name = "btnDelete";
//             this.btnDelete.Size = new System.Drawing.Size(140, 52);
//             this.btnDelete.TabIndex = 18;
//             this.btnDelete.Text = "Delete";
//             this.btnDelete.UseVisualStyleBackColor = false;
//             this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//             // 
//             // btnCancel - ENHANCED MODERN BUTTON
//             // 
//             this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
//             this.btnCancel.FlatAppearance.BorderSize = 0;
//             this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(136)))), ((int)(((byte)(16)))));
//             this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
//             this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//             this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.btnCancel.ForeColor = System.Drawing.Color.White;
//             this.btnCancel.Location = new System.Drawing.Point(1263, 663);
//             this.btnCancel.Name = "btnCancel";
//             this.btnCancel.Size = new System.Drawing.Size(140, 52);
//             this.btnCancel.TabIndex = 19;
//             this.btnCancel.Text = "Cancel";
//             this.btnCancel.UseVisualStyleBackColor = false;
//             this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
//             // 
//             // btnCall1
//             // 
//             this.btnCall1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Call_2.png");
//             this.btnCall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btnCall1.FlatAppearance.BorderSize = 0;
//             this.btnCall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//             this.btnCall1.Location = new System.Drawing.Point(419, 640);
//             this.btnCall1.Name = "btnCall1";
//             this.btnCall1.Size = new System.Drawing.Size(60, 60);
//             this.btnCall1.TabIndex = 14;
//             this.btnCall1.UseVisualStyleBackColor = true;
//             this.btnCall1.Click += new System.EventHandler(this.btnCall1_Click);
//             // 
//             // btnCall2
//             // 
//             this.btnCall2.BackgroundImage = System.Drawing.Image.FromFile("Resources/Call.png");
//             this.btnCall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btnCall2.FlatAppearance.BorderSize = 0;
//             this.btnCall2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//             this.btnCall2.Location = new System.Drawing.Point(419, 228);
//             this.btnCall2.Name = "btnCall2";
//             this.btnCall2.Size = new System.Drawing.Size(60, 60);
//             this.btnCall2.TabIndex = 13;
//             this.btnCall2.UseVisualStyleBackColor = true;
//             this.btnCall2.Click += new System.EventHandler(this.btnCall2_Click);
//             // 
//             // doorRight_1 (FLOOR 2 - RIGHT DOOR)
//             // 
//             this.doorRight_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Elevator_2.jpg");
//             this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.doorRight_1.Location = new System.Drawing.Point(260, 99);
//             this.doorRight_1.Name = "doorRight_1";
//             this.doorRight_1.Size = new System.Drawing.Size(100, 236);
//             this.doorRight_1.TabIndex = 9;
//             this.doorRight_1.TabStop = false;
//             // 
//             // doorLeft_1 (FLOOR 2 - LEFT DOOR)
//             // 
//             this.doorLeft_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Elevator_2.jpg");
//             this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.doorLeft_1.Location = new System.Drawing.Point(160, 99);
//             this.doorLeft_1.Name = "doorLeft_1";
//             this.doorLeft_1.Size = new System.Drawing.Size(100, 236);
//             this.doorLeft_1.TabIndex = 8;
//             this.doorLeft_1.TabStop = false;
//             // 
//             // doorLeft_G (GROUND FLOOR - LEFT DOOR)
//             // 
//             this.doorLeft_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/Elevator_2.jpg");
//             this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.doorLeft_G.Location = new System.Drawing.Point(160, 514);
//             this.doorLeft_G.Name = "doorLeft_G";
//             this.doorLeft_G.Size = new System.Drawing.Size(100, 236);
//             this.doorLeft_G.TabIndex = 6;
//             this.doorLeft_G.TabStop = false;
//             // 
//             // doorRight_G (GROUND FLOOR - RIGHT DOOR)
//             // 
//             this.doorRight_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/Elevator_2.jpg");
//             this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.doorRight_G.Location = new System.Drawing.Point(260, 514);
//             this.doorRight_G.Name = "doorRight_G";
//             this.doorRight_G.Size = new System.Drawing.Size(100, 236);
//             this.doorRight_G.TabIndex = 7;
//             this.doorRight_G.TabStop = false;
//             // 
//             // mainElevator
//             // 
//             this.mainElevator.BackgroundImage = System.Drawing.Image.FromFile("Resources/lift_transparent.png");
//             this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.mainElevator.Location = new System.Drawing.Point(179, 514);
//             this.mainElevator.Name = "mainElevator";
//             this.mainElevator.Size = new System.Drawing.Size(162, 236);
//             this.mainElevator.TabIndex = 0;
//             this.mainElevator.TabStop = false;
//             // 
//             // pictureBox2
//             // 
//             this.pictureBox2.BackgroundImage = System.Drawing.Image.FromFile("Resources/istockphoto-532413706-612x612.jpg");
//             this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.pictureBox2.Location = new System.Drawing.Point(-1, 414);
//             this.pictureBox2.Name = "pictureBox2";
//             this.pictureBox2.Size = new System.Drawing.Size(539, 368);
//             this.pictureBox2.TabIndex = 12;
//             this.pictureBox2.TabStop = false;
//             this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
//             // 
//             // pictureBox1
//             // 
//             this.pictureBox1.BackgroundImage = System.Drawing.Image.FromFile("Resources/istockphoto-532413706-612x612.jpg");
//             this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
//             this.pictureBox1.Name = "pictureBox1";
//             this.pictureBox1.Size = new System.Drawing.Size(539, 368);
//             this.pictureBox1.TabIndex = 11;
//             this.pictureBox1.TabStop = false;
//             // 
//             // btn_Close
//             // 
//             this.btn_Close.BackColor = System.Drawing.SystemColors.ControlDark;
//             this.btn_Close.BackgroundImage = System.Drawing.Image.FromFile("Resources/closedoorsbutton.png");
//             this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btn_Close.Location = new System.Drawing.Point(723, 525);
//             this.btn_Close.Name = "btn_Close";
//             this.btn_Close.Size = new System.Drawing.Size(80, 77);
//             this.btn_Close.TabIndex = 5;
//             this.btn_Close.UseVisualStyleBackColor = false;
//             this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
//             // 
//             // btn_Open
//             // 
//             this.btn_Open.BackColor = System.Drawing.SystemColors.ButtonShadow;
//             this.btn_Open.BackgroundImage = System.Drawing.Image.FromFile("Resources/opendoorbutton.png");
//             this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btn_Open.Location = new System.Drawing.Point(612, 525);
//             this.btn_Open.Name = "btn_Open";
//             this.btn_Open.Size = new System.Drawing.Size(80, 77);
//             this.btn_Open.TabIndex = 4;
//             this.btn_Open.UseVisualStyleBackColor = false;
//             this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
//             // 
//             // btn_G
//             // 
//             this.btn_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/s-l1600__65659.jpg");
//             this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btn_G.Location = new System.Drawing.Point(666, 397);
//             this.btn_G.Name = "btn_G";
//             this.btn_G.Size = new System.Drawing.Size(81, 83);
//             this.btn_G.TabIndex = 3;
//             this.btn_G.UseVisualStyleBackColor = true;
//             this.btn_G.Click += new System.EventHandler(this.btn_G_click);
//             // 
//             // btn_1
//             // 
//             this.btn_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/s-l1600__49602.jpg");
//             this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.btn_1.Location = new System.Drawing.Point(666, 280);
//             this.btn_1.Name = "btn_1";
//             this.btn_1.Size = new System.Drawing.Size(81, 83);
//             this.btn_1.TabIndex = 2;
//             this.btn_1.UseVisualStyleBackColor = true;
//             this.btn_1.Click += new System.EventHandler(this.btn_1_click);
//             // 
//             // liftPanel
//             // 
//             this.liftPanel.BackgroundImage = System.Drawing.Image.FromFile("Resources/panel.png");
//             this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//             this.liftPanel.Location = new System.Drawing.Point(599, 121);
//             this.liftPanel.Name = "liftPanel";
//             this.liftPanel.Size = new System.Drawing.Size(218, 548);
//             this.liftPanel.TabIndex = 1;
//             this.liftPanel.TabStop = false;
//             // 
//             // autoDoorTimer
//             // 
//             this.autoDoorTimer.Interval = 50;
//             this.autoDoorTimer.Tick += new System.EventHandler(this.autoDoorTimer_Tick);
//             // 
//             // Form1
//             // 
//             this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//             this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
//             this.ClientSize = new System.Drawing.Size(1532, 775);
//             this.Controls.Add(this.btnCancel);
//             this.Controls.Add(this.btnDelete);
//             this.Controls.Add(this.label2);
//             this.Controls.Add(this.label1);
//             this.Controls.Add(this.panel1);
//             this.Controls.Add(this.btnCall1);
//             this.Controls.Add(this.btnCall2);
//             this.Controls.Add(this.doorRight_1);
//             this.Controls.Add(this.doorLeft_1);
//             this.Controls.Add(this.doorLeft_G);
//             this.Controls.Add(this.doorRight_G);
//             this.Controls.Add(this.mainElevator);
//             this.Controls.Add(this.pictureBox2);
//             this.Controls.Add(this.pictureBox1);
//             this.Controls.Add(this.dataGridViewLogs);
//             this.Controls.Add(this.btn_Close);
//             this.Controls.Add(this.btn_Open);
//             this.Controls.Add(this.btn_G);
//             this.Controls.Add(this.btn_1);
//             this.Controls.Add(this.liftPanel);
//             this.Location = new System.Drawing.Point(100, 100);
//             this.Name = "Form1";
//             this.Text = "Elevator System";
//             this.Load += new System.EventHandler(this.Form1_Load);
//             ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
//             this.panel1.ResumeLayout(false);
//             this.panel1.PerformLayout();
//             ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//             ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
//             this.ResumeLayout(false);
//             this.PerformLayout();

//         }

//         #endregion

//         private System.Windows.Forms.PictureBox mainElevator;
//         private System.Windows.Forms.PictureBox liftPanel;
//         private System.Windows.Forms.Button btn_1;
//         private System.Windows.Forms.Button btn_G;
//         private System.Windows.Forms.Button btn_Open;
//         private System.Windows.Forms.Button btn_Close;
//         private System.Windows.Forms.Timer liftTimerUp;
//         private System.Windows.Forms.PictureBox doorLeft_G;
//         private System.Windows.Forms.PictureBox doorRight_G;
//         private System.Windows.Forms.PictureBox doorRight_1;
//         private System.Windows.Forms.PictureBox doorLeft_1;
//         private System.Windows.Forms.Timer closeDoorTimer;
//         private System.Windows.Forms.DataGridView dataGridViewLogs;
//         private System.Windows.Forms.Timer liftTimerDown;
//         private System.Windows.Forms.PictureBox pictureBox1;
//         private System.Windows.Forms.PictureBox pictureBox2;
//         private System.Windows.Forms.Timer openDoorTimer;
//         private System.Windows.Forms.Button btnCall2;
//         private System.Windows.Forms.Button btnCall1;
//         private System.Windows.Forms.Panel panel1;
//         private System.Windows.Forms.Label label1;
//         private System.Windows.Forms.Label label2;
//         private System.Windows.Forms.Label lblFloorDisplay;
//         private System.Windows.Forms.Button btnDelete;
//         private System.Windows.Forms.Button btnCancel;
//         private System.Windows.Forms.Timer autoDoorTimer;
//     }
// }





namespace ElevatorControlSystem.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
            this.closeDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
            this.openDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFloorDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCall1 = new System.Windows.Forms.Button();
            this.btnCall2 = new System.Windows.Forms.Button();
            this.doorRight_1 = new System.Windows.Forms.PictureBox();
            this.doorLeft_1 = new System.Windows.Forms.PictureBox();
            this.doorLeft_G = new System.Windows.Forms.PictureBox();
            this.doorRight_G = new System.Windows.Forms.PictureBox();
            this.mainElevator = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.liftPanel = new System.Windows.Forms.PictureBox();
            this.autoDoorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // liftTimerUp
            // 
            this.liftTimerUp.Interval = 50;
            this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
            // 
            // closeDoorTimer
            // 
            this.closeDoorTimer.Tick += new System.EventHandler(this.closeDoorTimer_Tick);
            // 
            // dataGridViewLogs - ULTRA PREMIUM STYLING
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.AllowUserToResizeRows = false;
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLogs.ColumnHeadersHeight = 50;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLogs.EnableHeadersVisualStyles = false;
            this.dataGridViewLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dataGridViewLogs.Location = new System.Drawing.Point(968, 12);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLogs.RowHeadersVisible = false;
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 40;
            this.dataGridViewLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLogs.ShowCellErrors = false;
            this.dataGridViewLogs.ShowCellToolTips = false;
            this.dataGridViewLogs.ShowEditingIcon = false;
            this.dataGridViewLogs.ShowRowErrors = false;
            this.dataGridViewLogs.Size = new System.Drawing.Size(552, 645);
            this.dataGridViewLogs.TabIndex = 10;
            this.dataGridViewLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogs_CellContentClick);
            // 
            // liftTimerDown
            // 
            this.liftTimerDown.Interval = 50;
            this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
            // 
            // openDoorTimer
            // 
            this.openDoorTimer.Tick += new System.EventHandler(this.openDoorTimer_Tick);
            // 
            // panel1 - ENHANCED LED DISPLAY
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFloorDisplay);
            this.panel1.Location = new System.Drawing.Point(646, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 101);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFloorDisplay - ENHANCED LED STYLE
            // 
            this.lblFloorDisplay.AutoSize = true;
            this.lblFloorDisplay.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lblFloorDisplay.Location = new System.Drawing.Point(15, 15);
            this.lblFloorDisplay.Name = "lblFloorDisplay";
            this.lblFloorDisplay.Size = new System.Drawing.Size(0, 63);
            this.lblFloorDisplay.TabIndex = 0;
            // 
            // label1 - ENHANCED FLOOR LABEL
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Floor 2";
            // 
            // label2 - ENHANCED FLOOR LABEL
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-6, 423);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Floor 1";
            // 
            // btnDelete - ENHANCED MODERN BUTTON
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(68)))), ((int)(((byte)(52)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1062, 663);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 52);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel - ENHANCED MODERN BUTTON
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(136)))), ((int)(((byte)(16)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1263, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 52);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCall1 - Ground Floor Call Button
            // 
            this.btnCall1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Call_Down.png");
            this.btnCall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall1.FlatAppearance.BorderSize = 0;
            this.btnCall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall1.Location = new System.Drawing.Point(419, 640);
            this.btnCall1.Name = "btnCall1";
            this.btnCall1.Size = new System.Drawing.Size(60, 60);
            this.btnCall1.TabIndex = 14;
            this.btnCall1.UseVisualStyleBackColor = true;
            this.btnCall1.Click += new System.EventHandler(this.btnCall1_Click);
            // 
            // btnCall2 - Floor 2 Call Button
            // 
            this.btnCall2.BackgroundImage = System.Drawing.Image.FromFile("Resources/Call_Up.png");
            this.btnCall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall2.FlatAppearance.BorderSize = 0;
            this.btnCall2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall2.Location = new System.Drawing.Point(419, 228);
            this.btnCall2.Name = "btnCall2";
            this.btnCall2.Size = new System.Drawing.Size(60, 60);
            this.btnCall2.TabIndex = 13;
            this.btnCall2.UseVisualStyleBackColor = true;
            this.btnCall2.Click += new System.EventHandler(this.btnCall2_Click);
            // 
            // doorRight_1 (FLOOR 2 - RIGHT DOOR)
            // 
            this.doorRight_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Door.jpg");
            this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_1.Location = new System.Drawing.Point(260, 99);
            this.doorRight_1.Name = "doorRight_1";
            this.doorRight_1.Size = new System.Drawing.Size(100, 236);
            this.doorRight_1.TabIndex = 9;
            this.doorRight_1.TabStop = false;
            // 
            // doorLeft_1 (FLOOR 2 - LEFT DOOR)
            // 
            this.doorLeft_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Door.jpg");
            this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_1.Location = new System.Drawing.Point(160, 99);
            this.doorLeft_1.Name = "doorLeft_1";
            this.doorLeft_1.Size = new System.Drawing.Size(100, 236);
            this.doorLeft_1.TabIndex = 8;
            this.doorLeft_1.TabStop = false;
            // 
            // doorLeft_G (GROUND FLOOR - LEFT DOOR)
            // 
            this.doorLeft_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Door.jpg");
            this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_G.Location = new System.Drawing.Point(160, 514);
            this.doorLeft_G.Name = "doorLeft_G";
            this.doorLeft_G.Size = new System.Drawing.Size(100, 236);
            this.doorLeft_G.TabIndex = 6;
            this.doorLeft_G.TabStop = false;
            // 
            // doorRight_G (GROUND FLOOR - RIGHT DOOR)
            // 
            this.doorRight_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Door.jpg");
            this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_G.Location = new System.Drawing.Point(260, 514);
            this.doorRight_G.Name = "doorRight_G";
            this.doorRight_G.Size = new System.Drawing.Size(100, 236);
            this.doorRight_G.TabIndex = 7;
            this.doorRight_G.TabStop = false;
            // 
            // mainElevator - Lift Cabin
            // 
            this.mainElevator.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Cabin.png");
            this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainElevator.Location = new System.Drawing.Point(179, 514);
            this.mainElevator.Name = "mainElevator";
            this.mainElevator.Size = new System.Drawing.Size(162, 236);
            this.mainElevator.TabIndex = 0;
            this.mainElevator.TabStop = false;
            // 
            // pictureBox2 - Ground Floor Background
            // 
            this.pictureBox2.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Floor.jpg");
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 368);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1 - Floor 2 Background
            // 
            this.pictureBox1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Lift_Floor.jpg");
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 368);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close - Close Door Button
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Close.BackgroundImage = System.Drawing.Image.FromFile("Resources/Close_Door_Button.png");
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(723, 525);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 77);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open - Open Door Button
            // 
            this.btn_Open.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Open.BackgroundImage = System.Drawing.Image.FromFile("Resources/Open_Door_Button.png");
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Location = new System.Drawing.Point(612, 525);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(80, 77);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_G - Ground Floor Button
            // 
            this.btn_G.BackgroundImage = System.Drawing.Image.FromFile("Resources/Floor_1_Button.jpg");
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_G.Location = new System.Drawing.Point(666, 397);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(81, 83);
            this.btn_G.TabIndex = 3;
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_click);
            // 
            // btn_1 - Floor 2 Button
            // 
            this.btn_1.BackgroundImage = System.Drawing.Image.FromFile("Resources/Floor_2_Button.jpg");
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.Location = new System.Drawing.Point(666, 280);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(81, 83);
            this.btn_1.TabIndex = 2;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_click);
            // 
            // liftPanel - Control Panel
            // 
            this.liftPanel.BackgroundImage = System.Drawing.Image.FromFile("Resources/Panel.png");
            this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftPanel.Location = new System.Drawing.Point(599, 121);
            this.liftPanel.Name = "liftPanel";
            this.liftPanel.Size = new System.Drawing.Size(218, 548);
            this.liftPanel.TabIndex = 1;
            this.liftPanel.TabStop = false;
            // 
            // autoDoorTimer
            // 
            this.autoDoorTimer.Interval = 50;
            this.autoDoorTimer.Tick += new System.EventHandler(this.autoDoorTimer_Tick);
            // 
            // Form1






                         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1532, 775);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCall1);
            this.Controls.Add(this.btnCall2);
            this.Controls.Add(this.doorRight_1);
            this.Controls.Add(this.doorLeft_1);
            this.Controls.Add(this.doorLeft_G);
            this.Controls.Add(this.doorRight_G);
            this.Controls.Add(this.mainElevator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.liftPanel);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.Text = "Elevator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainElevator;
        private System.Windows.Forms.PictureBox liftPanel;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Timer liftTimerUp;
        private System.Windows.Forms.PictureBox doorLeft_G;
        private System.Windows.Forms.PictureBox doorRight_G;
        private System.Windows.Forms.PictureBox doorRight_1;
        private System.Windows.Forms.PictureBox doorLeft_1;
        private System.Windows.Forms.Timer closeDoorTimer;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Timer liftTimerDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer openDoorTimer;
        private System.Windows.Forms.Button btnCall2;
        private System.Windows.Forms.Button btnCall1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFloorDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer autoDoorTimer;
    }
}