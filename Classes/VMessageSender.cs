using HjælpJakob.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpJakob.Classes
{
    public class VMessageSender : IConverter
    {
        public void sendVMessage(MessageCarrier type, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void sendVMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
