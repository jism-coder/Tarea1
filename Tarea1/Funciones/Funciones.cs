using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Tarea1.Funciones
{
    public class Funciones
    {
        public static void logApps(string Nombre, string strLog)
        {
            try
            {
                string path = @"C:\Users\Dell Rota\source\repos\Tarea1\";
                StreamWriter log;
                FileStream fileStream = null;
                DirectoryInfo logDirInfo = null;
                FileInfo logFileInfo;

                string logFile = path;
                string logFilePath = null;
                if (string.IsNullOrEmpty (logFilePath))
                {
                    return;
                }

                if (!logDirInfo.Exists)
                {
                    logDirInfo.Create();
                }
                //if (!logFileInfo.Exists)
                //{
                //    fileStream = logFileInfo.Create();
                //}
                //else
                //{
                //    fileStream = new FileStream(logFilePath, FileMode.Append);

                //}
                log = new StreamWriter(fileStream);
                log.WriteLine(strLog);
                log.Close();
            }
            catch (Exception)
            {

            }
           finally
            {

            }      
        }
        public static string Serialize (object input)
        {
            XmlSerializer mySerializer = new XmlSerializer(input.GetType());
            string xml = "";
            using (StringWriter sww = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = new UTF8Encoding(false, false);
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                XmlWriter writer = XmlWriter.Create(sww, settings);
                mySerializer.Serialize(writer, input);
                xml = sww.ToString();

            }
            return xml;
        }
    }
}