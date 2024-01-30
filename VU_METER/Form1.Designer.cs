namespace VU_METER;

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
        this.ProgressBar0 = new System.Windows.Forms.ProgressBar();
        this.Timer1 = new System.Windows.Forms.Timer();
        this.ComboBox2 = new System.Windows.Forms.ComboBox();
        this.Label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // ProgressBar0
        //
        this.ProgressBar0.Step = 1;
        this.ProgressBar0.Text =  "ProgressBar0";
        this.ProgressBar0.BackColor = System.Drawing.SystemColors.HotTrack;
        this.ProgressBar0.Location = new System.Drawing.Point(4,12);
        this.ProgressBar0.Size = new System.Drawing.Size(456,23);
        //
        // Timer1
        //
        this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
        //
        // ComboBox2
        //
        this.ComboBox2.ItemHeight = 15;
        this.ComboBox2.Text =  "ComboBox2";
        this.ComboBox2.Location = new System.Drawing.Point(116,48);
        this.ComboBox2.TabIndex = 2;
        //
        // Label3
        //
        this.Label3.AutoSize =  true;
        this.Label3.Text =  "OUTPUT_DEVICE:";
        this.Label3.BackColor = System.Drawing.SystemColors.HotTrack;
        this.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.Label3.Location = new System.Drawing.Point(12,52);
        this.Label3.Size = new System.Drawing.Size(97,15);
        this.Label3.TabIndex = 3;
     //
     // form
     //
        this.BackColor = System.Drawing.SystemColors.HotTrack;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox =  false;
        this.MinimizeBox =  false;
        this.ShowIcon =  false;
        this.Size = new System.Drawing.Size(480,116);
        this.Text =  "Udp_Vu_Meter";
        this.Controls.Add(this.ProgressBar0);
        this.Controls.Add(this.ComboBox2);
        this.Controls.Add(this.Label3);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.ProgressBar ProgressBar0;
    private System.Windows.Forms.Timer Timer1;
    private System.Windows.Forms.ComboBox ComboBox2;
    private System.Windows.Forms.Label Label3;
}

// private void Timer1_Tick(System.Object? sender, System.EventArgs e)
// {
// 
// }

