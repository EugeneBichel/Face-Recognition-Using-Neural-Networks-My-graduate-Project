using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace Utility
{
    public class Helper
    {
        public static void SerializeObject(Type type, Object pObject, string path)
        {
            try
            {
                var xs = new XmlSerializer(type);
                using (var xmlTextWriter = new XmlTextWriter(path, Encoding.Default))
                {
                    xs.Serialize(xmlTextWriter, pObject);
                    xmlTextWriter.Close();
                    xs = null;
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed to save data by {0} path", path));
            }
        }
        public static Object DeserializeObject(Type type, string path)
        {
            try
            {

                var xs = new XmlSerializer(type);
                using (var xmlTextReader = new XmlTextReader(path))
                {
                    return xs.Deserialize(xmlTextReader);
                    xmlTextReader.Close();
                    xs = null;
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;
                MessageBox.Show(string.Format("Failed to load data from {} path", path));
            }
            return null;
        }
        /// <summary>
        /// Return executed directory's name
        /// </summary>
        /// <returns>Executed directory's name</returns>
        public static string GetExecutedDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        public static string GetShortName(string fullName)
        {
            if (IsStringMissing(fullName))
                throw new ArgumentException("fullName");

            var words = fullName.Split('\\');

            var shortName = words[words.Length - 1];

            return shortName;
        }
        public static bool IsStringMissing(string value)
        {
            return (string.IsNullOrEmpty(value) || value.Trim() == string.Empty);
        }
    }
}