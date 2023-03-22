
namespace txtEditor
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
            this.bntNew = new System.Windows.Forms.Button();
            this.bntOpen = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.txtBoxInputText = new System.Windows.Forms.RichTextBox();
            this.bntBold = new System.Windows.Forms.Button();
            this.bntItalic = new System.Windows.Forms.Button();
            this.bntUnderline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(13, 13);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(142, 23);
            this.bntNew.TabIndex = 1;
            this.bntNew.Text = "Novi document";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // bntOpen
            // 
            this.bntOpen.Location = new System.Drawing.Point(13, 76);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(142, 23);
            this.bntOpen.TabIndex = 2;
            this.bntOpen.Text = "Otvaranje datoteka";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(13, 140);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(142, 23);
            this.bntSave.TabIndex = 3;
            this.bntSave.Text = "Spremi tekst document";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // txtBoxInputText
            // 
            this.txtBoxInputText.Location = new System.Drawing.Point(13, 169);
            this.txtBoxInputText.Name = "txtBoxInputText";
            this.txtBoxInputText.Size = new System.Drawing.Size(384, 269);
            this.txtBoxInputText.TabIndex = 4;
            this.txtBoxInputText.Text = "";
            // 
            // bntBold
            // 
            this.bntBold.Location = new System.Drawing.Point(316, 140);
            this.bntBold.Name = "bntBold";
            this.bntBold.Size = new System.Drawing.Size(22, 23);
            this.bntBold.TabIndex = 5;
            this.bntBold.Text = "B";
            this.bntBold.UseVisualStyleBackColor = true;
            this.bntBold.Click += new System.EventHandler(this.bntBold_Click);
            // 
            // bntItalic
            // 
            this.bntItalic.Location = new System.Drawing.Point(344, 140);
            this.bntItalic.Name = "bntItalic";
            this.bntItalic.Size = new System.Drawing.Size(23, 23);
            this.bntItalic.TabIndex = 6;
            this.bntItalic.Text = "I";
            this.bntItalic.UseVisualStyleBackColor = true;
            this.bntItalic.Click += new System.EventHandler(this.bntItalic_Click);
            // 
            // bntUnderline
            // 
            this.bntUnderline.Location = new System.Drawing.Point(373, 140);
            this.bntUnderline.Name = "bntUnderline";
            this.bntUnderline.Size = new System.Drawing.Size(24, 23);
            this.bntUnderline.TabIndex = 7;
            this.bntUnderline.Text = "U";
            this.bntUnderline.UseVisualStyleBackColor = true;
            this.bntUnderline.Click += new System.EventHandler(this.bntUnderline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.bntUnderline);
            this.Controls.Add(this.bntItalic);
            this.Controls.Add(this.bntBold);
            this.Controls.Add(this.txtBoxInputText);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.bntOpen);
            this.Controls.Add(this.bntNew);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.RichTextBox txtBoxInputText;
        private System.Windows.Forms.Button bntBold;
        private System.Windows.Forms.Button bntItalic;
        private System.Windows.Forms.Button bntUnderline;
    }
}

