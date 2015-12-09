using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace torrenut
{
    class UpdateChecker
    {
        private static String currentVersionUrl = "http://torrenut.com/currentversion.xml";

        public static bool NewVersionAvailable()
        {            
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(currentVersionUrl);

                XmlElement e = doc.DocumentElement;

                Int16 versionNumber = Int16.Parse(e.InnerText);

                if (TorrenutMainForm.TorrenutVersion != versionNumber) return true;

                return false;
            }
            catch (Exception ex)
            {
                //throw;
                TorrHelper.Log("NewVersionAvailable Exception: " + ex.Message);
            }
            return false;
        }
    }
}
