
namespace iikoBOS
{
    partial class CustomServerName
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tb_CustomServerName = new System.Windows.Forms.TextBox();
            this.btn_CustomServerName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tb_CustomServerName
            // 
            this.tb_CustomServerName.Location = new System.Drawing.Point(26, 54);
            this.tb_CustomServerName.Name = "tb_CustomServerName";
            this.tb_CustomServerName.Size = new System.Drawing.Size(285, 22);
            this.tb_CustomServerName.TabIndex = 0;
            // 
            // btn_CustomServerName
            // 
            this.btn_CustomServerName.Location = new System.Drawing.Point(121, 82);
            this.btn_CustomServerName.Name = "btn_CustomServerName";
            this.btn_CustomServerName.Size = new System.Drawing.Size(88, 39);
            this.btn_CustomServerName.TabIndex = 1;
            this.btn_CustomServerName.Text = "ОК";
            this.btn_CustomServerName.UseVisualStyleBackColor = true;
            this.btn_CustomServerName.Click += new System.EventHandler(this.btn_CustomServerName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя сервера";
            // 
            // CustomServerName
            // 
            this.AcceptButton = this.btn_CustomServerName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CustomServerName);
            this.Controls.Add(this.tb_CustomServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomServerName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomServerName";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_CustomServerName;
        public System.Windows.Forms.Button btn_CustomServerName;
    }
}