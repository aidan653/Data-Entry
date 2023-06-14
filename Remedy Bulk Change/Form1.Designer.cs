namespace Remedy_Bulk_Change
{
    partial class Form1
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
            panelPositions = new Panel();
            panelTemplate = new Panel();
            textTemplate = new TextBox();
            labelTemplate = new Label();
            scrollPositions = new VScrollBar();
            btnAddPosition = new Button();
            label1 = new Label();
            label2 = new Label();
            panelTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // panelPositions
            // 
            panelPositions.BorderStyle = BorderStyle.FixedSingle;
            panelPositions.Location = new Point(12, 83);
            panelPositions.Name = "panelPositions";
            panelPositions.Size = new Size(514, 224);
            panelPositions.TabIndex = 0;
            panelPositions.Paint += panel1_Paint;
            // 
            // panelTemplate
            // 
            panelTemplate.BackColor = SystemColors.ActiveBorder;
            panelTemplate.BorderStyle = BorderStyle.Fixed3D;
            panelTemplate.Controls.Add(textTemplate);
            panelTemplate.Controls.Add(labelTemplate);
            panelTemplate.ForeColor = SystemColors.ControlDark;
            panelTemplate.Location = new Point(129, 433);
            panelTemplate.Name = "panelTemplate";
            panelTemplate.Size = new Size(506, 51);
            panelTemplate.TabIndex = 0;
            panelTemplate.Paint += panel1_Paint_1;
            // 
            // textTemplate
            // 
            textTemplate.Location = new Point(251, 8);
            textTemplate.Name = "textTemplate";
            textTemplate.Size = new Size(220, 31);
            textTemplate.TabIndex = 1;
            textTemplate.TextChanged += textBox1_TextChanged;
            // 
            // labelTemplate
            // 
            labelTemplate.AutoSize = true;
            labelTemplate.BackColor = SystemColors.ActiveBorder;
            labelTemplate.ForeColor = SystemColors.ActiveCaptionText;
            labelTemplate.Location = new Point(31, 11);
            labelTemplate.Name = "labelTemplate";
            labelTemplate.Size = new Size(59, 25);
            labelTemplate.TabIndex = 0;
            labelTemplate.Text = "label3";
            // 
            // scrollPositions
            // 
            scrollPositions.Location = new Point(529, 83);
            scrollPositions.Name = "scrollPositions";
            scrollPositions.Size = new Size(26, 224);
            scrollPositions.TabIndex = 1;
            // 
            // btnAddPosition
            // 
            btnAddPosition.Location = new Point(390, 31);
            btnAddPosition.Name = "btnAddPosition";
            btnAddPosition.Size = new Size(136, 34);
            btnAddPosition.TabIndex = 2;
            btnAddPosition.Text = "Add Position";
            btnAddPosition.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 3;
            label1.Text = "Added Positions";
            // 
            // label2
            // 
            label2.Location = new Point(532, 22);
            label2.Name = "label2";
            label2.Size = new Size(206, 61);
            label2.TabIndex = 4;
            label2.Text = "Hover over position and press enter to save";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(panelTemplate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddPosition);
            Controls.Add(scrollPositions);
            Controls.Add(panelPositions);
            Name = "Form1";
            Text = "Form1";
            panelTemplate.ResumeLayout(false);
            panelTemplate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPositions;
        private VScrollBar scrollPositions;
        private Button btnAddPosition;
        private Label label1;
        private Label label2;
        private Panel panelTemplate;
        private Label labelTemplate;
        private TextBox textTemplate;
    }
}