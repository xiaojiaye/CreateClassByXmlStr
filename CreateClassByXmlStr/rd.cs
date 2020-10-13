using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CreateClassByXmlStr
{
    [XmlRootAttribute("rd")]
    public class rd
    {
        [XmlElementAttribute("iSeqno")]
        public string iSeqno { get; set; }
        [XmlElementAttribute("OrderNo")]
        public string OrderNo { get; set; }
        [XmlElementAttribute("ReimburseNo")]
        public string ReimburseNo { get; set; }
        [XmlElementAttribute("ReimburseNum")]
        public string ReimburseNum { get; set; }
        [XmlElementAttribute("StartDate")]
        public string StartDate { get; set; }
        [XmlElementAttribute("StartTime")]
        public string StartTime { get; set; }
        [XmlElementAttribute("PayType")]
        public string PayType { get; set; }
        [XmlElementAttribute("PayAccNo")]
        public string PayAccNo { get; set; }
        [XmlElementAttribute("PayAccNameCN")]
        public string PayAccNameCN { get; set; }
        [XmlElementAttribute("PayAccNameEN")]
        public string PayAccNameEN { get; set; }
        [XmlElementAttribute("RecAccNo")]
        public string RecAccNo { get; set; }
        [XmlElementAttribute("RecAccNameCN")]
        public string RecAccNameCN { get; set; }
        [XmlElementAttribute("RecAccNameEN")]
        public string RecAccNameEN { get; set; }
        [XmlElementAttribute("SysIOFlg")]
        public string SysIOFlg { get; set; }
        [XmlElementAttribute("IsSameCity")]
        public string IsSameCity { get; set; }
        [XmlElementAttribute("Prop")]
        public string Prop { get; set; }
        [XmlElementAttribute("RecICBCCode")]
        public string RecICBCCode { get; set; }
        [XmlElementAttribute("RecCityName")]
        public string RecCityName { get; set; }
        [XmlElementAttribute("RecBankNo")]
        public string RecBankNo { get; set; }
        [XmlElementAttribute("RecBankName")]
        public string RecBankName { get; set; }
        [XmlElementAttribute("CurrType")]
        public string CurrType { get; set; }
        [XmlElementAttribute("PayAmt")]
        public string PayAmt { get; set; }
        [XmlElementAttribute("UseCode")]
        public string UseCode { get; set; }
        [XmlElementAttribute("UseCN")]
        public string UseCN { get; set; }
        [XmlElementAttribute("EnSummary")]
        public string EnSummary { get; set; }
        [XmlElementAttribute("PostScript")]
        public string PostScript { get; set; }
        [XmlElementAttribute("Summary")]
        public string Summary { get; set; }
        [XmlElementAttribute("Ref")]
        public string Ref { get; set; }
        [XmlElementAttribute("Oref")]
        public string Oref { get; set; }
        [XmlElementAttribute("ERPSqn")]
        public string ERPSqn { get; set; }
        [XmlElementAttribute("BusCode")]
        public string BusCode { get; set; }
        [XmlElementAttribute("ERPcheckno")]
        public string ERPcheckno { get; set; }
        [XmlElementAttribute("CrvouhType")]
        public string CrvouhType { get; set; }
        [XmlElementAttribute("CrvouhName")]
        public string CrvouhName { get; set; }
        [XmlElementAttribute("CrvouhNo")]
        public string CrvouhNo { get; set; }
        [XmlElementAttribute("BankType")]
        public string BankType { get; set; }
        [XmlElementAttribute("FileNames")]
        public string FileNames { get; set; }
        [XmlElementAttribute("Indexs")]
        public string Indexs { get; set; }
        [XmlElementAttribute("PaySubNo")]
        public string PaySubNo { get; set; }
        [XmlElementAttribute("RecSubNo")]
        public string RecSubNo { get; set; }
        [XmlElementAttribute("Result")]
        public string Result { get; set; }
        [XmlElementAttribute("iRetCode")]
        public string iRetCode { get; set; }
        [XmlElementAttribute("iRetMsg")]
        public string iRetMsg { get; set; }
        [XmlElementAttribute("MCardNo")]
        public string MCardNo { get; set; }
        [XmlElementAttribute("MCardName")]
        public string MCardName { get; set; }
    }
}
