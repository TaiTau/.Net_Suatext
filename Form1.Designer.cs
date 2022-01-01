
namespace Tesseract
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListLineImage = new System.Windows.Forms.ListBox();
            this.ListImagePass = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thư mục chứa các ảnh 1 dòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách ảnh đã sửa";
            this.label2.Enter += new System.EventHandler(this.label2_Enter);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(330, 58);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(54, 23);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Mở";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(390, 297);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 3;
            this.btChange.Text = "<<";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(858, 85);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 31);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ptb1
            // 
            this.ptb1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptb1.ErrorImage")));
            this.ptb1.Location = new System.Drawing.Point(30, 564);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(795, 56);
            this.ptb1.TabIndex = 7;
            this.ptb1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ảnh 1 dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 673);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(795, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListLineImage
            // 
            this.ListLineImage.FormattingEnabled = true;
            this.ListLineImage.Location = new System.Drawing.Point(30, 85);
            this.ListLineImage.Name = "ListLineImage";
            this.ListLineImage.Size = new System.Drawing.Size(354, 446);
            this.ListLineImage.TabIndex = 11;
            this.ListLineImage.Click += new System.EventHandler(this.listBox1_Click);
            this.ListLineImage.SelectedIndexChanged += new System.EventHandler(this.ListLineImage_SelectedIndexChanged);
            // 
            // ListImagePass
            // 
            this.ListImagePass.FormattingEnabled = true;
            this.ListImagePass.Location = new System.Drawing.Point(471, 85);
            this.ListImagePass.Name = "ListImagePass";
            this.ListImagePass.Size = new System.Drawing.Size(354, 446);
            this.ListImagePass.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(858, 129);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(87, 33);
            this.btDel.TabIndex = 14;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 736);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.ListImagePass);
            this.Controls.Add(this.ListLineImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chỉnh sửa kết quả tesseract";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox ListLineImage;
        private System.Windows.Forms.ListBox ListImagePass;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btDel;
    }
}

