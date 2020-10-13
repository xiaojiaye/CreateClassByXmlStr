namespace CreateClassByXmlStr
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxXmlSourceStr = new System.Windows.Forms.GroupBox();
            this.gBoxStrAfterConvert = new System.Windows.Forms.GroupBox();
            this.rtxtXmlSourceStr = new System.Windows.Forms.RichTextBox();
            this.rtxtStrAfterConvert = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gBoxPublicOrPrivate = new System.Windows.Forms.GroupBox();
            this.radPublic = new System.Windows.Forms.RadioButton();
            this.radPrivate = new System.Windows.Forms.RadioButton();
            this.cboxIsSerializationClass = new System.Windows.Forms.CheckBox();
            this.gBoxXmlSourceStr.SuspendLayout();
            this.gBoxStrAfterConvert.SuspendLayout();
            this.gBoxPublicOrPrivate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxXmlSourceStr
            // 
            this.gBoxXmlSourceStr.Controls.Add(this.rtxtXmlSourceStr);
            this.gBoxXmlSourceStr.Location = new System.Drawing.Point(12, 12);
            this.gBoxXmlSourceStr.Name = "gBoxXmlSourceStr";
            this.gBoxXmlSourceStr.Size = new System.Drawing.Size(450, 605);
            this.gBoxXmlSourceStr.TabIndex = 0;
            this.gBoxXmlSourceStr.TabStop = false;
            this.gBoxXmlSourceStr.Text = "XML源文";
            // 
            // gBoxStrAfterConvert
            // 
            this.gBoxStrAfterConvert.Controls.Add(this.rtxtStrAfterConvert);
            this.gBoxStrAfterConvert.Location = new System.Drawing.Point(610, 12);
            this.gBoxStrAfterConvert.Name = "gBoxStrAfterConvert";
            this.gBoxStrAfterConvert.Size = new System.Drawing.Size(514, 605);
            this.gBoxStrAfterConvert.TabIndex = 1;
            this.gBoxStrAfterConvert.TabStop = false;
            this.gBoxStrAfterConvert.Text = "转换后的";
            // 
            // rtxtXmlSourceStr
            // 
            this.rtxtXmlSourceStr.Location = new System.Drawing.Point(6, 14);
            this.rtxtXmlSourceStr.Name = "rtxtXmlSourceStr";
            this.rtxtXmlSourceStr.Size = new System.Drawing.Size(434, 585);
            this.rtxtXmlSourceStr.TabIndex = 0;
            this.rtxtXmlSourceStr.Text = "";
            // 
            // rtxtStrAfterConvert
            // 
            this.rtxtStrAfterConvert.Location = new System.Drawing.Point(3, 14);
            this.rtxtStrAfterConvert.Name = "rtxtStrAfterConvert";
            this.rtxtStrAfterConvert.Size = new System.Drawing.Size(505, 585);
            this.rtxtStrAfterConvert.TabIndex = 0;
            this.rtxtStrAfterConvert.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(494, 459);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "开始转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // gBoxPublicOrPrivate
            // 
            this.gBoxPublicOrPrivate.Controls.Add(this.radPrivate);
            this.gBoxPublicOrPrivate.Controls.Add(this.radPublic);
            this.gBoxPublicOrPrivate.Location = new System.Drawing.Point(473, 12);
            this.gBoxPublicOrPrivate.Name = "gBoxPublicOrPrivate";
            this.gBoxPublicOrPrivate.Size = new System.Drawing.Size(124, 69);
            this.gBoxPublicOrPrivate.TabIndex = 3;
            this.gBoxPublicOrPrivate.TabStop = false;
            this.gBoxPublicOrPrivate.Text = "公有还是私有";
            // 
            // radPublic
            // 
            this.radPublic.AutoSize = true;
            this.radPublic.Checked = true;
            this.radPublic.Location = new System.Drawing.Point(15, 20);
            this.radPublic.Name = "radPublic";
            this.radPublic.Size = new System.Drawing.Size(83, 16);
            this.radPublic.TabIndex = 0;
            this.radPublic.TabStop = true;
            this.radPublic.Text = "public类型";
            this.radPublic.UseVisualStyleBackColor = true;
            // 
            // radPrivate
            // 
            this.radPrivate.AutoSize = true;
            this.radPrivate.Location = new System.Drawing.Point(15, 42);
            this.radPrivate.Name = "radPrivate";
            this.radPrivate.Size = new System.Drawing.Size(89, 16);
            this.radPrivate.TabIndex = 1;
            this.radPrivate.Text = "private类型";
            this.radPrivate.UseVisualStyleBackColor = true;
            // 
            // cboxIsSerializationClass
            // 
            this.cboxIsSerializationClass.AutoSize = true;
            this.cboxIsSerializationClass.Location = new System.Drawing.Point(473, 102);
            this.cboxIsSerializationClass.Name = "cboxIsSerializationClass";
            this.cboxIsSerializationClass.Size = new System.Drawing.Size(126, 16);
            this.cboxIsSerializationClass.TabIndex = 4;
            this.cboxIsSerializationClass.Text = "是否需要Xml序列化";
            this.cboxIsSerializationClass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 629);
            this.Controls.Add(this.cboxIsSerializationClass);
            this.Controls.Add(this.gBoxPublicOrPrivate);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gBoxStrAfterConvert);
            this.Controls.Add(this.gBoxXmlSourceStr);
            this.Name = "Form1";
            this.Text = "根据XML生成实体类";
            this.gBoxXmlSourceStr.ResumeLayout(false);
            this.gBoxStrAfterConvert.ResumeLayout(false);
            this.gBoxPublicOrPrivate.ResumeLayout(false);
            this.gBoxPublicOrPrivate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxXmlSourceStr;
        private System.Windows.Forms.RichTextBox rtxtXmlSourceStr;
        private System.Windows.Forms.GroupBox gBoxStrAfterConvert;
        private System.Windows.Forms.RichTextBox rtxtStrAfterConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox gBoxPublicOrPrivate;
        private System.Windows.Forms.RadioButton radPrivate;
        private System.Windows.Forms.RadioButton radPublic;
        private System.Windows.Forms.CheckBox cboxIsSerializationClass;
    }
}

