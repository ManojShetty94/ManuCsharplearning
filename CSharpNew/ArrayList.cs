using System.Collections;

ArrayList m= new ArrayList();
ArrayList a = new ArrayList();

m.Add("Manu");
m.Add("Sonu");
m.Add("Rahul");
a.Add(1);
a.Add(2);
a.Add(3);

Console.WriteLine(m[1]);
Console.WriteLine(a[2]);

foreach (String name in m)
{
    Console.WriteLine(name);
}


Console.WriteLine(a.Contains(1));
Console.WriteLine(m.Contains("Shetty"));

Console.WriteLine("After Sorting");

m.Sort();

foreach (String name in m)
{
    Console.WriteLine(name);
}

a.Sort();

foreach (int num in a)
{
    Console.WriteLine(num);
}

m.Clear();

Console.WriteLine("After clear");
Console.WriteLine("m.count:" +m.Count);

a.Clear();
Console.WriteLine("After clear");
Console.WriteLine("a.Count:" +a.Count);



