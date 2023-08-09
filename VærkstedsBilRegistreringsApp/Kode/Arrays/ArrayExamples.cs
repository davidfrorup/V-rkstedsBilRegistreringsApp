using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VærkstedsBilRegistreringsApp.Kode.Arrays;

internal class ArrayExamples
{

    public void SetSimpleArray()
    {
        string[] bilmærker = new string[] { "Fiat", "Toyota", "Kia" };
        // double[] mitTal = new double[] { 0.1, 0.2, 0.3 };
        //string[] bilmærker = new string[4];
        //bilmærker[0] = "Fiat";
        //bilmærker[1] = "Toyota";
        //bilmærker[2] = "Kia";

        Console.WriteLine(bilmærker[1]);

        foreach(string item in bilmærker)
        {
            Console.WriteLine(item);
        }

        // List
        List<string> lstBilmærker = new List<string>() { "Fiat", "Toyota", "Kia" };
        Console.WriteLine(lstBilmærker[1]);

        foreach (string item in lstBilmærker)
        {
            Console.WriteLine(item);
        }



    }





    public void SetObjectArray()
    {
        object[] fiatPunto = new object[] { "Fiat Punto", new DateTime(2010, 1, 1), "Udstødning" };
        object[] alfaRomeo = new object[] { "AlfaRomeo Giulia", new DateTime(2019, 8, 1), "Styrtøj" };

        object[] tilbagekaldteBiler = new object[] { fiatPunto, alfaRomeo };

        object[] minalfaudtræk = (object[])tilbagekaldteBiler[1];
        DateTime alfaromeoÅrgang = (DateTime)minalfaudtræk[1];

        string mdrNavn = alfaromeoÅrgang.ToString("MMMM");

        Console.WriteLine(mdrNavn);


        foreach (object arry in tilbagekaldteBiler)
        {
            object[] bil = (object[])arry;
            foreach (object item in bil)
            Console.WriteLine($"{item.ToString()}");
        }

        List<object> lstFiatPunto = new List<object>() 
        { 
            "Fiat Punto",
            new DateTime(2010, 1, 1),
            "Udstødning" 
        };
        List<object> lstAlfaRomeo = new List<object>()
        {
            "Alfa Romeo",
            new DateTime(2019, 8, 1),
            "Styrtøj"
        };

        List<List<object>> lstTilbagekaldteBiler = new List<List<object>>()
        {
           lstFiatPunto,
           lstAlfaRomeo
        };

        foreach (object lst in lstTilbagekaldteBiler)
        {
            List<object> bil = (List<object>)lst;

        }


    }

    public void SetMultiDemArray()
    {
        string[,] tilbagekaldteBiler = new string[2, 3]

            {
                {"Fiat Punto", "2010, 1, 1", "Udstødning" },
                {"AlfaRomeo Giulia", "2019, 8, 1", "Styrtøj" }
            };


        //mangler at fixe fejl til 3 diminsion - måske fixet? - ok fixet, havde for mange brackets
        //string[,,] tilbagekaldteBiler = new string[2, 2, 3]
        //{

        //        {
        //          {"Fiat Punto", "2010, 1, 1", "Udstødning" },
        //          {"AlfaRomeo Giulia", "2019, 8, 1", "Styrtøj" }
        //    },
        //    {
        //    {"Fiat Punto", "2010, 1, 1", "Udstødning" },
        //    {"AlfaRomeo Giulia", "2019, 8, 1", "Styrtøj" }
        //    }

        //    };

        string alfaRomeoÅrgang = tilbagekaldteBiler[1, 1];

        //Vigtigt
        DateTime dtAlfaRomeoÅrgang = Convert.ToDateTime(alfaRomeoÅrgang);
        string mdrAlfaRomeo = dtAlfaRomeoÅrgang.ToString("MMMM");

        Console.WriteLine($"{alfaRomeoÅrgang}");


        int level0 = tilbagekaldteBiler.GetUpperBound(0);
        int level1 = tilbagekaldteBiler.GetUpperBound(1);
        //int level2 = tilbagekaldteBiler.GetUpperBound(2);
    
    
        for (int i = 0; i <= level0; i++)
        {
            for (int j = 0; j <= level1; j++)
            {
                string? res = tilbagekaldteBiler[i, j].ToString();
                Console.WriteLine(res);
            }  
        }

    
    }

}
