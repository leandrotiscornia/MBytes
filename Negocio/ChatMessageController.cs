using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ChatMessageController
    {
        public static void sendMessage(int chatId, int senderId, string text)
        {
            ModelChatMessage message = new ModelChatMessage();
            message.chatId = chatId;
            message.senderId = senderId;
            message.text = text;
            message.time = DateTime.Now;
            message.sendMessage();
        }
        public static void editMessage()
        {

        }
        public static DataTable listMessages(int chatId)
        {
            ModelChatMessage message = new ModelChatMessage();
            message.chatId = chatId;
            
            return message.listMessages();
        }
    }


}
