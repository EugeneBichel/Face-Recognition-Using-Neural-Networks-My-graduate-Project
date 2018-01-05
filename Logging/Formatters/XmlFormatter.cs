using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Xml;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;

namespace Logging.Formatters
{
    [ConfigurationElementType(typeof(CustomFormatterData))]
    public class XmlFormatter : LogFormatter
    {
        #region Fields

        private NameValueCollection Attributes;

        #endregion //Fields

        #region Constructor

        public XmlFormatter(NameValueCollection attributes)
            : base()
        {
            Attributes = attributes;
        }

        #endregion //Constructor

        #region Implementation of LogFormatter

        public override string Format(LogEntry log)
        {
            var prefix = Attributes["prefix"];
            var ns = Attributes["namespace"];

            using (var sw = new StringWriter())
            {
                var w = new XmlTextWriter(sw);
                w.Formatting = Formatting.Indented;
                w.Indentation = 2;
                w.WriteStartDocument(true);
                w.WriteStartElement(prefix, "logEntry", ns);
                w.WriteAttributeString("Priority", ns, log.Priority.ToString(CultureInfo.InvariantCulture));
                w.WriteElementString("Timestamp", ns, log.TimeStampString);
                w.WriteElementString("Message", ns, log.Message);
                w.WriteElementString("EventId", ns, log.EventId.ToString(CultureInfo.InvariantCulture));
                w.WriteElementString("Severity", ns, log.Severity.ToString());
                w.WriteElementString("Title", ns, log.Title);
                w.WriteElementString("Machine", ns, log.MachineName);
                w.WriteElementString("AppDomain", ns, log.AppDomainName);
                w.WriteElementString("ProcessId", ns, log.ProcessId);
                w.WriteElementString("ProcessName", ns, log.ProcessName);
                w.WriteElementString("Win32ThreadId", ns, log.Win32ThreadId);
                w.WriteElementString("ThreadName", ns, log.ManagedThreadName);
                w.WriteEndElement();
                w.WriteEndDocument();

                return sw.ToString();
            }
        }

        #endregion //Implementation of LogFormatter
    }
}