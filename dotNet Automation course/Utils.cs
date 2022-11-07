using System.Xml.Linq;

namespace dotNet_Automation_course
{
    class Utils
    {
        public static void saveToXML(string root, string filename, params XElement[] elements)
        {
            try
            {
                string basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                new XElement(root, elements).Save(basePath + @"\..\..\..\" + filename);
            } catch (Exception e)
            {
                Console.WriteLine("Saving the file was't succesful because \n" +
                    $"{e.Message}");
            }

        }


    }
}
