using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WellFlowRate
{
    public class FlowRate : IWellFlowRate
    {

        public double Height(double h, double r_w, double a)
        {
            return Math.Round(h / (r_w * Math.Sqrt(a)), 5);
        }

        public double Angle(double a, double phi)
        {
            double step1 = Math.Sqrt(a) * Math.Tan(phi);
            return (180.0 / Math.PI) * Math.Atan(step1);
        }

        public double SkinFactor(double a, double phi, double h, double r_w)
        {
            return Math.Round(-Math.Pow((Angle(a, phi) / 41.0), 2.06) - Math.Pow((Angle(a, phi) / 56.0), 1.865) * Math.Log10(Height(h, r_w, a) / 100.0), 6);
        }
        public double ProdFactor(double r_e, double r_w, double h, double a, double phi)
        {
            return Math.Round(1 / (Math.Log(r_e / r_w) + SkinFactor(a, phi, h, r_w)), 6);
        }
        public double WellFluidFlowRate(double r_e, double r_w, double h, double a, double phi, double k_h, double P_pl, double P_zab, double eta, double b_z)
        {
            return Math.Round(ProdFactor(r_e, r_w, h, a, phi) * (k_h * h * (P_pl - P_zab)) / (18.41 * eta * b_z), 6);
        }

    }
    public class Van_der_Vlis : IWellFlowRate
    {

        public double SkinFactor(double phi, double h, double r_w)
        {
            return Math.Round(-Math.Log10((h / (4 * r_w * Math.Cos(phi)) * Math.Pow((0.454 * Math.Sin(2 * Math.PI * (r_w / h))), Math.Cos(phi)))), 6);
        }
        public double ProdFactor(double r_e, double r_w, double h, double a, double phi)
        {
            return Math.Round(1 / (Math.Log(r_e / r_w) + SkinFactor(phi, h, r_w)), 6);
        }
        public double WellFluidFlowRate(double r_e, double r_w, double h, double a, double phi, double k_h, double P_pl, double P_zab, double eta, double b_z)
        {
            return Math.Round(ProdFactor(r_e, r_w, h, a, phi) * (k_h * h * (P_pl - P_zab)) / (18.41 * eta * b_z), 6);
        }
    }

}

