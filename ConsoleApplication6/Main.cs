using System;
using System.Collections.Generic;
using System.Text;

namespace WellFlowRate
{
    class Programm1
    {
        static void Main()
        {
            double h = 18.0;
            double r_w = 0.1;
            double a = 0.001;
            double phi = 0.523599;
            double r_e = 300.0;
            double k_h = 1000.0;
            double P_pl = 150.0;
            double P_zab = 50.0;
            double eta = 100.0;
            double b_z = 1.0;
            
            FlowRate c = new FlowRate();
            Console.Write($"Cinco S =  {c.SkinFactor(a, phi, h, r_w)} Q = {c.WellFluidFlowRate(r_e, r_w, h, a, phi, k_h, P_pl, P_zab, eta, b_z)}");
            Console.Write("\n");
            Van_der_Vlis d = new Van_der_Vlis();
            Console.Write($"Van der Vlis S =  {d.SkinFactor(phi, h, r_w)} Q = {d.WellFluidFlowRate(r_e, r_w, h, a, phi, k_h, P_pl, P_zab, eta, b_z)}");

            Console.ReadKey();
        }

    }
}
