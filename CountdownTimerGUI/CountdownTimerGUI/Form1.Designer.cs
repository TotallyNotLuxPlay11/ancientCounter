namespace CountdownTimerGUI;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        textBoxHours = new System.Windows.Forms.TextBox();
        textBoxSeconds = new System.Windows.Forms.TextBox();
        textBoxMinutes = new System.Windows.Forms.TextBox();
        buttonStart = new System.Windows.Forms.Button();
        labelCountdown = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // textBoxHours
        // 
        textBoxHours.Location = new System.Drawing.Point(76, 401);
        textBoxHours.Name = "textBoxHours";
        textBoxHours.Size = new System.Drawing.Size(100, 27);
        textBoxHours.TabIndex = 0;
        // 
        // textBoxSeconds
        // 
        textBoxSeconds.Location = new System.Drawing.Point(288, 401);
        textBoxSeconds.Name = "textBoxSeconds";
        textBoxSeconds.Size = new System.Drawing.Size(100, 27);
        textBoxSeconds.TabIndex = 1;
        // 
        // textBoxMinutes
        // 
        textBoxMinutes.Location = new System.Drawing.Point(182, 401);
        textBoxMinutes.Name = "textBoxMinutes";
        textBoxMinutes.Size = new System.Drawing.Size(100, 27);
        textBoxMinutes.TabIndex = 2;
        // 
        // buttonStart
        // 
        buttonStart.Location = new System.Drawing.Point(410, 402);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new System.Drawing.Size(106, 26);
        buttonStart.TabIndex = 3;
        buttonStart.Text = "Start Timer";
        buttonStart.UseVisualStyleBackColor = true;
        // 
        // labelCountdown
        // 
        labelCountdown.Dock = System.Windows.Forms.DockStyle.Top;
        labelCountdown.Location = new System.Drawing.Point(0, 0);
        labelCountdown.Name = "labelCountdown";
        labelCountdown.Size = new System.Drawing.Size(800, 187);
        labelCountdown.TabIndex = 4;
        labelCountdown.Text = "00:00:00";
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelCountdown);
        Controls.Add(buttonStart);
        Controls.Add(textBoxMinutes);
        Controls.Add(textBoxSeconds);
        Controls.Add(textBoxHours);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label labelCountdown;

    private System.Windows.Forms.Button buttonStart;

    private System.Windows.Forms.TextBox textBoxHours;
    private System.Windows.Forms.TextBox textBoxSeconds;
    private System.Windows.Forms.TextBox textBoxMinutes;

    #endregion
}