using System;
using System.Resources;
using System.Drawing;

namespace WebApplicationReact.Models
{
    public class Resource
    {
        public static void Main()
        {
            using (ResourceWriter resx = new ResourceWriter(@"C:\Resources.resx"))
            {
                resx.AddResource("HeaderString1", "Key");
                resx.AddResource("HeaderString2", "Eng");
                resx.AddResource("HeaderString2", "Arab");
                resx.AddResource("HeaderString2", "Ru");
            }
            }
        }
}
