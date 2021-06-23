using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WellFlowRate
{
    interface IWellFlowRate
    {
        double ProdFactor(double r_e, double r_w, double h, double a, double phi);

        double WellFluidFlowRate(double r_e, double r_w, double h, double a, double phi, double k_h, double P_pl, double P_zab, double eta, double b_z);
    }
}
    
