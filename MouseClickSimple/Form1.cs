using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            groupScriptSizeY = GroupScript.Size.Height;
            groupActionSizeY = GroupAction.Size.Height;

            clickButton.hookedKeys.Add(Keys.C);
            clickButton.hookedKeys.Add(Keys.F1);
            clickButton.hookedKeys.Add(Keys.F2);
            clickButton.hookedKeys.Add(Keys.F3);
            clickButton.hookedKeys.Add(Keys.F4);
            clickButton.KeyDown += new KeyEventHandler(KullanilanTuslar);

            ComboMousePosAdd.Text = "F1";
            ComboMousePos.Text = "F2";
            ComboStartStop.Text = "F3";
            ComboPlayPause.Text = "F4";

            ComboClickType.Text = "Left Click";
            actionWaitingTime = 5000;
        }
        private int groupScriptSizeY = 0;
        private int groupActionSizeY = 0;
        private ClickButton clickButton = new ClickButton();
        private Point clickPoint = new Point();

        private void CheckScript_CheckedChanged(object sender, EventArgs e)
        {
            if (!started)
            {
                if (CheckScript.Checked)
                {
                    GroupScript.Size = new Size(this.Size.Width - 35, 20);
                }
                else
                {
                    GroupScript.Size = new Size(this.Size.Width - 35, groupScriptSizeY);
                }
                GroupAction.Location = new Point(10, GroupScript.Location.Y + GroupScript.Size.Height);
                GroupListTime.Location = new Point(10, GroupAction.Location.Y + GroupAction.Size.Height);
                GroupListTime.Size = new Size(this.Size.Width - 35, this.Size.Height -
                    (GroupScript.Location.Y + GroupScript.Size.Height + GroupAction.Size.Height + 40));
            }
            else
            {
                CheckScript.Checked = true;
            }
        }
        private void CheckAction_CheckedChanged(object sender, EventArgs e)
        {
            if (!started)
            {
                if (CheckAction.Checked)
                {
                    GroupAction.Size = new Size(this.Size.Width - 35, 20);
                }
                else
                {
                    GroupAction.Size = new Size(this.Size.Width - 35, groupActionSizeY);
                }
                GroupListTime.Location = new Point(10, GroupAction.Location.Y + GroupAction.Size.Height);
                GroupListTime.Size = new Size(this.Size.Width - 35, this.Size.Height -
                    (GroupScript.Location.Y + GroupScript.Size.Height + GroupAction.Size.Height + 40));
            }
            else
            {
                CheckAction.Checked = true;
            }
        }

        #region Dinlenecek Tuslar
        private void KullanilanTuslar(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == (Keys)(clickGetMouseAddKey + 112) && !started)
            {
                actionKoordinat_X = Cursor.Position.X;
                actionKoordinat_Y = Cursor.Position.Y;

                TextCoordinateX.Text = actionKoordinat_X.ToString();
                TextCoordinateY.Text = actionKoordinat_Y.ToString();

                AddAction();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickGetMouseKey + 112) && !started)
            {
                actionKoordinat_X = Cursor.Position.X;
                actionKoordinat_Y = Cursor.Position.Y;

                TextCoordinateX.Text = actionKoordinat_X.ToString();
                TextCoordinateY.Text = actionKoordinat_Y.ToString();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickStartStopKey + 112))
            {
                ClickStartStop();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickPlayPauseKey + 112) && started)
            {
                ClickPlayPause();
            }
        }
        #endregion

        #region Script
        private int clickGetMouseAddKey = 0;
        private int clickGetMouseKey = 1;
        private int clickStartStopKey = 2;
        private int clickPlayPauseKey = 3;
        private int scriptRepeatCount = 1;
        private void ComboMousePosAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMousePosAdd.SelectedIndex == clickGetMouseKey)
            {
                ComboMousePosAdd.Text = ((Keys)(clickGetMouseAddKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Get Mouse Key.");
            }
            else
            {
                if (ComboMousePosAdd.SelectedIndex == clickStartStopKey)
                {
                    ComboMousePosAdd.Text = ((Keys)(clickGetMouseAddKey + 112)).ToString();
                    MessageBox.Show("You can't choose same F with Start Stop Key.");
                }
                else
                {
                    if (ComboMousePosAdd.SelectedIndex == clickPlayPauseKey)
                    {
                        ComboMousePosAdd.Text = ((Keys)(clickGetMouseAddKey + 112)).ToString();
                        MessageBox.Show("You can't choose same F with Play Pause Key.");
                    }
                    else
                    {
                        clickButton.hookedKeys.Remove((Keys)(clickGetMouseAddKey + 112));
                        clickGetMouseAddKey = ComboMousePosAdd.SelectedIndex;
                        clickButton.hookedKeys.Add((Keys)(clickGetMouseAddKey + 112));
                    }
                }
            }
        }
        private void ComboMousePos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMousePos.SelectedIndex == clickGetMouseAddKey)
            {
                ComboMousePos.Text = ((Keys)(clickGetMouseKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Get Mouse Add Key.");
            }
            else
            {
                if (ComboMousePos.SelectedIndex == clickStartStopKey)
                {
                    ComboMousePos.Text = ((Keys)(clickGetMouseKey + 112)).ToString();
                    MessageBox.Show("You can't choose same F with Start Stop Key.");
                }
                else
                {
                    if (ComboMousePos.SelectedIndex == clickPlayPauseKey)
                    {
                        ComboMousePos.Text = ((Keys)(clickGetMouseKey + 112)).ToString();
                        MessageBox.Show("You can't choose same F with Play Pause Key.");
                    }
                    else
                    {
                        clickButton.hookedKeys.Remove((Keys)(clickGetMouseKey + 112));
                        clickGetMouseKey = ComboMousePos.SelectedIndex;
                        clickButton.hookedKeys.Add((Keys)(clickGetMouseKey + 112));
                    }
                }
            }
        }
        private void ComboStartStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStartStop.SelectedIndex == clickGetMouseAddKey)
            {
                ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Get Mouse Add Key.");
            }
            else
            {
                if (ComboStartStop.SelectedIndex == clickGetMouseKey)
                {
                    ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
                    MessageBox.Show("You can't choose same F with Get Mouse Key.");
                }
                else
                {
                    if (ComboStartStop.SelectedIndex == clickPlayPauseKey)
                    {
                        ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
                        MessageBox.Show("You can't choose same F with Play Pause Key.");
                    }
                    else
                    {
                        clickButton.hookedKeys.Remove((Keys)(clickStartStopKey + 112));
                        clickStartStopKey = ComboStartStop.SelectedIndex;
                        clickButton.hookedKeys.Add((Keys)(clickStartStopKey + 112));
                    }
                }
            }
        }
        private void ComboPlayPause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlayPause.SelectedIndex == clickGetMouseAddKey)
            {
                ComboPlayPause.Text = ((Keys)(clickPlayPauseKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Get Mouse Add Key.");
            }
            else
            {
                if (ComboPlayPause.SelectedIndex == clickGetMouseKey)
                {
                    ComboPlayPause.Text = ((Keys)(clickPlayPauseKey + 112)).ToString();
                    MessageBox.Show("You can't choose same F with Get Mouse Key.");
                }
                else
                {
                    if (ComboPlayPause.SelectedIndex == clickStartStopKey)
                    {
                        ComboPlayPause.Text = ((Keys)(clickPlayPauseKey + 112)).ToString();
                        MessageBox.Show("You can't choose same F with Start Stop Key.");
                    }
                    else
                    {
                        clickButton.hookedKeys.Remove((Keys)(clickPlayPauseKey + 112));
                        clickPlayPauseKey = ComboPlayPause.SelectedIndex;
                        clickButton.hookedKeys.Add((Keys)(clickPlayPauseKey + 112));
                    }
                }
            }
        }
        private void TextRepeatScript_TextChanged(object sender, EventArgs e)
        {
            if (TextRepeatScript.Text != "")
            {
                if (int.TryParse(TextRepeatScript.Text, out int deger))
                {
                    scriptRepeatCount = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        #endregion

        #region Action
        private int actionKoordinat_X = 0;
        private int actionKoordinat_Y = 0;
        private int actionClickType = 0; // 0 = Left Click , 1 = Left Down , 2 = Left Up
        private int actionWaitingTime = 0;
        private int actionRepeatCount = 1;
        private string actionDesc = "";
        private int selectedItem;
        private void TextCoordinateX_TextChanged(object sender, EventArgs e)
        {
            if (TextCoordinateX.Text != "")
            {
                if (int.TryParse(TextCoordinateX.Text, out int deger))
                {
                    actionKoordinat_X = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextCoordinateY_TextChanged(object sender, EventArgs e)
        {
            if (TextCoordinateY.Text != "")
            {
                if (int.TryParse(TextCoordinateY.Text, out int deger))
                {
                    actionKoordinat_Y = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void ComboClickType_SelectedIndexChanged(object sender, EventArgs e)
        {
            actionClickType = ComboClickType.SelectedIndex;
        }
        private void TextWaitingTime_TextChanged(object sender, EventArgs e)
        {
            if (TextWaitingTime.Text != "")
            {
                if (int.TryParse(TextWaitingTime.Text, out int deger))
                {
                    actionWaitingTime = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextRepeatAction_TextChanged(object sender, EventArgs e)
        {
            if (TextRepeatAction.Text != "")
            {
                if (int.TryParse(TextRepeatAction.Text, out int deger))
                {
                    actionRepeatCount = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextDescAction_TextChanged(object sender, EventArgs e)
        {
            actionDesc = TextDescAction.Text;
        }
        private void ListScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListScript.SelectedItems.Count > 0)
            {
                ComboClickType.Text = ListScript.SelectedItems[0].SubItems[1].Text;
                if (ComboClickType.Text == "Left Click")
                    actionClickType = 0;
                else if (ComboClickType.Text == "Left Click Down")
                    actionClickType = 1;
                else if (ComboClickType.Text == "Left Click Up")
                    actionClickType = 2;

                TextCoordinateX.Text = ListScript.SelectedItems[0].SubItems[2].Text;
                actionKoordinat_X = int.Parse(TextCoordinateX.Text);
                TextCoordinateY.Text = ListScript.SelectedItems[0].SubItems[3].Text;
                actionKoordinat_Y = int.Parse(TextCoordinateY.Text);

                TextWaitingTime.Text = ListScript.SelectedItems[0].SubItems[4].Text;
                actionWaitingTime = int.Parse(TextWaitingTime.Text);

                TextRepeatAction.Text = ListScript.SelectedItems[0].SubItems[5].Text;
                actionRepeatCount = int.Parse(TextRepeatAction.Text);

                TextDescAction.Text = ListScript.SelectedItems[0].SubItems[6].Text;
                actionDesc = TextDescAction.Text;

                selectedItem = ListScript.SelectedIndices[0];
            }
        }
        private void ButtonActionAdd_Click(object sender, EventArgs e)
        {
            AddAction();
        }
        private void AddAction()
        {
            // sira- mouse click tip - koordinat - waiting - repeat - desc
            string clickTypeString = "";
            if (actionClickType == 0)
                clickTypeString = "Left Click";
            else if (actionClickType == 1)
                clickTypeString = "Left Click Down";
            else if (actionClickType == 2)
                clickTypeString = "Left Click Up";

            string[] listItem = { ListScript.Items.Count.ToString(), clickTypeString, actionKoordinat_X.ToString()
            , actionKoordinat_Y.ToString(), actionWaitingTime.ToString(), actionRepeatCount.ToString(), actionDesc};

            ListViewItem viewItem = new ListViewItem(listItem);
            ListScript.Items.Add(viewItem);
        }
        // Selected Items
        private void ButtonSelectedAdd_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < ListScript.Items.Count; c++)
            {
                if (ListScript.Items[c].Selected)
                {
                    ListViewItem viewItem = new ListViewItem();
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        viewItem.SubItems.Add(ListScript.Items[c].SubItems[h].Text);
                    }
                    viewItem.SubItems[0].Text = ListScript.Items.Count.ToString();
                    ListScript.Items.Add(viewItem);
                }
            }
        }
        private void ButtonSelectedUpdate_Click(object sender, EventArgs e)
        {
            // sira- mouse click tip - koordinat - waiting - repeat - desc
            string clickTypeString = "";
            if (actionClickType == 0)
                clickTypeString = "Left Click";
            else if (actionClickType == 1)
                clickTypeString = "Left Click Down";
            else if (actionClickType == 2)
                clickTypeString = "Left Click Up";

            string[] listItem = { ListScript.Items.Count.ToString(), clickTypeString, actionKoordinat_X.ToString()
            , actionKoordinat_Y.ToString(), actionWaitingTime.ToString(), actionRepeatCount.ToString(), actionDesc};

            ListViewItem viewItem = new ListViewItem(listItem);
            for (int c = 0; c < ListScript.Items.Count; c++)
            {
                if (ListScript.Items[c].Selected)
                {
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        ListScript.Items[c].SubItems[h].Text = viewItem.SubItems[h].Text;
                    }
                }
            }
        }
        private void ButtonSelectedUp_Click(object sender, EventArgs e)
        {
            if (selectedItem != 0)
            {
                ListViewItem viewItem = new ListViewItem();
                ListViewItem viewItem1 = new ListViewItem();
                for (int c = 1; c < ListScript.Items[selectedItem - 1].SubItems.Count; c++)
                {
                    viewItem.SubItems.Add(ListScript.Items[selectedItem - 1].SubItems[c].Text);
                    viewItem1.SubItems.Add(ListScript.Items[selectedItem].SubItems[c].Text);
                }
                for (int c = 1; c < ListScript.Items[selectedItem - 1].SubItems.Count; c++)
                {
                    ListScript.Items[selectedItem - 1].SubItems[c].Text = viewItem1.SubItems[c].Text;
                    ListScript.Items[selectedItem].SubItems[c].Text = viewItem.SubItems[c].Text;
                }
                selectedItem--;
            }
        }
        private void ButtonSelectedDown_Click(object sender, EventArgs e)
        {
            if (selectedItem != ListScript.Items.Count - 1)
            {
                ListViewItem viewItem = new ListViewItem();
                ListViewItem viewItem1 = new ListViewItem();
                for (int c = 1; c < ListScript.Items[selectedItem + 1].SubItems.Count; c++)
                {
                    viewItem.SubItems.Add(ListScript.Items[selectedItem + 1].SubItems[c].Text);
                    viewItem1.SubItems.Add(ListScript.Items[selectedItem].SubItems[c].Text);
                }
                for (int c = 1; c < ListScript.Items[selectedItem + 1].SubItems.Count; c++)
                {
                    ListScript.Items[selectedItem + 1].SubItems[c].Text = viewItem1.SubItems[c].Text;
                    ListScript.Items[selectedItem].SubItems[c].Text = viewItem.SubItems[c].Text;
                }
                selectedItem++;
            }
        }
        private void ButtonSelectedDelete_Click(object sender, EventArgs e)
        {
            if (selectedItem < ListScript.Items.Count)
            {
                ListScript.Items.RemoveAt(selectedItem);
                for (int c = 0; c < ListScript.Items.Count; c++)
                {
                    ListScript.Items[c].SubItems[0].Text = c.ToString();
                }
            }
        }
        // Checked Items
        private void ButtonCheckedAdd_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < ListScript.Items.Count; c++)
            {
                if (ListScript.Items[c].Checked)
                {
                    ListScript.Items[c].Checked = false;
                    ListViewItem viewItem = new ListViewItem();
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        viewItem.SubItems.Add(ListScript.Items[c].SubItems[h].Text);
                    }
                    viewItem.SubItems[0].Text = ListScript.Items.Count.ToString();
                    ListScript.Items.Add(viewItem);
                }
            }
            //for (int c = 0; c < ListScript.Items.Count; c++)
            //{
            //    if (ListScript.Items[c].Selected)
            //    {
            //        ListViewItem viewItem = new ListViewItem();
            //        for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
            //        {
            //            viewItem.SubItems.Add(ListScript.Items[c].SubItems[h].Text);
            //        }
            //        viewItem.SubItems[0].Text = ListScript.Items.Count.ToString();
            //        ListScript.Items.Add(viewItem);
            //    }
            //}
        }
        private void ButtonCheckedUpdate_Click(object sender, EventArgs e)
        {
            // sira- mouse click tip - koordinat - waiting - repeat - desc
            string clickTypeString = "";
            if (actionClickType == 0)
                clickTypeString = "Left Click";
            else if (actionClickType == 1)
                clickTypeString = "Left Click Down";
            else if (actionClickType == 2)
                clickTypeString = "Left Click Up";

            string[] listItem = { ListScript.Items.Count.ToString(), clickTypeString, actionKoordinat_X.ToString()
            , actionKoordinat_Y.ToString(), actionWaitingTime.ToString(), actionRepeatCount.ToString(), actionDesc};

            ListViewItem viewItem = new ListViewItem(listItem);
            for (int c = 0; c < ListScript.Items.Count; c++)
            {
                if (ListScript.Items[c].Checked)
                {
                    ListScript.Items[c].Checked = false;
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        ListScript.Items[c].SubItems[h].Text = viewItem.SubItems[h].Text;
                    }
                }
            }
        }
        private void ButtonCheckedUp_Click(object sender, EventArgs e)
        {
            for (int c = 1; c < ListScript.Items.Count; c++)
            {
                if (ListScript.Items[c].Checked)
                {
                    ListScript.Items[c].Checked = false;
                    ListViewItem viewItem = new ListViewItem();
                    ListViewItem viewItem1 = new ListViewItem();
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        viewItem.SubItems.Add(ListScript.Items[c - 1].SubItems[h].Text);
                        viewItem1.SubItems.Add(ListScript.Items[c].SubItems[h].Text);
                    }
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        ListScript.Items[c - 1].SubItems[h].Text = viewItem1.SubItems[h].Text;
                        ListScript.Items[c].SubItems[h].Text = viewItem.SubItems[h].Text;
                    }
                }
            }
        }
        private void ButtonCheckedDown_Click(object sender, EventArgs e)
        {
            for (int c = ListScript.Items.Count - 2; c >= 0; c--)
            {
                if (ListScript.Items[c].Checked)
                {
                    ListScript.Items[c].Checked = false;
                    ListViewItem viewItem = new ListViewItem();
                    ListViewItem viewItem1 = new ListViewItem();
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        viewItem.SubItems.Add(ListScript.Items[c + 1].SubItems[h].Text);
                        viewItem1.SubItems.Add(ListScript.Items[c].SubItems[h].Text);
                    }
                    for (int h = 1; h < ListScript.Items[c].SubItems.Count; h++)
                    {
                        ListScript.Items[c + 1].SubItems[h].Text = viewItem1.SubItems[h].Text;
                        ListScript.Items[c].SubItems[h].Text = viewItem.SubItems[h].Text;
                    }
                }
            }
        }
        private void ButtonCheckedDelete_Click(object sender, EventArgs e)
        {
            for (int c = ListScript.Items.Count - 1; c >= 0; c--)
            {
                if (ListScript.Items[c].Checked)
                {
                    ListScript.Items.RemoveAt(c);
                }
            }
            for (int c = 0; c < ListScript.Items.Count; c++)
            {
                ListScript.Items[c].SubItems[0].Text = c.ToString();
            }
        }
        #endregion

        #region Script List Time
        private int scriptListRepeatCount = 1;
        private int scriptListRepeatCountNext = 1;
        private int scriptListScriptRepeatCountNext = 1;

        private int timetotal = 0;
        private int timescript = 0;
        private int timecurrent = 0;

        private int currentSaat = 0;
        private int currentDakika = 0;
        private int currentSaniye = 0;

        private bool started = false;
        private bool played = false;
        private int actionOrder;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ClickStartStop();
        }
        private void TimerClick_Tick(object sender, EventArgs e)
        {
            clickPoint.X = int.Parse(ListScript.Items[actionOrder].SubItems[2].Text);
            clickPoint.Y = int.Parse(ListScript.Items[actionOrder].SubItems[3].Text);

            if (ListScript.Items[actionOrder].SubItems[1].Text == "Left Click")
            {
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(10);
                clickButton.LeftClickRelease();
            }
            else if (ListScript.Items[actionOrder].SubItems[1].Text == "Left Click Down")
            {
                clickButton.LeftDownClick(clickPoint);
                Thread.Sleep(10);
            }
            else if (ListScript.Items[actionOrder].SubItems[1].Text == "Left Click Up")
            {
                clickButton.MouseMoving(clickPoint);
                Thread.Sleep(10);
                clickButton.LeftUpClick(clickPoint);
                Thread.Sleep(10);
            }
            scriptListRepeatCountNext--;
            LabelRepeatAction.Text = "" + scriptListRepeatCountNext + " - " + scriptListRepeatCount;

            timecurrent -= TimerClick.Interval;
            CurrentTimeTextUpdate(timecurrent);

            if (scriptListRepeatCountNext == 0)
            {
                actionOrder++;
                if (actionOrder == ListScript.Items.Count)
                {
                    scriptListScriptRepeatCountNext--;
                    LabelRepeatScript.Text = "" + scriptListScriptRepeatCountNext + " - " + scriptRepeatCount;
                    if (scriptListScriptRepeatCountNext == 0)
                    {
                        ClickStartStop();
                    }
                    else
                    {
                        actionOrder = 0;
                        ActionSet(actionOrder);

                        timecurrent = timescript;
                        CurrentTimeTextUpdate(timecurrent);
                    }
                }
                else
                {
                    ActionSet(actionOrder);
                }
            }
        }
        private void ActionSet(int action)
        {
            TimerClick.Interval = int.Parse(ListScript.Items[action].SubItems[4].Text);

            scriptListRepeatCountNext = int.Parse(ListScript.Items[action].SubItems[5].Text);
            scriptListRepeatCount = int.Parse(ListScript.Items[action].SubItems[5].Text);
            LabelRepeatAction.Text = "" + scriptListRepeatCountNext + " - " + scriptListRepeatCount;
        }
        private void CurrentTimeTextUpdate(int current)
        {
            currentSaat = (current / 1000) / 60 / 60;
            currentDakika = (current - (currentSaat * 3600 * 1000)) / 1000 / 60;
            currentSaniye = (current / 1000) % 60;
            LabelTimeCurrent.Text = (currentSaat + " : " + currentDakika + " : " + currentSaniye).ToString();
        }
        private void ClickStartStop()
        {
            if (ListScript.Items.Count > 0)
            {
                started = !started;
                TimerClick.Enabled = started;
                played = started;
                if (started)
                {
                    timetotal = 0;
                    actionOrder = 0;
                    scriptListRepeatCountNext = 0;
                    scriptListRepeatCount = 0;
                    scriptListScriptRepeatCountNext = scriptRepeatCount;
                    LabelDurum.Text = "Play";

                    CheckScript.Checked = true;
                    CheckAction.Checked = true;

                    GroupScript.Size = new Size(this.Size.Width - 35, 20);
                    GroupAction.Size = new Size(this.Size.Width - 35, 20);

                    for (int c = 0; c < ListScript.Items.Count; c++)
                    {
                        scriptListRepeatCountNext = int.Parse(ListScript.Items[c].SubItems[5].Text);
                        timetotal += int.Parse(ListScript.Items[c].SubItems[4].Text) * scriptListRepeatCountNext;
                    }
                    timecurrent = timetotal;
                    timescript = timetotal;
                    timetotal = (timetotal * scriptRepeatCount);

                    int saat = (timetotal / 1000) / 60 / 60;
                    int dakika = (timetotal - (saat * 3600 * 1000)) / 1000 / 60;
                    int saniye = (timetotal / 1000) % 60;
                    LabelTimeTotal.Text = (saat + " : " + dakika + " : " + saniye).ToString();

                    saat = (timescript / 1000) / 60 / 60;
                    dakika = (timescript - (saat * 3600 * 1000)) / 1000 / 60;
                    saniye = (timescript / 1000) % 60;
                    LabelTimeScript.Text = (saat + " : " + dakika + " : " + saniye).ToString();
                    LabelTimeCurrent.Text = LabelTimeScript.Text;

                    scriptListRepeatCountNext = int.Parse(ListScript.Items[0].SubItems[5].Text);
                    scriptListRepeatCount = int.Parse(ListScript.Items[0].SubItems[5].Text);

                    LabelRepeatAction.Text = "" + scriptListRepeatCountNext + " - " + scriptListRepeatCount;
                    LabelRepeatScript.Text = "" + scriptListScriptRepeatCountNext + " - " + scriptRepeatCount;

                    TimerClick.Interval = int.Parse(ListScript.Items[0].SubItems[4].Text);
                    TimerClick.Start();
                }
                else
                {
                    TimerClick.Stop();
                    LabelDurum.Text = "Start";

                    LabelTimeTotal.Text = "";
                    LabelTimeScript.Text = "";
                    LabelTimeCurrent.Text = "";

                    scriptListRepeatCountNext = int.Parse(ListScript.Items[0].SubItems[5].Text);
                    scriptListRepeatCount = int.Parse(ListScript.Items[0].SubItems[5].Text);

                    LabelRepeatAction.Text = "";
                    LabelRepeatScript.Text = "";

                    CheckScript.Checked = false;
                    CheckAction.Checked = false;

                    GroupScript.Size = new Size(this.Size.Width - 35, groupScriptSizeY);
                    GroupAction.Size = new Size(this.Size.Width - 35, groupActionSizeY);
                }
                GroupAction.Location = new Point(10, GroupScript.Location.Y + GroupScript.Size.Height);
                GroupListTime.Location = new Point(10, GroupAction.Location.Y + GroupAction.Size.Height);
                GroupListTime.Size = new Size(this.Size.Width - 35, this.Size.Height -
                    (GroupScript.Location.Y + GroupScript.Size.Height + GroupAction.Size.Height + 40));
            }
        }
        private void ClickPlayPause()
        {
            played = !played;
            TimerClick.Enabled = played;
            if (!played)
            {
                TimerClick.Stop();
                LabelDurum.Text = "Pause";
            }
            else
            {
                TimerClick.Start();
                LabelDurum.Text = "Play";
            }
        }
        #endregion
    }
}