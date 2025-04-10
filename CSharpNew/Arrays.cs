using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

String[] a = { "Manu", "Shetty", "Kalligadde" };
int[] b = { 1, 2, 3, 4, 5 };
int[] c = new int[5];

String[] a1 = new String[3];
a1[0] = "Manu";
a1[1] = "Shetty";
a1[2] = "Kalligadde";

int[] a2 = new int[5];
a2[0] = 19;
a2[1] = 12;
a2[2] = 18;


Debug.WriteLine(a[1]);
Debug.WriteLine(a[0]);
Debug.WriteLine(a[2]);
Debug.WriteLine(b[3]);
Debug.WriteLine("The int a2 numbers are: " + a2[0] + ", " + a2[1] + ", " + a2[2]);

for  (int i = 0; i < a2.Length; i++)
{
    Debug.WriteLine(a2[i]);

    if (a2[i] == 19)
    {
        Debug.WriteLine("Program Success");
        break;
    }
       
}


for (int i = 0; i < a.Length; i++)
{
    if (a[i] == "Manu")
    {
        Debug.WriteLine("Manu ge kelsa sikthu");
               break;
    }
}
