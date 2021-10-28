
namespace MouseClickSimple
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label02 = new System.Windows.Forms.Label();
            this.Label03 = new System.Windows.Forms.Label();
            this.Label04 = new System.Windows.Forms.Label();
            this.Label05 = new System.Windows.Forms.Label();
            this.TextCoordinateX = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextCoordinateY = new System.Windows.Forms.TextBox();
            this.ComboClickType = new System.Windows.Forms.ComboBox();
            this.TextWaitingTime = new System.Windows.Forms.TextBox();
            this.TextRepeatAction = new System.Windows.Forms.TextBox();
            this.TextDescAction = new System.Windows.Forms.TextBox();
            this.ComboMousePosAdd = new System.Windows.Forms.ComboBox();
            this.ComboMousePos = new System.Windows.Forms.ComboBox();
            this.ComboStartStop = new System.Windows.Forms.ComboBox();
            this.ComboPlayPause = new System.Windows.Forms.ComboBox();
            this.ButtonActionAdd = new System.Windows.Forms.Button();
            this.ButtonSelectedUpdate = new System.Windows.Forms.Button();
            this.GroupAction = new System.Windows.Forms.GroupBox();
            this.ButtonCheckedDown = new System.Windows.Forms.Button();
            this.ButtonCheckedUp = new System.Windows.Forms.Button();
            this.ButtonCheckedDelete = new System.Windows.Forms.Button();
            this.ButtonCheckedUpdate = new System.Windows.Forms.Button();
            this.ButtonCheckedAdd = new System.Windows.Forms.Button();
            this.ButtonSelectedAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSelectedDown = new System.Windows.Forms.Button();
            this.ButtonSelectedUp = new System.Windows.Forms.Button();
            this.ButtonSelectedDelete = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupScript = new System.Windows.Forms.GroupBox();
            this.Label06 = new System.Windows.Forms.Label();
            this.TextRepeatScript = new System.Windows.Forms.TextBox();
            this.ListScript = new System.Windows.Forms.ListView();
            this.ColumnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnClickType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnWaiting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnRepeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label17 = new System.Windows.Forms.Label();
            this.GroupListTime = new System.Windows.Forms.GroupBox();
            this.LabelRepeatAction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelDurum = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelRepeatScript = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.LabelTimeScript = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.LabelTimeCurrent = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.LabelTimeTotal = new System.Windows.Forms.Label();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.CheckScript = new System.Windows.Forms.CheckBox();
            this.CheckAction = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupAction.SuspendLayout();
            this.GroupScript.SuspendLayout();
            this.GroupListTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(2, 46);
            this.Label13.Margin = new System.Windows.Forms.Padding(0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(125, 25);
            this.Label13.TabIndex = 3;
            this.Label13.Text = "Click Type";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(2, 75);
            this.Label14.Margin = new System.Windows.Forms.Padding(0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(125, 25);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "Waiting Time (ms)";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label15.Location = new System.Drawing.Point(460, 70);
            this.Label15.Margin = new System.Windows.Forms.Padding(0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(120, 30);
            this.Label15.TabIndex = 5;
            this.Label15.Text = "Repeat Count";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.Location = new System.Drawing.Point(2, 105);
            this.Label16.Margin = new System.Windows.Forms.Padding(0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(115, 25);
            this.Label16.TabIndex = 6;
            this.Label16.Text = "Description";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label02
            // 
            this.Label02.Location = new System.Drawing.Point(2, 22);
            this.Label02.Margin = new System.Windows.Forms.Padding(0);
            this.Label02.Name = "Label02";
            this.Label02.Size = new System.Drawing.Size(175, 20);
            this.Label02.TabIndex = 7;
            this.Label02.Text = "Get Mouse Position (Add)";
            this.Label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label03
            // 
            this.Label03.Location = new System.Drawing.Point(2, 51);
            this.Label03.Margin = new System.Windows.Forms.Padding(0);
            this.Label03.Name = "Label03";
            this.Label03.Size = new System.Drawing.Size(175, 20);
            this.Label03.TabIndex = 8;
            this.Label03.Text = "Get Mouse Position";
            this.Label03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label04
            // 
            this.Label04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label04.Location = new System.Drawing.Point(460, 22);
            this.Label04.Margin = new System.Windows.Forms.Padding(0);
            this.Label04.Name = "Label04";
            this.Label04.Size = new System.Drawing.Size(130, 20);
            this.Label04.TabIndex = 9;
            this.Label04.Text = "Start-Stop Key";
            this.Label04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label05
            // 
            this.Label05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label05.Location = new System.Drawing.Point(460, 51);
            this.Label05.Margin = new System.Windows.Forms.Padding(0);
            this.Label05.Name = "Label05";
            this.Label05.Size = new System.Drawing.Size(130, 20);
            this.Label05.TabIndex = 10;
            this.Label05.Text = "Play-Pause Key";
            this.Label05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextCoordinateX
            // 
            this.TextCoordinateX.Location = new System.Drawing.Point(150, 20);
            this.TextCoordinateX.Margin = new System.Windows.Forms.Padding(0);
            this.TextCoordinateX.Name = "TextCoordinateX";
            this.TextCoordinateX.Size = new System.Drawing.Size(50, 23);
            this.TextCoordinateX.TabIndex = 11;
            this.TextCoordinateX.Text = "0";
            this.TextCoordinateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextCoordinateX.TextChanged += new System.EventHandler(this.TextCoordinateX_TextChanged);
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(125, 19);
            this.Label11.Margin = new System.Windows.Forms.Padding(0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(25, 25);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "X";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(215, 18);
            this.Label12.Margin = new System.Windows.Forms.Padding(0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(25, 25);
            this.Label12.TabIndex = 14;
            this.Label12.Text = "Y";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextCoordinateY
            // 
            this.TextCoordinateY.Location = new System.Drawing.Point(240, 20);
            this.TextCoordinateY.Margin = new System.Windows.Forms.Padding(0);
            this.TextCoordinateY.Name = "TextCoordinateY";
            this.TextCoordinateY.Size = new System.Drawing.Size(50, 23);
            this.TextCoordinateY.TabIndex = 13;
            this.TextCoordinateY.Text = "0";
            this.TextCoordinateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextCoordinateY.TextChanged += new System.EventHandler(this.TextCoordinateY_TextChanged);
            // 
            // ComboClickType
            // 
            this.ComboClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboClickType.FormattingEnabled = true;
            this.ComboClickType.Items.AddRange(new object[] {
            "Left Click",
            "Left Click Down",
            "Left Click Up"});
            this.ComboClickType.Location = new System.Drawing.Point(128, 48);
            this.ComboClickType.Margin = new System.Windows.Forms.Padding(0);
            this.ComboClickType.Name = "ComboClickType";
            this.ComboClickType.Size = new System.Drawing.Size(162, 24);
            this.ComboClickType.TabIndex = 15;
            this.toolTip1.SetToolTip(this.ComboClickType, "Mouse Click Type ( Click Left Mouse nad relese, Click Left Mouse nad Hold or Rele" +
        "ase Holding Left Click)");
            this.ComboClickType.SelectedIndexChanged += new System.EventHandler(this.ComboClickType_SelectedIndexChanged);
            // 
            // TextWaitingTime
            // 
            this.TextWaitingTime.Location = new System.Drawing.Point(128, 77);
            this.TextWaitingTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextWaitingTime.Name = "TextWaitingTime";
            this.TextWaitingTime.Size = new System.Drawing.Size(162, 23);
            this.TextWaitingTime.TabIndex = 16;
            this.TextWaitingTime.Text = "5000";
            this.TextWaitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TextWaitingTime, "Waiting time before Action");
            this.TextWaitingTime.TextChanged += new System.EventHandler(this.TextWaitingTime_TextChanged);
            // 
            // TextRepeatAction
            // 
            this.TextRepeatAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextRepeatAction.Location = new System.Drawing.Point(607, 74);
            this.TextRepeatAction.Margin = new System.Windows.Forms.Padding(0);
            this.TextRepeatAction.Name = "TextRepeatAction";
            this.TextRepeatAction.Size = new System.Drawing.Size(103, 23);
            this.TextRepeatAction.TabIndex = 17;
            this.TextRepeatAction.Text = "1";
            this.TextRepeatAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TextRepeatAction, "How many time will work this Action ?");
            this.TextRepeatAction.TextChanged += new System.EventHandler(this.TextRepeatAction_TextChanged);
            // 
            // TextDescAction
            // 
            this.TextDescAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDescAction.Location = new System.Drawing.Point(127, 105);
            this.TextDescAction.Margin = new System.Windows.Forms.Padding(0);
            this.TextDescAction.Name = "TextDescAction";
            this.TextDescAction.Size = new System.Drawing.Size(583, 23);
            this.TextDescAction.TabIndex = 18;
            this.toolTip1.SetToolTip(this.TextDescAction, "Description about this Action");
            this.TextDescAction.TextChanged += new System.EventHandler(this.TextDescAction_TextChanged);
            // 
            // ComboMousePosAdd
            // 
            this.ComboMousePosAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMousePosAdd.FormattingEnabled = true;
            this.ComboMousePosAdd.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboMousePosAdd.Location = new System.Drawing.Point(187, 20);
            this.ComboMousePosAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ComboMousePosAdd.Name = "ComboMousePosAdd";
            this.ComboMousePosAdd.Size = new System.Drawing.Size(60, 24);
            this.ComboMousePosAdd.TabIndex = 19;
            this.toolTip1.SetToolTip(this.ComboMousePosAdd, "Get Mouse Position, add Action part and Add Script List");
            this.ComboMousePosAdd.SelectedIndexChanged += new System.EventHandler(this.ComboMousePosAdd_SelectedIndexChanged);
            // 
            // ComboMousePos
            // 
            this.ComboMousePos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMousePos.FormattingEnabled = true;
            this.ComboMousePos.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboMousePos.Location = new System.Drawing.Point(187, 50);
            this.ComboMousePos.Margin = new System.Windows.Forms.Padding(0);
            this.ComboMousePos.Name = "ComboMousePos";
            this.ComboMousePos.Size = new System.Drawing.Size(60, 24);
            this.ComboMousePos.TabIndex = 20;
            this.toolTip1.SetToolTip(this.ComboMousePos, "Get Mouse Position and Add Action Part");
            this.ComboMousePos.SelectedIndexChanged += new System.EventHandler(this.ComboMousePos_SelectedIndexChanged);
            // 
            // ComboStartStop
            // 
            this.ComboStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStartStop.FormattingEnabled = true;
            this.ComboStartStop.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboStartStop.Location = new System.Drawing.Point(600, 20);
            this.ComboStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.ComboStartStop.Name = "ComboStartStop";
            this.ComboStartStop.Size = new System.Drawing.Size(60, 24);
            this.ComboStartStop.TabIndex = 21;
            this.toolTip1.SetToolTip(this.ComboStartStop, "Start or Stop Script");
            this.ComboStartStop.SelectedIndexChanged += new System.EventHandler(this.ComboStartStop_SelectedIndexChanged);
            // 
            // ComboPlayPause
            // 
            this.ComboPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPlayPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayPause.FormattingEnabled = true;
            this.ComboPlayPause.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboPlayPause.Location = new System.Drawing.Point(600, 50);
            this.ComboPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.ComboPlayPause.Name = "ComboPlayPause";
            this.ComboPlayPause.Size = new System.Drawing.Size(60, 24);
            this.ComboPlayPause.TabIndex = 22;
            this.toolTip1.SetToolTip(this.ComboPlayPause, "Starting Script will Play-Pause ");
            this.ComboPlayPause.SelectedIndexChanged += new System.EventHandler(this.ComboPlayPause_SelectedIndexChanged);
            // 
            // ButtonActionAdd
            // 
            this.ButtonActionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonActionAdd.Location = new System.Drawing.Point(443, 20);
            this.ButtonActionAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonActionAdd.Name = "ButtonActionAdd";
            this.ButtonActionAdd.Size = new System.Drawing.Size(152, 35);
            this.ButtonActionAdd.TabIndex = 24;
            this.ButtonActionAdd.Text = "Add Action";
            this.toolTip1.SetToolTip(this.ButtonActionAdd, "Add all Action Information to List");
            this.ButtonActionAdd.UseVisualStyleBackColor = true;
            this.ButtonActionAdd.Click += new System.EventHandler(this.ButtonActionAdd_Click);
            // 
            // ButtonSelectedUpdate
            // 
            this.ButtonSelectedUpdate.Location = new System.Drawing.Point(220, 133);
            this.ButtonSelectedUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSelectedUpdate.Name = "ButtonSelectedUpdate";
            this.ButtonSelectedUpdate.Size = new System.Drawing.Size(100, 30);
            this.ButtonSelectedUpdate.TabIndex = 25;
            this.ButtonSelectedUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.ButtonSelectedUpdate, "Update selecting Action");
            this.ButtonSelectedUpdate.UseVisualStyleBackColor = true;
            this.ButtonSelectedUpdate.Click += new System.EventHandler(this.ButtonSelectedUpdate_Click);
            // 
            // GroupAction
            // 
            this.GroupAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupAction.Controls.Add(this.ButtonCheckedDown);
            this.GroupAction.Controls.Add(this.ButtonCheckedUp);
            this.GroupAction.Controls.Add(this.ButtonCheckedDelete);
            this.GroupAction.Controls.Add(this.ButtonCheckedUpdate);
            this.GroupAction.Controls.Add(this.ButtonCheckedAdd);
            this.GroupAction.Controls.Add(this.ButtonSelectedAdd);
            this.GroupAction.Controls.Add(this.label4);
            this.GroupAction.Controls.Add(this.label3);
            this.GroupAction.Controls.Add(this.ButtonSelectedDown);
            this.GroupAction.Controls.Add(this.ButtonSelectedUp);
            this.GroupAction.Controls.Add(this.ButtonSelectedDelete);
            this.GroupAction.Controls.Add(this.ComboClickType);
            this.GroupAction.Controls.Add(this.ButtonSelectedUpdate);
            this.GroupAction.Controls.Add(this.ButtonActionAdd);
            this.GroupAction.Controls.Add(this.Label10);
            this.GroupAction.Controls.Add(this.Label13);
            this.GroupAction.Controls.Add(this.Label14);
            this.GroupAction.Controls.Add(this.Label15);
            this.GroupAction.Controls.Add(this.Label16);
            this.GroupAction.Controls.Add(this.TextDescAction);
            this.GroupAction.Controls.Add(this.TextCoordinateX);
            this.GroupAction.Controls.Add(this.TextRepeatAction);
            this.GroupAction.Controls.Add(this.Label11);
            this.GroupAction.Controls.Add(this.TextWaitingTime);
            this.GroupAction.Controls.Add(this.TextCoordinateY);
            this.GroupAction.Controls.Add(this.Label12);
            this.GroupAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GroupAction.Location = new System.Drawing.Point(10, 105);
            this.GroupAction.Margin = new System.Windows.Forms.Padding(0);
            this.GroupAction.Name = "GroupAction";
            this.GroupAction.Size = new System.Drawing.Size(715, 200);
            this.GroupAction.TabIndex = 26;
            this.GroupAction.TabStop = false;
            this.GroupAction.Text = "Action";
            // 
            // ButtonCheckedDown
            // 
            this.ButtonCheckedDown.Location = new System.Drawing.Point(460, 165);
            this.ButtonCheckedDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckedDown.Name = "ButtonCheckedDown";
            this.ButtonCheckedDown.Size = new System.Drawing.Size(125, 30);
            this.ButtonCheckedDown.TabIndex = 41;
            this.ButtonCheckedDown.Text = "Move Down";
            this.toolTip1.SetToolTip(this.ButtonCheckedDown, "Move Down all Cheched Action");
            this.ButtonCheckedDown.UseVisualStyleBackColor = true;
            this.ButtonCheckedDown.Click += new System.EventHandler(this.ButtonCheckedDown_Click);
            // 
            // ButtonCheckedUp
            // 
            this.ButtonCheckedUp.Location = new System.Drawing.Point(340, 165);
            this.ButtonCheckedUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckedUp.Name = "ButtonCheckedUp";
            this.ButtonCheckedUp.Size = new System.Drawing.Size(100, 30);
            this.ButtonCheckedUp.TabIndex = 40;
            this.ButtonCheckedUp.Text = "Move Up";
            this.toolTip1.SetToolTip(this.ButtonCheckedUp, "Move Up all Cheched Action");
            this.ButtonCheckedUp.UseVisualStyleBackColor = true;
            this.ButtonCheckedUp.Click += new System.EventHandler(this.ButtonCheckedUp_Click);
            // 
            // ButtonCheckedDelete
            // 
            this.ButtonCheckedDelete.Location = new System.Drawing.Point(605, 165);
            this.ButtonCheckedDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckedDelete.Name = "ButtonCheckedDelete";
            this.ButtonCheckedDelete.Size = new System.Drawing.Size(85, 30);
            this.ButtonCheckedDelete.TabIndex = 39;
            this.ButtonCheckedDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonCheckedDelete, "Delete all Cheched Action");
            this.ButtonCheckedDelete.UseVisualStyleBackColor = true;
            this.ButtonCheckedDelete.Click += new System.EventHandler(this.ButtonCheckedDelete_Click);
            // 
            // ButtonCheckedUpdate
            // 
            this.ButtonCheckedUpdate.Location = new System.Drawing.Point(220, 165);
            this.ButtonCheckedUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckedUpdate.Name = "ButtonCheckedUpdate";
            this.ButtonCheckedUpdate.Size = new System.Drawing.Size(100, 30);
            this.ButtonCheckedUpdate.TabIndex = 38;
            this.ButtonCheckedUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.ButtonCheckedUpdate, "Update all Cheched Action");
            this.ButtonCheckedUpdate.UseVisualStyleBackColor = true;
            this.ButtonCheckedUpdate.Click += new System.EventHandler(this.ButtonCheckedUpdate_Click);
            // 
            // ButtonCheckedAdd
            // 
            this.ButtonCheckedAdd.Location = new System.Drawing.Point(127, 165);
            this.ButtonCheckedAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckedAdd.Name = "ButtonCheckedAdd";
            this.ButtonCheckedAdd.Size = new System.Drawing.Size(80, 30);
            this.ButtonCheckedAdd.TabIndex = 37;
            this.ButtonCheckedAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.ButtonCheckedAdd, "Add again all Cheched Action");
            this.ButtonCheckedAdd.UseVisualStyleBackColor = true;
            this.ButtonCheckedAdd.Click += new System.EventHandler(this.ButtonCheckedAdd_Click);
            // 
            // ButtonSelectedAdd
            // 
            this.ButtonSelectedAdd.Location = new System.Drawing.Point(127, 133);
            this.ButtonSelectedAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSelectedAdd.Name = "ButtonSelectedAdd";
            this.ButtonSelectedAdd.Size = new System.Drawing.Size(80, 30);
            this.ButtonSelectedAdd.TabIndex = 36;
            this.ButtonSelectedAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.ButtonSelectedAdd, "Add again selecting Action");
            this.ButtonSelectedAdd.UseVisualStyleBackColor = true;
            this.ButtonSelectedAdd.Click += new System.EventHandler(this.ButtonSelectedAdd_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Checked";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Selected";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSelectedDown
            // 
            this.ButtonSelectedDown.Location = new System.Drawing.Point(460, 133);
            this.ButtonSelectedDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSelectedDown.Name = "ButtonSelectedDown";
            this.ButtonSelectedDown.Size = new System.Drawing.Size(125, 30);
            this.ButtonSelectedDown.TabIndex = 33;
            this.ButtonSelectedDown.Text = "Move Down";
            this.toolTip1.SetToolTip(this.ButtonSelectedDown, "Move Down selecting Action");
            this.ButtonSelectedDown.UseVisualStyleBackColor = true;
            this.ButtonSelectedDown.Click += new System.EventHandler(this.ButtonSelectedDown_Click);
            // 
            // ButtonSelectedUp
            // 
            this.ButtonSelectedUp.Location = new System.Drawing.Point(340, 133);
            this.ButtonSelectedUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSelectedUp.Name = "ButtonSelectedUp";
            this.ButtonSelectedUp.Size = new System.Drawing.Size(100, 30);
            this.ButtonSelectedUp.TabIndex = 32;
            this.ButtonSelectedUp.Text = "Move Up";
            this.toolTip1.SetToolTip(this.ButtonSelectedUp, "Move Up selecting Action");
            this.ButtonSelectedUp.UseVisualStyleBackColor = true;
            this.ButtonSelectedUp.Click += new System.EventHandler(this.ButtonSelectedUp_Click);
            // 
            // ButtonSelectedDelete
            // 
            this.ButtonSelectedDelete.Location = new System.Drawing.Point(605, 133);
            this.ButtonSelectedDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSelectedDelete.Name = "ButtonSelectedDelete";
            this.ButtonSelectedDelete.Size = new System.Drawing.Size(85, 30);
            this.ButtonSelectedDelete.TabIndex = 26;
            this.ButtonSelectedDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonSelectedDelete, "Delete selecting Action");
            this.ButtonSelectedDelete.UseVisualStyleBackColor = true;
            this.ButtonSelectedDelete.Click += new System.EventHandler(this.ButtonSelectedDelete_Click);
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(2, 19);
            this.Label10.Margin = new System.Windows.Forms.Padding(0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(125, 25);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Coordinate";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupScript
            // 
            this.GroupScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupScript.Controls.Add(this.Label06);
            this.GroupScript.Controls.Add(this.TextRepeatScript);
            this.GroupScript.Controls.Add(this.Label02);
            this.GroupScript.Controls.Add(this.Label03);
            this.GroupScript.Controls.Add(this.Label04);
            this.GroupScript.Controls.Add(this.Label05);
            this.GroupScript.Controls.Add(this.ComboMousePosAdd);
            this.GroupScript.Controls.Add(this.ComboPlayPause);
            this.GroupScript.Controls.Add(this.ComboMousePos);
            this.GroupScript.Controls.Add(this.ComboStartStop);
            this.GroupScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GroupScript.Location = new System.Drawing.Point(10, 25);
            this.GroupScript.Name = "GroupScript";
            this.GroupScript.Size = new System.Drawing.Size(715, 80);
            this.GroupScript.TabIndex = 27;
            this.GroupScript.TabStop = false;
            this.GroupScript.Text = "Script";
            // 
            // Label06
            // 
            this.Label06.Location = new System.Drawing.Point(299, 22);
            this.Label06.Margin = new System.Windows.Forms.Padding(0);
            this.Label06.Name = "Label06";
            this.Label06.Size = new System.Drawing.Size(141, 20);
            this.Label06.TabIndex = 26;
            this.Label06.Text = "Script Repeat Count";
            this.Label06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextRepeatScript
            // 
            this.TextRepeatScript.Location = new System.Drawing.Point(338, 48);
            this.TextRepeatScript.Margin = new System.Windows.Forms.Padding(0);
            this.TextRepeatScript.Name = "TextRepeatScript";
            this.TextRepeatScript.Size = new System.Drawing.Size(60, 23);
            this.TextRepeatScript.TabIndex = 27;
            this.TextRepeatScript.Text = "1";
            this.TextRepeatScript.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TextRepeatScript, "How many time will work this script?");
            this.TextRepeatScript.TextChanged += new System.EventHandler(this.TextRepeatScript_TextChanged);
            // 
            // ListScript
            // 
            this.ListScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListScript.CheckBoxes = true;
            this.ListScript.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNo,
            this.ColumnClickType,
            this.ColumnX,
            this.ColumnY,
            this.ColumnWaiting,
            this.ColumnRepeat,
            this.ColumnDescription});
            this.ListScript.FullRowSelect = true;
            this.ListScript.GridLines = true;
            this.ListScript.HideSelection = false;
            this.ListScript.Location = new System.Drawing.Point(10, 108);
            this.ListScript.MultiSelect = false;
            this.ListScript.Name = "ListScript";
            this.ListScript.Size = new System.Drawing.Size(700, 196);
            this.ListScript.TabIndex = 28;
            this.ListScript.UseCompatibleStateImageBehavior = false;
            this.ListScript.View = System.Windows.Forms.View.Details;
            this.ListScript.SelectedIndexChanged += new System.EventHandler(this.ListScript_SelectedIndexChanged);
            // 
            // ColumnNo
            // 
            this.ColumnNo.Text = "No";
            // 
            // ColumnClickType
            // 
            this.ColumnClickType.Text = "Click Type";
            this.ColumnClickType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnClickType.Width = 100;
            // 
            // ColumnX
            // 
            this.ColumnX.Text = "X";
            this.ColumnX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnX.Width = 50;
            // 
            // ColumnY
            // 
            this.ColumnY.Text = "Y";
            this.ColumnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnY.Width = 50;
            // 
            // ColumnWaiting
            // 
            this.ColumnWaiting.Text = "Waiting (ms)";
            this.ColumnWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnWaiting.Width = 120;
            // 
            // ColumnRepeat
            // 
            this.ColumnRepeat.Text = "Repeat";
            this.ColumnRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnRepeat.Width = 75;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Text = "Description";
            this.ColumnDescription.Width = 225;
            // 
            // Label17
            // 
            this.Label17.Location = new System.Drawing.Point(5, 25);
            this.Label17.Margin = new System.Windows.Forms.Padding(0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(145, 25);
            this.Label17.TabIndex = 30;
            this.Label17.Text = "Total Time";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupListTime
            // 
            this.GroupListTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupListTime.Controls.Add(this.LabelRepeatAction);
            this.GroupListTime.Controls.Add(this.label1);
            this.GroupListTime.Controls.Add(this.LabelDurum);
            this.GroupListTime.Controls.Add(this.ButtonStart);
            this.GroupListTime.Controls.Add(this.LabelRepeatScript);
            this.GroupListTime.Controls.Add(this.Label20);
            this.GroupListTime.Controls.Add(this.LabelTimeScript);
            this.GroupListTime.Controls.Add(this.Label19);
            this.GroupListTime.Controls.Add(this.LabelTimeCurrent);
            this.GroupListTime.Controls.Add(this.Label18);
            this.GroupListTime.Controls.Add(this.LabelTimeTotal);
            this.GroupListTime.Controls.Add(this.Label17);
            this.GroupListTime.Controls.Add(this.ListScript);
            this.GroupListTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GroupListTime.Location = new System.Drawing.Point(10, 305);
            this.GroupListTime.Name = "GroupListTime";
            this.GroupListTime.Size = new System.Drawing.Size(715, 310);
            this.GroupListTime.TabIndex = 34;
            this.GroupListTime.TabStop = false;
            this.GroupListTime.Text = "Script List - Time";
            // 
            // LabelRepeatAction
            // 
            this.LabelRepeatAction.Location = new System.Drawing.Point(475, 75);
            this.LabelRepeatAction.Margin = new System.Windows.Forms.Padding(0);
            this.LabelRepeatAction.Name = "LabelRepeatAction";
            this.LabelRepeatAction.Size = new System.Drawing.Size(125, 30);
            this.LabelRepeatAction.TabIndex = 42;
            this.LabelRepeatAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Current Script Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDurum
            // 
            this.LabelDurum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDurum.ForeColor = System.Drawing.Color.Red;
            this.LabelDurum.Location = new System.Drawing.Point(610, 75);
            this.LabelDurum.Name = "LabelDurum";
            this.LabelDurum.Size = new System.Drawing.Size(75, 24);
            this.LabelDurum.TabIndex = 40;
            this.LabelDurum.Text = "Start";
            this.LabelDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(610, 35);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 30);
            this.ButtonStart.TabIndex = 39;
            this.ButtonStart.Text = "Start";
            this.toolTip1.SetToolTip(this.ButtonStart, "Start-Stop Button");
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelRepeatScript
            // 
            this.LabelRepeatScript.Location = new System.Drawing.Point(475, 25);
            this.LabelRepeatScript.Margin = new System.Windows.Forms.Padding(0);
            this.LabelRepeatScript.Name = "LabelRepeatScript";
            this.LabelRepeatScript.Size = new System.Drawing.Size(125, 30);
            this.LabelRepeatScript.TabIndex = 38;
            this.LabelRepeatScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.Location = new System.Drawing.Point(335, 75);
            this.Label20.Margin = new System.Windows.Forms.Padding(0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(130, 30);
            this.Label20.TabIndex = 37;
            this.Label20.Text = "Action Repeat";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeScript
            // 
            this.LabelTimeScript.Location = new System.Drawing.Point(200, 50);
            this.LabelTimeScript.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTimeScript.Name = "LabelTimeScript";
            this.LabelTimeScript.Size = new System.Drawing.Size(125, 30);
            this.LabelTimeScript.TabIndex = 36;
            this.LabelTimeScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.Location = new System.Drawing.Point(335, 25);
            this.Label19.Margin = new System.Windows.Forms.Padding(0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(130, 30);
            this.Label19.TabIndex = 35;
            this.Label19.Text = "Script Repeat";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeCurrent
            // 
            this.LabelTimeCurrent.Location = new System.Drawing.Point(200, 75);
            this.LabelTimeCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTimeCurrent.Name = "LabelTimeCurrent";
            this.LabelTimeCurrent.Size = new System.Drawing.Size(125, 30);
            this.LabelTimeCurrent.TabIndex = 34;
            this.LabelTimeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label18
            // 
            this.Label18.Location = new System.Drawing.Point(5, 50);
            this.Label18.Margin = new System.Windows.Forms.Padding(0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(145, 25);
            this.Label18.TabIndex = 33;
            this.Label18.Text = "Script Time";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeTotal
            // 
            this.LabelTimeTotal.Location = new System.Drawing.Point(200, 25);
            this.LabelTimeTotal.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTimeTotal.Name = "LabelTimeTotal";
            this.LabelTimeTotal.Size = new System.Drawing.Size(125, 30);
            this.LabelTimeTotal.TabIndex = 32;
            this.LabelTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerClick
            // 
            this.TimerClick.Interval = 5000;
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // CheckScript
            // 
            this.CheckScript.AutoSize = true;
            this.CheckScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckScript.Location = new System.Drawing.Point(10, 5);
            this.CheckScript.Margin = new System.Windows.Forms.Padding(0);
            this.CheckScript.Name = "CheckScript";
            this.CheckScript.Size = new System.Drawing.Size(132, 21);
            this.CheckScript.TabIndex = 42;
            this.CheckScript.Text = "Close Script Part";
            this.toolTip1.SetToolTip(this.CheckScript, "Script Part will Open - Close");
            this.CheckScript.UseVisualStyleBackColor = true;
            this.CheckScript.CheckedChanged += new System.EventHandler(this.CheckScript_CheckedChanged);
            // 
            // CheckAction
            // 
            this.CheckAction.AutoSize = true;
            this.CheckAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckAction.Location = new System.Drawing.Point(150, 5);
            this.CheckAction.Name = "CheckAction";
            this.CheckAction.Size = new System.Drawing.Size(135, 21);
            this.CheckAction.TabIndex = 43;
            this.CheckAction.Text = "Close Action Part";
            this.toolTip1.SetToolTip(this.CheckAction, "Action Part will Open - Close");
            this.CheckAction.UseVisualStyleBackColor = true;
            this.CheckAction.CheckedChanged += new System.EventHandler(this.CheckAction_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.CheckAction);
            this.Controls.Add(this.CheckScript);
            this.Controls.Add(this.GroupListTime);
            this.Controls.Add(this.GroupScript);
            this.Controls.Add(this.GroupAction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(750, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Click Simple";
            this.GroupAction.ResumeLayout(false);
            this.GroupAction.PerformLayout();
            this.GroupScript.ResumeLayout(false);
            this.GroupScript.PerformLayout();
            this.GroupListTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label02;
        private System.Windows.Forms.Label Label03;
        private System.Windows.Forms.Label Label04;
        private System.Windows.Forms.Label Label05;
        private System.Windows.Forms.TextBox TextCoordinateX;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.TextBox TextCoordinateY;
        private System.Windows.Forms.ComboBox ComboClickType;
        private System.Windows.Forms.TextBox TextWaitingTime;
        private System.Windows.Forms.TextBox TextRepeatAction;
        private System.Windows.Forms.TextBox TextDescAction;
        private System.Windows.Forms.ComboBox ComboMousePosAdd;
        private System.Windows.Forms.ComboBox ComboMousePos;
        private System.Windows.Forms.ComboBox ComboStartStop;
        private System.Windows.Forms.ComboBox ComboPlayPause;
        private System.Windows.Forms.Button ButtonActionAdd;
        private System.Windows.Forms.Button ButtonSelectedUpdate;
        private System.Windows.Forms.GroupBox GroupAction;
        private System.Windows.Forms.GroupBox GroupScript;
        private System.Windows.Forms.Label Label06;
        private System.Windows.Forms.TextBox TextRepeatScript;
        private System.Windows.Forms.Button ButtonSelectedDelete;
        private System.Windows.Forms.ListView ListScript;
        private System.Windows.Forms.Button ButtonSelectedDown;
        private System.Windows.Forms.Button ButtonSelectedUp;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.GroupBox GroupListTime;
        private System.Windows.Forms.Label LabelTimeCurrent;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label LabelTimeTotal;
        private System.Windows.Forms.Label LabelRepeatScript;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label LabelTimeScript;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label LabelDurum;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Timer TimerClick;
        private System.Windows.Forms.Label LabelRepeatAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCheckedDown;
        private System.Windows.Forms.Button ButtonCheckedUp;
        private System.Windows.Forms.Button ButtonCheckedDelete;
        private System.Windows.Forms.Button ButtonCheckedUpdate;
        private System.Windows.Forms.Button ButtonCheckedAdd;
        private System.Windows.Forms.Button ButtonSelectedAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader ColumnNo;
        private System.Windows.Forms.ColumnHeader ColumnClickType;
        private System.Windows.Forms.ColumnHeader ColumnX;
        private System.Windows.Forms.ColumnHeader ColumnY;
        private System.Windows.Forms.ColumnHeader ColumnWaiting;
        private System.Windows.Forms.ColumnHeader ColumnRepeat;
        private System.Windows.Forms.ColumnHeader ColumnDescription;
        private System.Windows.Forms.CheckBox CheckScript;
        private System.Windows.Forms.CheckBox CheckAction;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

