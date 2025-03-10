﻿
namespace ossaTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelButtonGroup = new System.Windows.Forms.Panel();
            this.btnConnectCheck = new System.Windows.Forms.Button();
            this.btnQFILPath = new System.Windows.Forms.Button();
            this.btnEdl = new System.Windows.Forms.Button();
            this.btnQFIL = new System.Windows.Forms.Button();
            this.txtQFILPath = new System.Windows.Forms.TextBox();
            this.txt1EdlStatus = new System.Windows.Forms.TextBox();
            this.pgBarEdl = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pgBarQFIL = new System.Windows.Forms.ProgressBar();
            this.pgBarConnection = new System.Windows.Forms.ProgressBar();
            this.txt1QFILStatus = new System.Windows.Forms.TextBox();
            this.txt1ConnectionStatus = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxSku = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyRepoPath = new System.Windows.Forms.TextBox();
            this.btnChangeKeyRepo = new System.Windows.Forms.Button();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.txtKeyboxPath = new System.Windows.Forms.TextBox();
            this.btnKeyBurn = new System.Windows.Forms.Button();
            this.btnRPMBInitialize = new System.Windows.Forms.Button();
            this.lblDHCP = new System.Windows.Forms.Label();
            this.txtLog2 = new System.Windows.Forms.TextBox();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.lblPluginHint = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAppInfo = new System.Windows.Forms.Label();
            this.btnChangeStorage = new System.Windows.Forms.Button();
            this.txtStoragePath = new System.Windows.Forms.TextBox();
            this.bgWorkerConnection = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerQFIL = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerEdl = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerAttestionKey = new System.ComponentModel.BackgroundWorker();
            this.storageDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.qfilFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.keyRepoDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toggleTXT = new ossaTool.Toggle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenStorageDir = new System.Windows.Forms.Button();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelButtonGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Controls.Add(this.tabPage3);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(784, 424);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.panelButtonGroup);
            this.tabPage1.Controls.Add(this.txtQFILPath);
            this.tabPage1.Controls.Add(this.txt1EdlStatus);
            this.tabPage1.Controls.Add(this.pgBarEdl);
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Controls.Add(this.pgBarQFIL);
            this.tabPage1.Controls.Add(this.pgBarConnection);
            this.tabPage1.Controls.Add(this.txt1QFILStatus);
            this.tabPage1.Controls.Add(this.txt1ConnectionStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1: 環境建立";
            // 
            // panelButtonGroup
            // 
            this.panelButtonGroup.Controls.Add(this.btnConnectCheck);
            this.panelButtonGroup.Controls.Add(this.btnQFILPath);
            this.panelButtonGroup.Controls.Add(this.btnEdl);
            this.panelButtonGroup.Controls.Add(this.btnQFIL);
            this.panelButtonGroup.Location = new System.Drawing.Point(20, 20);
            this.panelButtonGroup.Name = "panelButtonGroup";
            this.panelButtonGroup.Size = new System.Drawing.Size(117, 143);
            this.panelButtonGroup.TabIndex = 13;
            // 
            // btnConnectCheck
            // 
            this.btnConnectCheck.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConnectCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectCheck.Location = new System.Drawing.Point(0, 0);
            this.btnConnectCheck.Name = "btnConnectCheck";
            this.btnConnectCheck.Size = new System.Drawing.Size(107, 23);
            this.btnConnectCheck.TabIndex = 1;
            this.btnConnectCheck.Text = "攝影機連接確認";
            this.btnConnectCheck.UseVisualStyleBackColor = false;
            this.btnConnectCheck.Click += new System.EventHandler(this.btn1Connect_Click);
            // 
            // btnQFILPath
            // 
            this.btnQFILPath.BackColor = System.Drawing.Color.Tan;
            this.btnQFILPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQFILPath.Location = new System.Drawing.Point(0, 41);
            this.btnQFILPath.Name = "btnQFILPath";
            this.btnQFILPath.Size = new System.Drawing.Size(107, 23);
            this.btnQFILPath.TabIndex = 11;
            this.btnQFILPath.Text = "選擇燒機檔案";
            this.btnQFILPath.UseVisualStyleBackColor = false;
            this.btnQFILPath.Click += new System.EventHandler(this.btnQFILPath_Click);
            // 
            // btnEdl
            // 
            this.btnEdl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnEdl.Enabled = false;
            this.btnEdl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdl.Location = new System.Drawing.Point(0, 80);
            this.btnEdl.Name = "btnEdl";
            this.btnEdl.Size = new System.Drawing.Size(107, 23);
            this.btnEdl.TabIndex = 8;
            this.btnEdl.Text = "切換燒機模式";
            this.btnEdl.UseVisualStyleBackColor = false;
            this.btnEdl.Click += new System.EventHandler(this.btnEdl_Click);
            // 
            // btnQFIL
            // 
            this.btnQFIL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQFIL.Enabled = false;
            this.btnQFIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQFIL.Location = new System.Drawing.Point(0, 120);
            this.btnQFIL.Name = "btnQFIL";
            this.btnQFIL.Size = new System.Drawing.Size(107, 23);
            this.btnQFIL.TabIndex = 2;
            this.btnQFIL.Text = "執行燒機";
            this.btnQFIL.UseCompatibleTextRendering = true;
            this.btnQFIL.UseVisualStyleBackColor = false;
            this.btnQFIL.Click += new System.EventHandler(this.btnQFIL_Click);
            // 
            // txtQFILPath
            // 
            this.txtQFILPath.Location = new System.Drawing.Point(140, 61);
            this.txtQFILPath.Name = "txtQFILPath";
            this.txtQFILPath.ReadOnly = true;
            this.txtQFILPath.Size = new System.Drawing.Size(458, 23);
            this.txtQFILPath.TabIndex = 12;
            // 
            // txt1EdlStatus
            // 
            this.txt1EdlStatus.Location = new System.Drawing.Point(140, 100);
            this.txt1EdlStatus.Name = "txt1EdlStatus";
            this.txt1EdlStatus.ReadOnly = true;
            this.txt1EdlStatus.Size = new System.Drawing.Size(68, 23);
            this.txt1EdlStatus.TabIndex = 10;
            // 
            // pgBarEdl
            // 
            this.pgBarEdl.ForeColor = System.Drawing.Color.Tan;
            this.pgBarEdl.Location = new System.Drawing.Point(222, 100);
            this.pgBarEdl.Name = "pgBarEdl";
            this.pgBarEdl.Size = new System.Drawing.Size(376, 23);
            this.pgBarEdl.Step = 1;
            this.pgBarEdl.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgBarEdl.TabIndex = 9;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 180);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(735, 200);
            this.txtLog.TabIndex = 7;
            // 
            // pgBarQFIL
            // 
            this.pgBarQFIL.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.pgBarQFIL.Location = new System.Drawing.Point(222, 140);
            this.pgBarQFIL.Name = "pgBarQFIL";
            this.pgBarQFIL.Size = new System.Drawing.Size(376, 23);
            this.pgBarQFIL.Step = 1;
            this.pgBarQFIL.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgBarQFIL.TabIndex = 6;
            // 
            // pgBarConnection
            // 
            this.pgBarConnection.BackColor = System.Drawing.Color.RosyBrown;
            this.pgBarConnection.ForeColor = System.Drawing.Color.RosyBrown;
            this.pgBarConnection.Location = new System.Drawing.Point(222, 20);
            this.pgBarConnection.Name = "pgBarConnection";
            this.pgBarConnection.Size = new System.Drawing.Size(376, 23);
            this.pgBarConnection.Step = 1;
            this.pgBarConnection.TabIndex = 5;
            // 
            // txt1QFILStatus
            // 
            this.txt1QFILStatus.Location = new System.Drawing.Point(140, 140);
            this.txt1QFILStatus.Name = "txt1QFILStatus";
            this.txt1QFILStatus.ReadOnly = true;
            this.txt1QFILStatus.Size = new System.Drawing.Size(68, 23);
            this.txt1QFILStatus.TabIndex = 3;
            // 
            // txt1ConnectionStatus
            // 
            this.txt1ConnectionStatus.Location = new System.Drawing.Point(140, 20);
            this.txt1ConnectionStatus.Name = "txt1ConnectionStatus";
            this.txt1ConnectionStatus.ReadOnly = true;
            this.txt1ConnectionStatus.Size = new System.Drawing.Size(68, 23);
            this.txt1ConnectionStatus.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comBoxSku);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtKeyRepoPath);
            this.tabPage2.Controls.Add(this.btnChangeKeyRepo);
            this.tabPage2.Controls.Add(this.txtKeyName);
            this.tabPage2.Controls.Add(this.txtKeyboxPath);
            this.tabPage2.Controls.Add(this.btnKeyBurn);
            this.tabPage2.Controls.Add(this.btnRPMBInitialize);
            this.tabPage2.Controls.Add(this.lblDHCP);
            this.tabPage2.Controls.Add(this.txtLog2);
            this.tabPage2.Controls.Add(this.btnGetIP);
            this.tabPage2.Controls.Add(this.lblPluginHint);
            this.tabPage2.Controls.Add(this.txtCountDown);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2: 更新金鑰";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "選擇的 Sku ID：";
            // 
            // comBoxSku
            // 
            this.comBoxSku.FormattingEnabled = true;
            this.comBoxSku.Items.AddRange(new object[] {
            "BST_BULLET",
            "BST_VD2",
            "BST_MD2",
            "Generic"});
            this.comBoxSku.Location = new System.Drawing.Point(140, 49);
            this.comBoxSku.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxSku.Name = "comBoxSku";
            this.comBoxSku.Size = new System.Drawing.Size(91, 23);
            this.comBoxSku.TabIndex = 17;
            this.comBoxSku.SelectedIndexChanged += new System.EventHandler(this.comBoxSku_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "中";
            // 
            // txtKeyRepoPath
            // 
            this.txtKeyRepoPath.Location = new System.Drawing.Point(140, 303);
            this.txtKeyRepoPath.Name = "txtKeyRepoPath";
            this.txtKeyRepoPath.ReadOnly = true;
            this.txtKeyRepoPath.Size = new System.Drawing.Size(397, 23);
            this.txtKeyRepoPath.TabIndex = 15;
            // 
            // btnChangeKeyRepo
            // 
            this.btnChangeKeyRepo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnChangeKeyRepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeKeyRepo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeKeyRepo.Location = new System.Drawing.Point(20, 303);
            this.btnChangeKeyRepo.Name = "btnChangeKeyRepo";
            this.btnChangeKeyRepo.Size = new System.Drawing.Size(107, 23);
            this.btnChangeKeyRepo.TabIndex = 14;
            this.btnChangeKeyRepo.Text = "切換金鑰資料庫";
            this.btnChangeKeyRepo.UseVisualStyleBackColor = false;
            this.btnChangeKeyRepo.Click += new System.EventHandler(this.btnChangeKeyRepo_Click);
            // 
            // txtKeyName
            // 
            this.txtKeyName.Location = new System.Drawing.Point(263, 343);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.ReadOnly = true;
            this.txtKeyName.Size = new System.Drawing.Size(274, 23);
            this.txtKeyName.TabIndex = 13;
            // 
            // txtKeyboxPath
            // 
            this.txtKeyboxPath.Location = new System.Drawing.Point(140, 343);
            this.txtKeyboxPath.Name = "txtKeyboxPath";
            this.txtKeyboxPath.ReadOnly = true;
            this.txtKeyboxPath.Size = new System.Drawing.Size(91, 23);
            this.txtKeyboxPath.TabIndex = 12;
            // 
            // btnKeyBurn
            // 
            this.btnKeyBurn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKeyBurn.Enabled = false;
            this.btnKeyBurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeyBurn.Location = new System.Drawing.Point(20, 343);
            this.btnKeyBurn.Name = "btnKeyBurn";
            this.btnKeyBurn.Size = new System.Drawing.Size(107, 23);
            this.btnKeyBurn.TabIndex = 8;
            this.btnKeyBurn.Text = "燒錄金鑰";
            this.btnKeyBurn.UseVisualStyleBackColor = false;
            this.btnKeyBurn.Click += new System.EventHandler(this.btnKeyBurn_Click);
            // 
            // btnRPMBInitialize
            // 
            this.btnRPMBInitialize.BackColor = System.Drawing.Color.Tan;
            this.btnRPMBInitialize.Enabled = false;
            this.btnRPMBInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRPMBInitialize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRPMBInitialize.Location = new System.Drawing.Point(21, 260);
            this.btnRPMBInitialize.Name = "btnRPMBInitialize";
            this.btnRPMBInitialize.Size = new System.Drawing.Size(107, 23);
            this.btnRPMBInitialize.TabIndex = 7;
            this.btnRPMBInitialize.Text = "RPMB 初始化";
            this.btnRPMBInitialize.UseVisualStyleBackColor = false;
            this.btnRPMBInitialize.Click += new System.EventHandler(this.btnRPMBInitialize_Click);
            // 
            // lblDHCP
            // 
            this.lblDHCP.AutoSize = true;
            this.lblDHCP.Location = new System.Drawing.Point(20, 20);
            this.lblDHCP.Name = "lblDHCP";
            this.lblDHCP.Size = new System.Drawing.Size(146, 15);
            this.lblDHCP.TabIndex = 4;
            this.lblDHCP.Text = "請稍後, DHCP 分配 IP 中...";
            // 
            // txtLog2
            // 
            this.txtLog2.Location = new System.Drawing.Point(140, 84);
            this.txtLog2.Multiline = true;
            this.txtLog2.Name = "txtLog2";
            this.txtLog2.ReadOnly = true;
            this.txtLog2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog2.Size = new System.Drawing.Size(615, 200);
            this.txtLog2.TabIndex = 3;
            // 
            // btnGetIP
            // 
            this.btnGetIP.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGetIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetIP.Location = new System.Drawing.Point(20, 84);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(107, 23);
            this.btnGetIP.TabIndex = 2;
            this.btnGetIP.Text = "取得裝置資訊";
            this.btnGetIP.UseVisualStyleBackColor = false;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // lblPluginHint
            // 
            this.lblPluginHint.AutoSize = true;
            this.lblPluginHint.Location = new System.Drawing.Point(247, 20);
            this.lblPluginHint.Name = "lblPluginHint";
            this.lblPluginHint.Size = new System.Drawing.Size(318, 15);
            this.lblPluginHint.TabIndex = 1;
            this.lblPluginHint.Text = "計時器停止後, 請插回 USB 線並點選下方按鈕取得裝置資訊";
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(177, 17);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(54, 23);
            this.txtCountDown.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "關於";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ossaTool.Properties.Resources.logo;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.labelAppInfo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(30, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(72, 19);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "blablabla";
            // 
            // labelAppInfo
            // 
            this.labelAppInfo.AutoSize = true;
            this.labelAppInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppInfo.Location = new System.Drawing.Point(30, 279);
            this.labelAppInfo.Name = "labelAppInfo";
            this.labelAppInfo.Size = new System.Drawing.Size(72, 19);
            this.labelAppInfo.TabIndex = 0;
            this.labelAppInfo.Text = "blablabla";
            // 
            // btnChangeStorage
            // 
            this.btnChangeStorage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChangeStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeStorage.Location = new System.Drawing.Point(24, 5);
            this.btnChangeStorage.Name = "btnChangeStorage";
            this.btnChangeStorage.Size = new System.Drawing.Size(107, 23);
            this.btnChangeStorage.TabIndex = 10;
            this.btnChangeStorage.Text = "切換儲存資料夾";
            this.btnChangeStorage.UseVisualStyleBackColor = false;
            this.btnChangeStorage.Click += new System.EventHandler(this.btnChangeStorage_Click);
            // 
            // txtStoragePath
            // 
            this.txtStoragePath.Location = new System.Drawing.Point(140, 5);
            this.txtStoragePath.Name = "txtStoragePath";
            this.txtStoragePath.ReadOnly = true;
            this.txtStoragePath.Size = new System.Drawing.Size(401, 23);
            this.txtStoragePath.TabIndex = 9;
            // 
            // bgWorkerConnection
            // 
            this.bgWorkerConnection.WorkerReportsProgress = true;
            this.bgWorkerConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerConnection_DoWork);
            this.bgWorkerConnection.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerConnection_ProgressChanged);
            this.bgWorkerConnection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerConnection_RunWorkerCompleted);
            // 
            // bgWorkerQFIL
            // 
            this.bgWorkerQFIL.WorkerReportsProgress = true;
            this.bgWorkerQFIL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerQFIL_DoWork);
            this.bgWorkerQFIL.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerQFIL_ProgressChanged);
            this.bgWorkerQFIL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerQFIL_RunWorkerCompleted);
            // 
            // bgWorkerEdl
            // 
            this.bgWorkerEdl.WorkerReportsProgress = true;
            this.bgWorkerEdl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerEdl_DoWork);
            this.bgWorkerEdl.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerEdl_ProgressChanged);
            this.bgWorkerEdl.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerEdl_RunWorkerCompleted);
            // 
            // bgWorkerAttestionKey
            // 
            this.bgWorkerAttestionKey.WorkerReportsProgress = true;
            this.bgWorkerAttestionKey.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerAttestionKey_DoWork);
            this.bgWorkerAttestionKey.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerAttestionKey_ProgressChanged);
            this.bgWorkerAttestionKey.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerAttestionKey_RunWorkerCompleted);
            // 
            // qfilFileDialog
            // 
            this.qfilFileDialog.FileName = "檔案入徑";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer1.Panel2.Controls.Add(this.toggleTXT);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnOpenStorageDir);
            this.splitContainer1.Panel2.Controls.Add(this.btnChangeStorage);
            this.splitContainer1.Panel2.Controls.Add(this.txtStoragePath);
            this.splitContainer1.Panel2MinSize = 30;
            this.splitContainer1.Size = new System.Drawing.Size(784, 461);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 1;
            // 
            // toggleTXT
            // 
            this.toggleTXT.BorderColor = System.Drawing.Color.LightGray;
            this.toggleTXT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleTXT.IsOn = false;
            this.toggleTXT.Location = new System.Drawing.Point(709, 3);
            this.toggleTXT.Name = "toggleTXT";
            this.toggleTXT.OffColor = System.Drawing.SystemColors.Control;
            this.toggleTXT.OffText = "OFF";
            this.toggleTXT.OnColor = System.Drawing.SystemColors.Control;
            this.toggleTXT.OnText = "ON";
            this.toggleTXT.Size = new System.Drawing.Size(50, 27);
            this.toggleTXT.TabIndex = 15;
            this.toggleTXT.Text = "TXT";
            this.toggleTXT.TextEnabled = true;
            this.toggleTXT.Click += new System.EventHandler(this.toggleTXT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "另存裝置資訊於";
            // 
            // btnOpenStorageDir
            // 
            this.btnOpenStorageDir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpenStorageDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenStorageDir.Location = new System.Drawing.Point(544, 5);
            this.btnOpenStorageDir.Name = "btnOpenStorageDir";
            this.btnOpenStorageDir.Size = new System.Drawing.Size(69, 23);
            this.btnOpenStorageDir.TabIndex = 11;
            this.btnOpenStorageDir.Text = "開啟位置";
            this.btnOpenStorageDir.UseVisualStyleBackColor = false;
            this.btnOpenStorageDir.Click += new System.EventHandler(this.btnOpenStorageDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSSA tool";
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelButtonGroup.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt1ConnectionStatus;
        private System.Windows.Forms.Button btnConnectCheck;
        private System.Windows.Forms.Button btnQFIL;
        private System.Windows.Forms.TextBox txt1QFILStatus;
        private System.ComponentModel.BackgroundWorker bgWorkerConnection;
        private System.ComponentModel.BackgroundWorker bgWorkerQFIL;
        private System.Windows.Forms.ProgressBar pgBarQFIL;
        private System.Windows.Forms.ProgressBar pgBarConnection;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txt1EdlStatus;
        private System.Windows.Forms.ProgressBar pgBarEdl;
        private System.Windows.Forms.Button btnEdl;
        private System.ComponentModel.BackgroundWorker bgWorkerEdl;
        private System.ComponentModel.BackgroundWorker bgWorkerAttestionKey;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDHCP;
        private System.Windows.Forms.TextBox txtLog2;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Label lblPluginHint;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnRPMBInitialize;
        private System.Windows.Forms.Button btnKeyBurn;
        private System.Windows.Forms.Button btnChangeStorage;
        private System.Windows.Forms.TextBox txtStoragePath;
        private System.Windows.Forms.FolderBrowserDialog storageDirDialog;
        private System.Windows.Forms.Button btnQFILPath;
        private System.Windows.Forms.TextBox txtQFILPath;
        private System.Windows.Forms.OpenFileDialog qfilFileDialog;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.TextBox txtKeyboxPath;
        private System.Windows.Forms.Button btnChangeKeyRepo;
        private System.Windows.Forms.TextBox txtKeyRepoPath;
        private System.Windows.Forms.FolderBrowserDialog keyRepoDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenStorageDir;
        private System.Windows.Forms.Label label2;
        private Toggle toggleTXT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAppInfo;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxSku;
        private System.Windows.Forms.Panel panelButtonGroup;
    }
}

