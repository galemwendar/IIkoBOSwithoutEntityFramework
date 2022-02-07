
namespace iikoBOS_OlejaEdition_v0._1
{
    partial class Name
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Name = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(15, 59);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(336, 27);
            this.tb_Name.TabIndex = 0;
            // 
            // btn_Name
            // 
            this.btn_Name.Location = new System.Drawing.Point(110, 98);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Size = new System.Drawing.Size(119, 39);
            this.btn_Name.TabIndex = 1;
            this.btn_Name.Text = "OK";
            this.btn_Name.UseVisualStyleBackColor = true;
            this.btn_Name.Click += new System.EventHandler(this.btn_Name_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(92, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Введите имя сервера";
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 149);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btn_Name);
            this.Controls.Add(this.tb_Name);
            this.Name = "Name";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Name;
        private System.Windows.Forms.Label labelName;
    }
}