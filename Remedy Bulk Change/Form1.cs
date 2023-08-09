using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Remedy_Bulk_Change
{
    public partial class Form1 : Form
    {
        private MyInputs myInputs;
        int i = 0;
        bool pressedEnter = true;
        bool valueEntered = true;
        private MemorablePositions positions = new MemorablePositions();
        public Form1()
        {
            InitializeComponent();

            panelPositions.ControlAdded += panelPositions_ControlAdded;
            panelPositions.ControlRemoved += panelPositions_ControlRemoved;
            //panelPositions.Scroll += MyPanelScroll_Handler;
        }

        private void panelPositions_ControlAdded(object sender, ControlEventArgs e)
        {
        }
        private void panelPositions_ControlRemoved(object sender, ControlEventArgs e)
        {
        }
        private void btnAddPosition_Click_1(object sender, EventArgs e)
        {
            if (pressedEnter && valueEntered)
            {
                valueEntered = false;
                pressedEnter = false;
                MyInputs myInputs = new MyInputs();
                Panel back = new Panel();
                Label coords = new Label();
                TextBox value = new TextBox();
                CheckBox chk = new CheckBox();
                back.BackColor = SystemColors.ActiveBorder;
                back.BorderStyle = BorderStyle.Fixed3D;
                back.Controls.Add(value);
                back.Controls.Add(coords);
                back.ForeColor = SystemColors.ControlDark;
                back.Location = new Point(3, 3 + (32 * i));
                back.Name = "panelPosition" + i;
                back.Size = new Size(panelPositions.Width - 25, 32);
                back.TabIndex = 0;
                back.Paint += panel1_Paint_1;
                coords.AutoSize = true;
                coords.BackColor = SystemColors.ActiveBorder;
                coords.ForeColor = SystemColors.ActiveCaptionText;
                coords.Location = new Point(5, 7);
                coords.Name = "coords" + i;
                coords.Size = new Size(45, 25);
                coords.TabIndex = 0;
                coords.Text = "Press RShift...";
                value.Location = new Point(125, 2);
                value.Name = "textValue" + i;
                value.Size = new Size(220, 31);
                value.TabIndex = 1;
                value.TextChanged += textBox1_TextChanged;
                chk.AutoSize = true;
                chk.Location = new Point(350, 7);
                chk.Name = "chk" + i;
                back.Controls.Add(coords);
                back.Controls.Add(value);
                back.Controls.Add(chk);
                panelPositions.Controls.Add(back);
                int[] test = new int[2];
                MyInputs.Start();
                MyInputs.OnKeyDown += (s, args) =>
                {
                    if (args.KeyValue == (int)Keys.RShiftKey && !pressedEnter)
                    {
                        Point xy = MyInputs.GetCursorPosition();
                        Control[] matches = panelPositions.Controls.Find("coords" + (i - 1), true);
                        matches[0].Text = xy.ToString();
                        value.Focus();
                        pressedEnter = true;
                    }
                };
                //if chk is checked, then add the position to the list
                chk.Click += (s, args) =>
                {
                    if (chk.Checked)
                    {
                        positions.AddPosition(coords.Text, value.Text);
                        valueEntered = true;
                    }
                };
                i++;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MyPanelScroll_Handler(System.Object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            Panel p = (Panel)sender;
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                p.HorizontalScroll.Value = e.NewValue;
            }
            else if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                p.VerticalScroll.Value = e.NewValue;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyInputs.Stop();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //for each key val in positions, move mouse to the point from the key, and enter the value
            foreach (var item in positions.keyValuePairs)
            {
                MyInputs.MoveMouse(item.Key);
                MyInputs.EnterString(item.Value);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}