using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using Microsoft.Win32;

namespace Remedy_Bulk_Change
{
    public partial class Form1 : Form
    {
        private MyInputs myInputs;
        int i = 0;
        bool pressedRShift = true;
        bool valueEntered = true;
        private MemorablePositions positions = new MemorablePositions();
        public Form1()
        {
            InitializeComponent();
            AddPresets();
            panelPositions.ControlAdded += panelPositions_ControlAdded;
            panelPositions.ControlRemoved += panelPositions_ControlRemoved;
            MyInputs.Start();
            MyInputs.OnKeyDown += (s, args) =>
            {
                if (args.KeyValue == (int)Keys.RControlKey && pressedRShift)
                {
                    addPostion();
                }
            };
        }
        private void btnAddPosition_Click_1(object sender, EventArgs e)
        {
            addPostion();
        }
        private void addPostion()
        {
            if (pressedRShift && valueEntered)
            {
                valueEntered = false;
                pressedRShift = false;
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
                back.Location = new Point(3, 3 + (42 * i));
                back.Name = "panelPosition" + i;
                back.Size = new Size(panelPositions.Width - 25, 42);
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
                value.Location = new Point(155, 3);
                value.Name = "textValue" + i;
                value.Size = new Size(220, 31);
                value.TabIndex = 1;
                value.TextChanged += textBox1_TextChanged;
                chk.AutoSize = true;
                chk.Location = new Point(390, 9);
                chk.Name = "chk" + i;
                back.Controls.Add(coords);
                back.Controls.Add(value);
                back.Controls.Add(chk);
                panelPositions.Controls.Add(back);
                int[] test = new int[2];
                MyInputs.OnKeyDown += (s, args) =>
                {
                    Debug.WriteLine(args.KeyValue);
                    if (args.KeyValue == (int)Keys.RShiftKey && !pressedRShift)
                    {
                        Point xy = MyInputs.GetCursorPosition();
                        Control[] matches = panelPositions.Controls.Find("coords" + (i - 1), true);
                        matches[0].Text = xy.ToString();
                        //value.Focus();
                        pressedRShift = true;
                    }
                    if (args.KeyValue == 220 && !valueEntered)
                    {
                        Control[] matches = panelPositions.Controls.Find("chk" + (i - 1), true);
                        CheckBox checkbox = matches[0] as CheckBox;

                        if (checkbox != null)
                        {
                            checkbox.Focus();
                            checkbox.Checked = true;
                            Control[] myCoords = panelPositions.Controls.Find("coords" + (i - 1), true);
                            Control[] myValue = panelPositions.Controls.Find("textValue" + (i - 1), true);
                            positions.AddPosition(myCoords[0].Text, myValue[0].Text);
                            valueEntered = true;
                        }
                    }
                };
                chk.Click += (s, args) =>
                {
                    if (chk.Checked && !valueEntered)
                    {
                        Control[] myCoords = panelPositions.Controls.Find("coords" + (i - 1), true);
                        Control[] myValue = panelPositions.Controls.Find("textValue" + (i - 1), true);
                        positions.AddPosition(myCoords[0].Text, myValue[0].Text);
                        valueEntered = true;
                    }
                };
                i++;
            }
        }
        private void addPositionXML(string coordinates, string inputValue)
        {
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
            coords.Text = coordinates;
            value.Location = new Point(125, 2);
            value.Name = "textValue" + i;
            value.Size = new Size(220, 31);
            value.TabIndex = 1;
            value.Text = inputValue;
            value.TextChanged += textBox1_TextChanged;
            chk.AutoSize = true;
            chk.Location = new Point(350, 7);
            chk.Name = "chk" + i;
            chk.Checked = true;
            back.Controls.Add(coords);
            back.Controls.Add(value);
            back.Controls.Add(chk);
            panelPositions.Controls.Add(back);
            Control[] myCoords = panelPositions.Controls.Find("coords" + (i), true);
            Control[] myValue = panelPositions.Controls.Find("textValue" + (i), true);
            positions.AddPosition(myCoords[0].Text, myValue[0].Text);
            i++;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyInputs.Stop();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            foreach (var item in positions.keyValuePairs)
            {
                MyInputs.MoveMouse(item.Key);
                //sleep
                Thread.Sleep(800);
                if (item.Value != "")
                    MyInputs.EnterString(item.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Enter a preset name:";
            form.Size = new Size(300, 200);
            form.AutoSize = true;
            //form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ControlBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            TextBox textbox = new TextBox();
            textbox.Size = new Size(250, 25);
            textbox.Location = new Point(6, 6);
            Button submit = new Button();
            submit.Text = "Submit";
            submit.Size = new Size(100, 40);
            submit.Location = new Point(150, 50);
            submit.Click += (s, args) =>
            {
                if (textbox.Text != "")
                {
                    form.Close();
                    ddlPresets.Items.Add(textbox.Text);
                    WriteToFile(textbox.Text + ".xml");
                }
            };
            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.Size = new Size(100, 40);
            cancel.Location = new Point(10, 50);
            cancel.Click += (s, args) =>
            {
                form.Close();
            };
            form.Controls.Add(textbox);
            form.Controls.Add(submit);
            form.Controls.Add(cancel);
            form.ShowDialog();
        }
        private void WriteToFile(string filename)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            settings.NewLineOnAttributes = true;
            using (XmlWriter writer = XmlWriter.Create(filename, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Positions");
                foreach (var item in positions.keyValuePairs)
                {
                    writer.WriteStartElement("Position");
                    writer.WriteElementString("Coords", item.Key.ToString());
                    writer.WriteElementString("Value", item.Value);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        private void AddPresets()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml");
            foreach (var item in files)
            {
                ddlPresets.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string preset = ddlPresets.SelectedItem.ToString();
            string file = preset + ".xml";
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Positions/Position");
                foreach (XmlNode node in nodes)
                {
                    string coords = node.SelectSingleNode("Coords").InnerText;
                    string value = node.SelectSingleNode("Value").InnerText;
                    addPositionXML(coords, value);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }

        }
        #region Unused form functions
        private void label2_Click_1(object sender, EventArgs e)
        {

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelPositions_ControlAdded(object sender, ControlEventArgs e)
        {
        }
        private void panelPositions_ControlRemoved(object sender, ControlEventArgs e)
        {
        }
        #endregion
    }
}