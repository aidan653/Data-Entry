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
            panelPositions = new Positions();
            label3 = new Label();
            Submit = new Button();
            ddlPresets = new ComboBox();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // btnAddPosition
            // 
            btnAddPosition.Location = new Point(348, 19);
            btnAddPosition.Margin = new Padding(2);
            btnAddPosition.Name = "btnAddPosition";
            btnAddPosition.Size = new Size(84, 23);
            btnAddPosition.TabIndex = 2;
            btnAddPosition.Text = "Add Position";
            btnAddPosition.UseVisualStyleBackColor = true;
            btnAddPosition.Click += btnAddPosition_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(11, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 3;
            label1.Text = "Added Positions";
            // 
            // label2
            // 
            label2.Location = new Point(436, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 37);
            label2.TabIndex = 4;
            label2.Text = "Hover over position and press right shift to save";
            label2.Click += label2_Click_1;
            // 
            // panelPositions
            // 
            panelPositions.AutoScroll = true;
            panelPositions.BorderStyle = BorderStyle.FixedSingle;
            panelPositions.Location = new Point(12, 50);
            panelPositions.Name = "panelPositions";
            panelPositions.Size = new Size(401, 229);
            panelPositions.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(436, 66);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 59);
            label3.TabIndex = 6;
            label3.Text = "Click checkbox when done submitting a value";
            label3.Click += label3_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(431, 343);
            Submit.Name = "Submit";
            Submit.Size = new Size(117, 23);
            Submit.TabIndex = 7;
            Submit.Text = "Perform Actions";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // ddlPresets
            // 
            ddlPresets.FormattingEnabled = true;
            ddlPresets.Location = new Point(181, 19);
            ddlPresets.Name = "ddlPresets";
            ddlPresets.Size = new Size(121, 23);
            ddlPresets.TabIndex = 8;
            ddlPresets.Text = "Presets";
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(308, 14);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(2, 0, 0, 0);
            btnSave.Size = new Size(35, 32);
            btnSave.TabIndex = 9;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Image = Properties.Resources.load;
            btnLoad.Location = new Point(140, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Padding = new Padding(2, 0, 0, 0);
            btnLoad.Size = new Size(35, 32);
            btnLoad.TabIndex = 10;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 378);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(ddlPresets);
            Controls.Add(Submit);
            Controls.Add(label3);
            Controls.Add(panelPositions);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddPosition);
            Margin = new Padding(2);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPosition;
        private Label label1;
        private Label label2;
        private Positions panelPositions;
        private Label label3;
        private Button Submit;
        private ComboBox ddlPresets;
        private Button btnSave;
        private Button btnLoad;
    }
}