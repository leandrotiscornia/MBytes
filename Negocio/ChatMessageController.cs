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
        public static DataTable getChatMessage(int chatId)
        {
            ModelChat chatMessage = new ModelChat();
            chatMessage.chatId = chatId;
            DataTable chatMessageTable = chatMessage.getChatMessages();
            return chatMessageTable;
        }
        public static void sendChatMessage(int chatId, int senderId, string text )
        {
            ModelChat chatMessage = new ModelChat();
            chatMessage.chatId = chatId;
            chatMessage.senderId = senderId;
            chatMessage.text = text;
            chatMessage.sendChatMessage();
        }

    }


}
