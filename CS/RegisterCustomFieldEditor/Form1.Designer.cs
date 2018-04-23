namespace RegisterCustomFieldEditor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnShowPreview = new System.Windows.Forms.Button();
            this.btnShowDesigner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPreview
            // 
            this.btnShowPreview.Location = new System.Drawing.Point(46, 52);
            this.btnShowPreview.Name = "btnShowPreview";
            this.btnShowPreview.Size = new System.Drawing.Size(195, 47);
            this.btnShowPreview.TabIndex = 0;
            this.btnShowPreview.Text = "Show Print Preview";
            this.btnShowPreview.UseVisualStyleBackColor = true;
            this.btnShowPreview.Click += new System.EventHandler(this.btnShowPreview_Click);
            // 
            // btnShowDesigner
            // 
            this.btnShowDesigner.Location = new System.Drawing.Point(46, 136);
            this.btnShowDesigner.Name = "btnShowDesigner";
            this.btnShowDesigner.Size = new System.Drawing.Size(195, 47);
            this.btnShowDesigner.TabIndex = 1;
            this.btnShowDesigner.Text = "Show Report Designer";
            this.btnShowDesigner.UseVisualStyleBackColor = true;
            this.btnShowDesigner.Click += new System.EventHandler(this.btnShowDesigner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowDesigner);
            this.Controls.Add(this.btnShowPreview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPreview;
        private System.Windows.Forms.Button btnShowDesigner;
    }
}

