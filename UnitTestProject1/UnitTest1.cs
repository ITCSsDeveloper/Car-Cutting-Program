using Car_Cutting_Program;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string Account_1 = "เลขที่บัญชี40000000000";

        private string Assest_1 = "เลขทะเบียน0กก0000กรุงเทพมหานครENGINETYPEDIESELENGINETYPE2เครื่องยนต์ดีเซลNEW/USEDรถใช้แล้วCAR4WDไม่ใช่VECHICLEรถเก๋ง";
        private string Assest_2 = "เลขทะเบียน0กรุงเทพมหานครENGINETYPEDIESELENGINETYPE2-NEW/USEDรถใช้แล้วCAR4WDไม่ใช่VECHICLEรถเก๋ง";


        private string Assest_3 = "นส.3กเลขที่2222";
        private string Assest_4 = "นส.3ขเลขที่2222";
        private string Assest_5 = "นส.3เลขที่2222";
        private string Assest_6 = "นส.3 นส.3ข นส.3ก เลขที่2222";

        private string Assest_7 = "โฉนดเลขที่77777";
        private string Assest_8 = "โฉนดเลขที่xxxxx";



        [TestMethod]
        public void Vechicle()
        {
            var ex = new ExusCuttingStringHelper(Assest_1);
            var actual = ex.Vechicle;
            Assert.AreEqual("รถเก๋ง", actual);
        }

        [TestMethod]
        public void Province()
        {
            {
                var ex = new ExusCuttingStringHelper(Assest_2);
                var actual = ex.Province;
                Assert.AreEqual("กรุงเทพมหานคร", actual);
            }

            {
                var ex = new ExusCuttingStringHelper(Assest_1);
                var actual = ex.Province;
                Assert.AreEqual("กรุงเทพมหานคร", actual);
            }
        }

        [TestMethod]
        public void CusipNumber()
        {
            var ex = new ExusCuttingStringHelper(Assest_1);
            var actual = ex.MiscellaneousCusipNumber;
            Assert.AreEqual("0กก0000", actual);
        }

        [TestMethod]
        public void EnginType()
        {
            var ex = new ExusCuttingStringHelper(Assest_1);
            var actual = ex.EnginType;
            Assert.AreEqual("DIESEL", actual);
        }

        [TestMethod]
        public void EnginType2()
        {
            {
                var ex = new ExusCuttingStringHelper(Assest_1);
                var actual = ex.EnginType2;
                Assert.AreEqual("เครื่องยนต์ดีเซล", actual);
            }

            {
                var ex = new ExusCuttingStringHelper(Assest_2);
                var actual = ex.EnginType2;
                Assert.AreEqual("-", actual);
            }

        }

        [TestMethod]
        public void CollateralType_นส3ก()
        {
            {
                var ex = new ExusCuttingStringHelper(Assest_3);
                var actual = ex.CollateralType;
                Assert.AreEqual("นส.3ก", actual);
            }
            {
                var ex = new ExusCuttingStringHelper(Assest_6);
                var actual = ex.CollateralType;
                Assert.AreEqual("นส.3ก", actual);
            }
        }

        [TestMethod]
        public void CollateralType_นส3ข()
        {
            var ex = new ExusCuttingStringHelper(Assest_4);
            var actual = ex.CollateralType;
            Assert.AreEqual("นส.3ข", actual);
        }

        [TestMethod]
        public void CollateralType_นส3()
        {
            var ex = new ExusCuttingStringHelper(Assest_5);
            var actual = ex.CollateralType;
            Assert.AreEqual("นส.3", actual);
        }

        [TestMethod]
        public void DeedNo()
        {
            {
                var ex = new ExusCuttingStringHelper(Assest_7);
                var actual = ex.DeedNo;
                Assert.AreEqual("77777", actual);
            }
            {
                var ex = new ExusCuttingStringHelper(Assest_8);
                var actual = ex.DeedNo;
                Assert.AreEqual("", actual);
            }
        }

        [TestMethod]
        public void AccountNo()
        {
            var ex = new ExusCuttingStringHelper(Account_1);
            var actual = ex.AccountNo;
            Assert.AreEqual("40000000000", actual);

        }
    }
    }
