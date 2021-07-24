
namespace ClientRentaProject.Presentation.WinSite
{
    partial class ClientRenta
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
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.PathFileTxtBox = new System.Windows.Forms.TextBox();
            this.UploadFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(13, 35);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFileBtn.TabIndex = 0;
            this.SelectFileBtn.Text = "Seleccionar";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // PathFileTxtBox
            // 
            this.PathFileTxtBox.Enabled = false;
            this.PathFileTxtBox.Location = new System.Drawing.Point(94, 35);
            this.PathFileTxtBox.Name = "PathFileTxtBox";
            this.PathFileTxtBox.Size = new System.Drawing.Size(436, 23);
            this.PathFileTxtBox.TabIndex = 1;
            // 
            // UploadFileBtn
            // 
            this.UploadFileBtn.Location = new System.Drawing.Point(13, 85);
            this.UploadFileBtn.Name = "UploadFileBtn";
            this.UploadFileBtn.Size = new System.Drawing.Size(115, 23);
            this.UploadFileBtn.TabIndex = 2;
            this.UploadFileBtn.Text = "Subir archivo";
            this.UploadFileBtn.UseVisualStyleBackColor = true;
            this.UploadFileBtn.Click += new System.EventHandler(this.UploadFileBtn_Click);
            // 
            // ClientRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 136);
            this.Controls.Add(this.UploadFileBtn);
            this.Controls.Add(this.PathFileTxtBox);
            this.Controls.Add(this.SelectFileBtn);
            this.Name = "ClientRenta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.TextBox PathFileTxtBox;
        private System.Windows.Forms.Button UploadFileBtn;
    }
}

