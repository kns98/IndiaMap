using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        string[] resourceNames = currentAssembly.GetManifestResourceNames();

        foreach (string resourceName in resourceNames)
        {
            Console.WriteLine(resourceName);

             using (Stream stream = currentAssembly.GetManifestResourceStream(resourceName))
             {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
