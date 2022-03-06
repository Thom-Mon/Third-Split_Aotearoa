namespace Third_Split_Aotearoa
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_folderDialog = new System.Windows.Forms.Button();
            this.label_chosenFolder = new System.Windows.Forms.Label();
            this.listBox_folderContents = new System.Windows.Forms.ListBox();
            this.label_folderContents = new System.Windows.Forms.Label();
            this.button_splitMP3 = new System.Windows.Forms.Button();
            this.button_addFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_helptext = new System.Windows.Forms.Label();
            this.textBox_splitSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_folderDialog
            // 
            this.button_folderDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_folderDialog.Location = new System.Drawing.Point(16, 71);
            this.button_folderDialog.Name = "button_folderDialog";
            this.button_folderDialog.Size = new System.Drawing.Size(95, 40);
            this.button_folderDialog.TabIndex = 0;
            this.button_folderDialog.Text = "Add Folder";
            this.button_folderDialog.UseVisualStyleBackColor = true;
            this.button_folderDialog.Click += new System.EventHandler(this.button_folderDialog_Click);
            // 
            // label_chosenFolder
            // 
            this.label_chosenFolder.AutoSize = true;
            this.label_chosenFolder.Location = new System.Drawing.Point(113, 71);
            this.label_chosenFolder.Name = "label_chosenFolder";
            this.label_chosenFolder.Size = new System.Drawing.Size(16, 13);
            this.label_chosenFolder.TabIndex = 1;
            this.label_chosenFolder.Text = "...";
            // 
            // listBox_folderContents
            // 
            this.listBox_folderContents.FormattingEnabled = true;
            this.listBox_folderContents.Location = new System.Drawing.Point(12, 142);
            this.listBox_folderContents.Name = "listBox_folderContents";
            this.listBox_folderContents.Size = new System.Drawing.Size(636, 186);
            this.listBox_folderContents.TabIndex = 2;
            // 
            // label_folderContents
            // 
            this.label_folderContents.AutoSize = true;
            this.label_folderContents.Location = new System.Drawing.Point(13, 123);
            this.label_folderContents.Name = "label_folderContents";
            this.label_folderContents.Size = new System.Drawing.Size(114, 13);
            this.label_folderContents.TabIndex = 3;
            this.label_folderContents.Text = "For Split Selected Files";
            // 
            // button_splitMP3
            // 
            this.button_splitMP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_splitMP3.Location = new System.Drawing.Point(539, 344);
            this.button_splitMP3.Name = "button_splitMP3";
            this.button_splitMP3.Size = new System.Drawing.Size(109, 32);
            this.button_splitMP3.TabIndex = 4;
            this.button_splitMP3.Text = "SPLIT";
            this.button_splitMP3.UseVisualStyleBackColor = true;
            this.button_splitMP3.Click += new System.EventHandler(this.button_splitMP3_Click);
            // 
            // button_addFiles
            // 
            this.button_addFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addFiles.Location = new System.Drawing.Point(16, 12);
            this.button_addFiles.Name = "button_addFiles";
            this.button_addFiles.Size = new System.Drawing.Size(95, 41);
            this.button_addFiles.TabIndex = 5;
            this.button_addFiles.Text = "Add Files";
            this.button_addFiles.UseVisualStyleBackColor = true;
            this.button_addFiles.Click += new System.EventHandler(this.button_addFiles_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = ".mp3";
            this.openFileDialog.Filter = "mp3 files(*.mp3)|*.mp3|All files(*.*)|*.*";
            // 
            // label_helptext
            // 
            this.label_helptext.AutoSize = true;
            this.label_helptext.Location = new System.Drawing.Point(327, 379);
            this.label_helptext.Name = "label_helptext";
            this.label_helptext.Size = new System.Drawing.Size(321, 26);
            this.label_helptext.TabIndex = 6;
            this.label_helptext.Text = "The program automatically splits your files by the given time/frame. \r\nA new dire" +
    "ctory is added with the same name as the file.";
            // 
            // textBox_splitSize
            // 
            this.textBox_splitSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_splitSize.Location = new System.Drawing.Point(432, 347);
            this.textBox_splitSize.Name = "textBox_splitSize";
            this.textBox_splitSize.Size = new System.Drawing.Size(101, 26);
            this.textBox_splitSize.TabIndex = 7;
            this.textBox_splitSize.Text = "300";
            this.textBox_splitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Split every (seconds)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_splitSize);
            this.Controls.Add(this.label_helptext);
            this.Controls.Add(this.button_addFiles);
            this.Controls.Add(this.button_splitMP3);
            this.Controls.Add(this.label_folderContents);
            this.Controls.Add(this.listBox_folderContents);
            this.Controls.Add(this.label_chosenFolder);
            this.Controls.Add(this.button_folderDialog);
            this.Name = "Form1";
            this.Text = "Third-Split  -   Split your MP3-Files -   ThG Illusions 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button_folderDialog;
        private System.Windows.Forms.Label label_chosenFolder;
        private System.Windows.Forms.ListBox listBox_folderContents;
        private System.Windows.Forms.Label label_folderContents;
        private System.Windows.Forms.Button button_splitMP3;
        private System.Windows.Forms.Button button_addFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_helptext;
        private System.Windows.Forms.TextBox textBox_splitSize;
        private System.Windows.Forms.Label label1;
    }
}

