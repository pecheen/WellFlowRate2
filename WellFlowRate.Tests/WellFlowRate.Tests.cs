using NUnit.Framework;

namespace WellFlowRate.Tests
{
    public class Tests
    {
        private double delta = 0.0001;

        [Test]
        public void Height_commoninput_expectedResultreturned()
        {
            //arrange
            double h = 18.0;
            double r_w = 0.1;
            double a = 0.001;
            double expected = 5692.09979;

            //act
            FlowRate c = new FlowRate();
            double actual = c.Height(h, r_w, a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Angle_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double expected = 1.04595682254258;

            //act
            FlowRate c = new FlowRate();
            double actual = c.Angle(a, phi);

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
        [Test]
        public void SkinFactor_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double expected = -0.001570;

            //act
            FlowRate c = new FlowRate();
            double actual = c.SkinFactor(a, phi, h, r_w);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ProdFactor_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double r_e = 300.0;
            double expected = 0.124925;

            //act
            FlowRate c = new FlowRate();
            double actual = c.ProdFactor(r_e, r_w, h, a, phi);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void WellFluidFlowRate_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double r_e = 300.0;
            double k_h = 1000.0;
            double P_pl = 150.0;
            double P_zab = 50.0;
            double eta = 100.0;
            double b_z = 1.0;
            double expected = 122.142942;

            //act
            FlowRate c = new FlowRate();
            double actual = c.WellFluidFlowRate(r_e, r_w, h, a, phi, k_h, P_pl, P_zab, eta, b_z);

            //assert
            Assert.AreEqual(expected, actual, delta);


        }
    }
    public class Tests1
    {
        private double delta = 0.0001;
        [Test]
        public void SkinFactor_commoninput_expectedResultreturned()
        {
            //arrange
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double expected = -0.15672;

            //act
            Van_der_Vlis d = new Van_der_Vlis();
            double actual = d.SkinFactor(phi, h, r_w);

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
        [Test]
        public void ProdFactor_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double r_e = 300.0;
            double expected = 0.127394;

            //act
            Van_der_Vlis d = new Van_der_Vlis();
            double actual = d.ProdFactor(r_e, r_w, h, a, phi);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void WellFluidFlowRate_commoninput_expectedResultreturned()
        {
            //arrange
            double a = 0.001;
            double phi = 0.523599;
            double h = 18.0;
            double r_w = 0.1;
            double r_e = 300.0;
            double k_h = 1000.0;
            double P_pl = 150.0;
            double P_zab = 50.0;
            double eta = 100.0;
            double b_z = 1.0;
            double expected = 124.5569;

            //act
            Van_der_Vlis d = new Van_der_Vlis();
            double actual = d.WellFluidFlowRate(r_e, r_w, h, a, phi, k_h, P_pl, P_zab, eta, b_z);

            //assert
            Assert.AreEqual(expected, actual, delta);


        }

    }
}