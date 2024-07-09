namespace DrawingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonSketch;
        private System.Windows.Forms.GroupBox groupBoxShapes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonSketch = new System.Windows.Forms.RadioButton();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.groupBoxShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Location = new System.Drawing.Point(12, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(760, 500);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 518);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 2;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(6, 42);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRectangle.TabIndex = 3;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 4;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // radioButtonSketch
            // 
            this.radioButtonSketch.AutoSize = true;
            this.radioButtonSketch.Location = new System.Drawing.Point(6, 88);
            this.radioButtonSketch.Name = "radioButtonSketch";
            this.radioButtonSketch.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSketch.TabIndex = 5;
            this.radioButtonSketch.TabStop = true;
            this.radioButtonSketch.Text = "Sketch";
            this.radioButtonSketch.UseVisualStyleBackColor = true;
            this.radioButtonSketch.CheckedChanged += new System.EventHandler(this.radioButtonSketch_CheckedChanged);

            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.radioButtonLine);
            this.groupBoxShapes.Controls.Add(this.radioButtonSketch);
            this.groupBoxShapes.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShapes.Controls.Add(this.radioButtonCircle);
            this.groupBoxShapes.Location = new System.Drawing.Point(93, 518);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(200, 120);
            this.groupBoxShapes.TabIndex = 5;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxShapes);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panelCanvas);
            this.Name = "Form1";
            this.Text = "Drawing and Sketching App";
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
