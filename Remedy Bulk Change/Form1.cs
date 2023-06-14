namespace Remedy_Bulk_Change
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            scrollPositions.Value = panelPositions.VerticalScroll.Value;
            scrollPositions.Value = panelPositions.VerticalScroll.Minimum;
            scrollPositions.Value = panelPositions.VerticalScroll.Maximum;

            panelPositions.ControlAdded += panelPositions_ControlAdded;
            panelPositions.ControlRemoved += panelPositions_ControlRemoved;
        }
        private void panelPositions_ControlAdded(object sender, ControlEventArgs e)
        {
            scrollPositions.Value = panelPositions.VerticalScroll.Minimum;
        }
        private void panelPositions_ControlRemoved(object sender, ControlEventArgs e)
        {
            scrollPositions.Value = panelPositions.VerticalScroll.Minimum;
        }
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            MyInputs myInputs = new MyInputs();
            MemorablePositions positions = new MemorablePositions();

            Panel back = new Panel();
            Label coords = new Label();
            TextBox value = new TextBox();
            back.BackColor = SystemColors.ActiveBorder;
            back.BorderStyle = BorderStyle.Fixed3D;
            back.Controls.Add(value);
            back.Controls.Add(coords);
            back.ForeColor = SystemColors.ControlDark;
            back.Location = new Point(3, 3 + (51 * i));
            back.Name = "panelPosition" + i.ToString();
            back.Size = new Size(506, 51);
            back.TabIndex = 0;
            back.Paint += panel1_Paint_1;
            coords.AutoSize = true;
            coords.BackColor = SystemColors.ActiveBorder;
            coords.ForeColor = SystemColors.ActiveCaptionText;
            coords.Location = new Point(31, 11);
            coords.Name = "coords";
            coords.Size = new Size(59, 25);
            coords.TabIndex = 0;
            coords.Text = "label3";
            value.Location = new Point(251, 8);
            value.Name = "textTemplate";
            value.Size = new Size(220, 31);
            value.TabIndex = 1;
            value.TextChanged += textBox1_TextChanged;
            back.Controls.Add(coords);
            back.Controls.Add(value);
            i++;
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
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
    }
}