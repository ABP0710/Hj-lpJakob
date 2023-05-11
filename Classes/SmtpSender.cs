using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HjælpJakob.Interfaces;

namespace HjælpJakob.Classes
{
    public class SmtpSender : IConverter
    {
        public void sendSmtpMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }

        public void sendSmtpMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }

        public string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
