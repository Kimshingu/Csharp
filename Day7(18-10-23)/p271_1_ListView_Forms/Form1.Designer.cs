namespace p271_1_ListView_Forms
{
    partial class MForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv = new System.Windows.Forms.ListView();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sb = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.AllowColumnReorder = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(0, 0);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(334, 262);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.lv.Click += new System.EventHandler(this.listView1_Click);
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb});
            this.ss.Location = new System.Drawing.Point(0, 240);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(334, 22);
            this.ss.TabIndex = 1;
            this.ss.Text = "statusStrip1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            // 
            // sb
            // 
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(0, 17);
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.lv);
            this.Name = "MForm";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripStatusLabel sb;
    }
}

