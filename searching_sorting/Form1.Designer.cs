namespace searching_sorting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Find = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manualInput = new System.Windows.Forms.CheckBox();
            this.arrayIndex = new System.Windows.Forms.TextBox();
            this.filters = new System.Windows.Forms.Label();
            this.arraySize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.manualArray = new System.Windows.Forms.TextBox();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.largest = new System.Windows.Forms.CheckBox();
            this.minimum = new System.Windows.Forms.CheckBox();
            this.useInput = new System.Windows.Forms.CheckBox();
            this.useManual = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.BackgroundImage = global::searching_sorting.Properties.Resources.IMG_20170107_WA0011;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.useManual);
            this.splitContainer1.Panel1.Controls.Add(this.useInput);
            this.splitContainer1.Panel1.Controls.Add(this.minimum);
            this.splitContainer1.Panel1.Controls.Add(this.largest);
            this.splitContainer1.Panel1.Controls.Add(this.Find);
            this.splitContainer1.Panel1.Controls.Add(this.value);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.manualInput);
            this.splitContainer1.Panel1.Controls.Add(this.arrayIndex);
            this.splitContainer1.Panel1.Controls.Add(this.filters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::searching_sorting.Properties.Resources.IMG_20170107_WA0009;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.arraySize);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.done);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.manualArray);
            this.splitContainer1.Panel2.Controls.Add(this.arrayBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.selectedFileName);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(693, 484);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 8;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.Brown;
            this.Find.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.ForeColor = System.Drawing.Color.Black;
            this.Find.Location = new System.Drawing.Point(12, 68);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(112, 31);
            this.Find.TabIndex = 20;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.BackColor = System.Drawing.Color.Transparent;
            this.value.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.Color.Black;
            this.value.Location = new System.Drawing.Point(15, 303);
            this.value.MaximumSize = new System.Drawing.Size(1000, 100);
            this.value.Name = "value";
            this.value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.value.Size = new System.Drawing.Size(60, 24);
            this.value.TabIndex = 500;
            this.value.Text = "value";
            this.value.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "The selected value is:";
            // 
            // manualInput
            // 
            this.manualInput.Appearance = System.Windows.Forms.Appearance.Button;
            this.manualInput.AutoSize = true;
            this.manualInput.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.manualInput.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.manualInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.manualInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.manualInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manualInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.manualInput.Location = new System.Drawing.Point(12, 168);
            this.manualInput.Name = "manualInput";
            this.manualInput.Size = new System.Drawing.Size(112, 23);
            this.manualInput.TabIndex = 17;
            this.manualInput.Text = "Enter array manually";
            this.manualInput.UseVisualStyleBackColor = true;
            this.manualInput.CheckedChanged += new System.EventHandler(this.manualInput_CheckedChanged);
            // 
            // arrayIndex
            // 
            this.arrayIndex.ForeColor = System.Drawing.Color.Red;
            this.arrayIndex.Location = new System.Drawing.Point(12, 42);
            this.arrayIndex.Name = "arrayIndex";
            this.arrayIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arrayIndex.Size = new System.Drawing.Size(157, 20);
            this.arrayIndex.TabIndex = 16;
            this.arrayIndex.Tag = "";
            this.arrayIndex.Text = "Enter the index of the array";
            // 
            // filters
            // 
            this.filters.AutoSize = true;
            this.filters.BackColor = System.Drawing.Color.Transparent;
            this.filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.filters.Location = new System.Drawing.Point(12, 26);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(45, 13);
            this.filters.TabIndex = 15;
            this.filters.Text = "Filters:";
            // 
            // arraySize
            // 
            this.arraySize.AutoSize = true;
            this.arraySize.BackColor = System.Drawing.Color.Transparent;
            this.arraySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arraySize.ForeColor = System.Drawing.Color.White;
            this.arraySize.Location = new System.Drawing.Point(401, 279);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(57, 20);
            this.arraySize.TabIndex = 17;
            this.arraySize.Text = "label6";
            this.arraySize.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(279, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Array size is: ";
            this.label5.Visible = false;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.Maroon;
            this.done.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.Black;
            this.done.Location = new System.Drawing.Point(279, 420);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(103, 37);
            this.done.TabIndex = 15;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Visible = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Separate inputs with whitesapce:";
            this.label3.Visible = false;
            // 
            // manualArray
            // 
            this.manualArray.ForeColor = System.Drawing.Color.Red;
            this.manualArray.Location = new System.Drawing.Point(6, 330);
            this.manualArray.Multiline = true;
            this.manualArray.Name = "manualArray";
            this.manualArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.manualArray.Size = new System.Drawing.Size(266, 167);
            this.manualArray.TabIndex = 13;
            this.manualArray.Visible = false;
            // 
            // arrayBox
            // 
            this.arrayBox.ForeColor = System.Drawing.Color.Red;
            this.arrayBox.Location = new System.Drawing.Point(3, 110);
            this.arrayBox.Multiline = true;
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.arrayBox.Size = new System.Drawing.Size(269, 183);
            this.arrayBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Set of Array:";
            // 
            // selectedFileName
            // 
            this.selectedFileName.AutoSize = true;
            this.selectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.selectedFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFileName.ForeColor = System.Drawing.Color.White;
            this.selectedFileName.Location = new System.Drawing.Point(195, 61);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(122, 17);
            this.selectedFileName.TabIndex = 10;
            this.selectedFileName.Text = "selected file name";
            this.selectedFileName.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "This program helps to loop through an array\r\n according to user filter and gives " +
    "a particular value";
            // 
            // largest
            // 
            this.largest.Appearance = System.Windows.Forms.Appearance.Button;
            this.largest.AutoSize = true;
            this.largest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.largest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.largest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.largest.Location = new System.Drawing.Point(12, 139);
            this.largest.Name = "largest";
            this.largest.Size = new System.Drawing.Size(173, 23);
            this.largest.TabIndex = 21;
            this.largest.Text = "Find the largest value in the array";
            this.largest.UseVisualStyleBackColor = true;
            this.largest.CheckedChanged += new System.EventHandler(this.largest_CheckedChanged);
            // 
            // minimum
            // 
            this.minimum.Appearance = System.Windows.Forms.Appearance.Button;
            this.minimum.AutoSize = true;
            this.minimum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minimum.Location = new System.Drawing.Point(12, 110);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(179, 23);
            this.minimum.TabIndex = 22;
            this.minimum.Text = "Find the smallest value in the array";
            this.minimum.UseVisualStyleBackColor = true;
            this.minimum.CheckedChanged += new System.EventHandler(this.minimum_CheckedChanged);
            // 
            // useInput
            // 
            this.useInput.Appearance = System.Windows.Forms.Appearance.Button;
            this.useInput.AutoSize = true;
            this.useInput.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.useInput.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.useInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.useInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.useInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.useInput.Location = new System.Drawing.Point(12, 226);
            this.useInput.Name = "useInput";
            this.useInput.Size = new System.Drawing.Size(109, 23);
            this.useInput.TabIndex = 501;
            this.useInput.Text = "Use Input File Array";
            this.useInput.UseVisualStyleBackColor = true;
            this.useInput.CheckedChanged += new System.EventHandler(this.useInput_CheckedChanged);
            // 
            // useManual
            // 
            this.useManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.useManual.AutoSize = true;
            this.useManual.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.useManual.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.useManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.useManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.useManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.useManual.Location = new System.Drawing.Point(12, 197);
            this.useManual.Name = "useManual";
            this.useManual.Size = new System.Drawing.Size(101, 23);
            this.useManual.TabIndex = 502;
            this.useManual.Text = "Use Manual Array";
            this.useManual.UseVisualStyleBackColor = true;
            this.useManual.CheckedChanged += new System.EventHandler(this.useManual_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 484);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GDG UNN SEARCH AND SORT";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox manualInput;
        private System.Windows.Forms.TextBox arrayIndex;
        private System.Windows.Forms.Label filters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox manualArray;
        private System.Windows.Forms.TextBox arrayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label arraySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox largest;
        private System.Windows.Forms.CheckBox minimum;
        private System.Windows.Forms.CheckBox useManual;
        private System.Windows.Forms.CheckBox useInput;
    }
}

