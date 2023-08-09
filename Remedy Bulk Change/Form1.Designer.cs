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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAddPosition = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Submit = new Button();
            ddlPresets = new ComboBox();
            btnSave = new Button();
            btnLoad = new Button();
            label4 = new Label();
            panelPositions = new Panel();
            SuspendLayout();
            // 
            // btnAddPosition
            // 
            btnAddPosition.Location = new Point(497, 32);
            btnAddPosition.Name = "btnAddPosition";
            btnAddPosition.Size = new Size(120, 38);
            btnAddPosition.TabIndex = 2;
            btnAddPosition.Text = "Add Position";
            btnAddPosition.UseVisualStyleBackColor = true;
            btnAddPosition.Click += btnAddPosition_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 3;
            label1.Text = "Added Positions";
            // 
            // label2
            // 
            label2.Location = new Point(623, 23);
            label2.Name = "label2";
            label2.Size = new Size(206, 62);
            label2.TabIndex = 4;
            label2.Text = "Hover over position and press right shift to save";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.Location = new Point(623, 110);
            label3.Name = "label3";
            label3.Size = new Size(199, 98);
            label3.TabIndex = 6;
            label3.Text = "Click checkbox when done submitting a value";
            // 
            // Submit
            // 
            Submit.Location = new Point(616, 572);
            Submit.Margin = new Padding(4, 5, 4, 5);
            Submit.Name = "Submit";
            Submit.Size = new Size(167, 38);
            Submit.TabIndex = 7;
            Submit.Text = "Perform Actions";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // ddlPresets
            // 
            ddlPresets.FormattingEnabled = true;
            ddlPresets.Location = new Point(259, 32);
            ddlPresets.Margin = new Padding(4, 5, 4, 5);
            ddlPresets.Name = "ddlPresets";
            ddlPresets.Size = new Size(171, 33);
            ddlPresets.TabIndex = 8;
            ddlPresets.Text = "Presets";
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(440, 23);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3, 0, 0, 0);
            btnSave.Size = new Size(50, 53);
            btnSave.TabIndex = 9;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Image = Properties.Resources.load;
            btnLoad.Location = new Point(200, 23);
            btnLoad.Margin = new Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Padding = new Padding(3, 0, 0, 0);
            btnLoad.Size = new Size(50, 53);
            btnLoad.TabIndex = 10;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 511);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // panelPositions
            // 
            panelPositions.AutoScroll = true;
            panelPositions.BorderStyle = BorderStyle.FixedSingle;
            panelPositions.Location = new Point(16, 84);
            panelPositions.Name = "panelPositions";
            panelPositions.Size = new Size(601, 398);
            panelPositions.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 630);
            Controls.Add(panelPositions);
            Controls.Add(label4);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(ddlPresets);
            Controls.Add(Submit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddPosition);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPosition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Submit;
        private ComboBox ddlPresets;
        private Button btnSave;
        private Button btnLoad;
        private Label label4;
        private Panel panelPositions;
    }
}