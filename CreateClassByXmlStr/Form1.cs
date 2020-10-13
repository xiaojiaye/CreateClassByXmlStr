using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CreateClassByXmlStr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int nodeCount = 0;
            string[] classDivArray = null;
            this.rtxtStrAfterConvert.Text = "";
            string strSourceXml = this.rtxtXmlSourceStr.Text.Trim().Replace("\n", "").Replace("\t", "").Replace("\r", "").Replace(" ",""); ;
            this.rtxtXmlSourceStr.Text = strSourceXml;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(strSourceXml);
                //取到所有的xml结点
                XmlNodeList nodelist = xmlDoc.GetElementsByTagName("*");
                nodeCount = nodelist.Count;  // xml的标签个数
                classDivArray = new string[nodeCount];
                for (int i = 0; i < nodeCount; i++)
                {
                    classDivArray[i] = nodelist[i].Name.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("载入XML原文转换时发生异常，异常原因是："+ex.Message);
                return;
            }                      
            //foreach (XmlElement xmlElement in nodelist)
            //{
            //    this.rtxtStrAfterConvert.Text = this.rtxtStrAfterConvert.Text + xmlElement.Name.ToString() + "\r\n";
            //}
            // 取得类名称
            string strClassName = classDivArray[0];
            string strClassHeader = string.Empty;
            string strSerializationHeader = string.Empty;
            string strClassBody = string.Empty;
            string strPubOrPriv = string.Empty;
            StringBuilder sbTemp = new StringBuilder();
            // 定义类的访问属性public\private 
            if (this.radPublic.Checked)
            {
                strClassHeader = "public class " + strClassName + "\r\n" + "{" + "\r\n";
                strPubOrPriv = "public";
            }
            else if (this.radPrivate.Checked)
            {
                strClassHeader = "private class " + strClassName + "\r\n" + "{" + "\r\n";
                strPubOrPriv = "private";
            }
            // 判断是否需要序列化
            if (this.cboxIsSerializationClass.Checked)
            {
                strSerializationHeader = "[XmlRootAttribute(\"" + strClassName + "\")]" + "\r\n";
                for (int i = 1; i < nodeCount; i++)
                {
                    sbTemp.Append("[XmlElementAttribute(\"" + classDivArray[i] + "\")]" + "\r\n");
                    sbTemp.Append(strPubOrPriv + " string " + classDivArray[i] + "{ get; set; }" + "\r\n");
                }
                strClassBody = strSerializationHeader + strClassHeader + sbTemp.ToString() + "}";
            }
            else
            {
                for (int i = 1; i < nodeCount; i++)
                {
                    sbTemp.Append(strPubOrPriv + " string " + classDivArray[i] + "{ get; set; }" + "\r\n");
                }
                strClassBody = strClassHeader + sbTemp.ToString() + "}";
            }
            this.rtxtStrAfterConvert.Text = strClassBody;
        }
    }
}
