namespace Restaurant;

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
        SubmitRequest = new System.Windows.Forms.Button();
        Chicken = new System.Windows.Forms.RadioButton();
        EggOrder = new System.Windows.Forms.RadioButton();
        CopyRequest = new System.Windows.Forms.Button();
        PrepareFood = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        Menu = new System.Windows.Forms.GroupBox();
        label3 = new System.Windows.Forms.Label();
        ResultsList = new System.Windows.Forms.ListBox();
        textBox1 = new System.Windows.Forms.TextBox();
        Menu.SuspendLayout();
        SuspendLayout();
        // 
        // SubmitRequest
        // 
        SubmitRequest.Location = new System.Drawing.Point(211, 110);
        SubmitRequest.Name = "SubmitRequest";
        SubmitRequest.Size = new System.Drawing.Size(195, 23);
        SubmitRequest.TabIndex = 0;
        SubmitRequest.Text = "Submit New Request";
        SubmitRequest.UseVisualStyleBackColor = true;
        SubmitRequest.Click += button1_Click;
        // 
        // Chicken
        // 
        Chicken.Checked = true;
        Chicken.Location = new System.Drawing.Point(20, 22);
        Chicken.Name = "Chicken";
        Chicken.Size = new System.Drawing.Size(76, 25);
        Chicken.TabIndex = 1;
        Chicken.TabStop = true;
        Chicken.Text = "ChickenOrder";
        Chicken.UseVisualStyleBackColor = true;
        // 
        // EggOrder
        // 
        EggOrder.Location = new System.Drawing.Point(122, 22);
        EggOrder.Name = "EggOrder";
        EggOrder.Size = new System.Drawing.Size(65, 25);
        EggOrder.TabIndex = 2;
        EggOrder.Text = "Egg";
        EggOrder.UseVisualStyleBackColor = true;
        // 
        // CopyRequest
        // 
        CopyRequest.Location = new System.Drawing.Point(48, 157);
        CopyRequest.Name = "CopyRequest";
        CopyRequest.Size = new System.Drawing.Size(358, 24);
        CopyRequest.TabIndex = 4;
        CopyRequest.Text = "Copy the previous request";
        CopyRequest.UseVisualStyleBackColor = true;
        CopyRequest.Click += CopyRequest_Click;
        // 
        // PrepareFood
        // 
        PrepareFood.Location = new System.Drawing.Point(48, 244);
        PrepareFood.Name = "PrepareFood";
        PrepareFood.Size = new System.Drawing.Size(358, 29);
        PrepareFood.TabIndex = 5;
        PrepareFood.Text = "Prepare Food";
        PrepareFood.UseVisualStyleBackColor = true;
        PrepareFood.Click += PrepareFood_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 110);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(79, 28);
        label1.TabIndex = 6;
        label1.Text = "Quantity";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 202);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(106, 19);
        label2.TabIndex = 7;
        label2.Text = "Egg Quality";
        // 
        // Menu
        // 
        Menu.Controls.Add(EggOrder);
        Menu.Controls.Add(Chicken);
        Menu.Location = new System.Drawing.Point(28, 26);
        Menu.Name = "Menu";
        Menu.Size = new System.Drawing.Size(205, 62);
        Menu.TabIndex = 9;
        Menu.TabStop = false;
        Menu.Text = "Menu";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 287);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(63, 15);
        label3.TabIndex = 10;
        label3.Text = "Results";
        // 
        // ResultsList
        // 
        ResultsList.FormattingEnabled = true;
        ResultsList.Location = new System.Drawing.Point(48, 322);
        ResultsList.Name = "ResultsList";
        ResultsList.Size = new System.Drawing.Size(358, 109);
        ResultsList.TabIndex = 11;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(67, 110);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(45, 23);
        textBox1.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(751, 450);
        Controls.Add(textBox1);
        Controls.Add(ResultsList);
        Controls.Add(label3);
        Controls.Add(Menu);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(PrepareFood);
        Controls.Add(CopyRequest);
        Controls.Add(SubmitRequest);
        Text = "Restaurant App";
        Menu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox ResultsList;

    private System.Windows.Forms.GroupBox Menu;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button CopyRequest;
    private System.Windows.Forms.Button PrepareFood;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.RadioButton EggOrder;

    private System.Windows.Forms.RadioButton Chicken;

    private System.Windows.Forms.Button SubmitRequest;

    #endregion
}