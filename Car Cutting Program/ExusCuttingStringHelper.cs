using System;
using System.Text.RegularExpressions;

namespace Car_Cutting_Program
{
    public class ExusCuttingStringHelper
    {
        private string _Input { get; set; }

        public ExusCuttingStringHelper(string input)
        {
            if (input == null)
                throw new Exception("Input don't be null;");

            _Input = input;
        }

        /// <summary>
        /// ชนิดรถยนต์ (เก่ง , กะบะ)
        /// </summary>
        public string Vechicle
        {
            get
            {
                var expression = new Regex(@"VECHICLE(?<data>.*?)$");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// จังหวัดที่จดทะเบียนรถ
        /// </summary>
        public string Province
        {
            get
            {
                var expression = new Regex(@"เลขทะเบียน(.*)\d(?<data>.+?)ENGINETYPE");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                var expression2 = new Regex(@"เลขทะเบียน0(?<data>.+?)ENGINETYPE");
                var match2 = expression2.Match(_Input);
                if (match2.Success)
                {
                    var result = match2.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// เลขทะเบียนรถ ผู้กู้
        /// </summary>
        public string MiscellaneousCusipNumber
        {
            get
            {
                var expression = new Regex(@"เลขทะเบียน(?<data>.+?\d)[ก-ฮ]");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// ประเภท เครื่องยนต์ (เบนซิน ดีเซล)
        /// </summary>
        public string EnginType
        {
            get
            {
                var expression = new Regex(@"ENGINETYPE(?<data>.+?)ENGINETYPE2");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// ประเภท เครื่องยนต์ (เบนซิน ดีเซล) พี่เอิงบอกว่า ในตอนออก CA ให้มาเช็ค EnginType(ธรรมดาก่อน) ถ้าไม่มีให้มาเอา EnginType2
        /// </summary>
        public string EnginType2
        {
            get
            {
                var expression = new Regex(@"ENGINETYPE2(?<data>.+?)NEW");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// หลักประกันประเภท นส3  นส3ก  นส3ข
        /// </summary>
        public string CollateralType
        {
            get
            {
                if (_Input.IndexOf("นส.3ก") != -1)
                    return "นส.3ก";
                if (_Input.IndexOf("นส.3ข") != -1)
                    return "นส.3ข";
                if (_Input.IndexOf("นส.3") != -1)
                    return "นส.3";

                return "";
            }
        }

        /// <summary>
        /// เลขที่โฉนดที่เกี่ยวข้องทุกวงเงิน
        /// </summary>
        public string DeedNo
        {
            get
            {
                // โฉนดเลขที่123456789465456,
                // โฉนดเลขที่123123,123123,123123213,12321กก
                // var expression = new Regex(@"โฉนดเลขที่(?<data>.*?)[^\d]");
                // var expression = new Regex(@"โฉนดเลขที่(?<data>.*?)$");
                var expression = new Regex(@"โฉนดเลขที่(?<data>.*?)([^0-9,]|$)");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }

        /// <summary>
        /// เลขที่เงินฝากที่อ้างอิงกับสัญญาทุกวงเงิน
        /// </summary>
        public string AccountNo
        {
            get
            {
                var expression = new Regex(@"เลขที่บัญชี(?<data>.+?)([^\d]|$)");
                var match = expression.Match(_Input);
                if (match.Success)
                {
                    var result = match.Groups["data"].Value;
                    return result;
                }

                return "";
            }
        }
    }
}