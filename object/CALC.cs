using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public class CALC
    {
        private double gross_pay { get; set; }
        public CALC(double gross_pay)
        {
            this.gross_pay = gross_pay;
        }

        public double cSocso(SocsoType st)
        {
            for (int i = 0; i < NUM_LIST.Length; i++)
            {
                // Handle first & last
                if (i ==  NUM_LIST.Length)
                {
                    return st == SocsoType.BOSS ? BOSS_SOCSO[i] : EMPLOYEE_SOCSO[i];
                }
                else if (i == 0)
                {
                    if ( gross_pay.CompareTo(NUM_LIST[i]) == -1)
                    {
                        return st == SocsoType.BOSS ? BOSS_SOCSO[i] : EMPLOYEE_SOCSO[i];
                    }
                }

                // .CompareTo(value)  0 == equals to , 1 == bigger than , - 1 smaller than
                else if (gross_pay.CompareTo(NUM_LIST[i - 1]) >= 0 && gross_pay.CompareTo(NUM_LIST[i]) == -1)
                {
                    return st == SocsoType.BOSS ? BOSS_SOCSO[i] : EMPLOYEE_SOCSO[i];
                }
            }
            return 0.0;
        }

        public double cEIS()
        {
            for (int i = 0; i < NUM_LIST.Length; i++)
            {
                if (i == NUM_LIST.Length)
                {
                    return EIS[i];
                }
                else if (i == 0)
                {
                    if (gross_pay.CompareTo(NUM_LIST[i]) == -1)
                    {
                        return EIS[i];
                    }
                }
                
                else if (gross_pay.CompareTo(NUM_LIST[i - 1]) >= 0 && gross_pay.CompareTo(NUM_LIST[i]) == -1)
                {
                    return EIS[i];
                }
            }
            return 0.0;
        }

        // > Item1 && <= Item2

        private int[] NUM_LIST = new int[]
        {
            30, 50, 70,
            100, 140, 200,
            300, 400, 500,
            600, 700, 800,
            900, 1000, 1100,
            1200, 1300, 1400,
            1500, 1600, 1700,
            1800, 1900, 2000,
            2100, 2200, 2300,
            2400, 2500, 2600,
            2700, 2800, 2900,
            3000, 3100, 3200,
            3300, 3400, 3500,
            3600, 3700, 3800,
            3900, 4000
        };

        private double[] EIS = new double[]
        {
            0.05, 0.1, 0.15,
            0.2, 0.25, 0.35,
            0.5, 0.7, 0.9,
            1.1, 1.3, 1.5,
            1.7, 1.9, 2.1,
            2.3, 2.5, 2.7,
            2.9, 3.1, 3.3,
            3.5, 3.7, 3.9,
            4.1, 4.3, 4.5,
            4.7, 4.9, 5.1,
            5.3, 5.5, 5.7,
            5.9, 6.1, 6.3,
            6.5, 6.7, 6.9,
            7.1, 7.3, 7.5,
            7.7, 7.9
        };

        private double[] BOSS_SOCSO = new double[]
        {
            0.4, 0.7, 1.1,
            1.5, 2.1, 2.95,
            4.35, 6.15, 7.85,
            9.65, 11.35, 13.15,
            14.85, 16.65, 18.35,
            20.15, 21.85, 23.65,
            25.35, 27.15, 28.85,
            30.65, 32.35, 34.15,
            35.85, 37.65, 39.35,
            41.15, 42.85, 44.65,
            46.35, 48.15, 49.85,
            51.65, 53.35, 55.15,
            56.85, 58.65, 60.35,
            62.15, 63.85, 65.65,
            67.35, 69.05
        };

        private double[] EMPLOYEE_SOCSO = new double[]
        {
            0.1, 0.2, 0.3,
            0.4, 0.6, 0.85,
            1.25, 1.75, 2.25,
            2.75, 3.25, 3.75,
            4.25, 4.75, 5.25,
            5.75, 6.25, 6.75,
            7.25, 7.75, 8.25,
            8.75, 9.25, 9.75,
            10.25, 10.75, 11.25,
            11.75, 12.25, 12.75,
            13.25, 13.75, 14.25,
            14.75, 15.25, 15.75,
            16.25, 16.75, 17.25,
            17.75, 18.25, 18.75,
            19.25, 19.75
        };
    }
}
