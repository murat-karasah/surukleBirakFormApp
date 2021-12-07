
namespace surukleBirakFormApp
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
            this.list_push = new System.Windows.Forms.ListBox();
            this.list_pull = new System.Windows.Forms.ListBox();
            this.txt_enter = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_push
            // 
            this.list_push.FormattingEnabled = true;
            this.list_push.Location = new System.Drawing.Point(12, 12);
            this.list_push.Name = "list_push";
            this.list_push.Size = new System.Drawing.Size(129, 277);
            this.list_push.TabIndex = 0;
            this.list_push.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_push_MouseDown);
            // 
            // list_pull
            // 
            this.list_pull.FormattingEnabled = true;
            this.list_pull.Location = new System.Drawing.Point(183, 12);
            this.list_pull.Name = "list_pull";
            this.list_pull.Size = new System.Drawing.Size(129, 277);
            this.list_pull.TabIndex = 0;
            this.list_pull.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_pull_DragDrop);
            this.list_pull.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_pull_DragEnter);
            // 
            // txt_enter
            // 
            this.txt_enter.Location = new System.Drawing.Point(13, 315);
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.Size = new System.Drawing.Size(218, 20);
            this.txt_enter.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(237, 315);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 379);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_enter);
            this.Controls.Add(this.list_pull);
            this.Controls.Add(this.list_push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_push;
        private System.Windows.Forms.ListBox list_pull;
        private System.Windows.Forms.TextBox txt_enter;
        private System.Windows.Forms.Button btn_add;
    }
}

