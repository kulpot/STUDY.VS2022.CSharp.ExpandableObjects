namespace ExpandableObjects
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
            ExpandableObjects.Vertex vertex1 = new ExpandableObjects.Vertex();
            this.superControls1 = new ExpandableObjects.SuperControls();
            this.SuspendLayout();
            // 
            // superControls1
            // 
            this.superControls1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.superControls1.Location = new System.Drawing.Point(12, 12);
            this.superControls1.Name = "superControls1";
            this.superControls1.Size = new System.Drawing.Size(257, 164);
            this.superControls1.TabIndex = 0;
            this.superControls1.Text = "superControls1";
            vertex1.X = 100;
            vertex1.Y = 100;
            vertex1.Z = 100;
            this.superControls1.Vertex = vertex1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 206);
            this.Controls.Add(this.superControls1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SuperControls superControls1;
    }
}

