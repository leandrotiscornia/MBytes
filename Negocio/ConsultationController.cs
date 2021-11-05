using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Negocio
{
    public static class ConsultationController
    {
        public static void changeConsultationState(int consultationId, string state)
        {
            ModelConsultation consultation = new ModelConsultation();
            consultation.consultationId = consultationId;
            consultation.consultationState = state;
            consultation.changeConsultationState();
        }
        public static DataTable getConsultationsDone(int myId)
        {
            DataTable consultationDone = new DataTable();
            ModelConsultation consultation = new ModelConsultation();
            consultation.senderId = myId;
            Console.WriteLine("El id del usuario es: " + myId);
            consultationDone = consultation.getConsultationsDone();
            return consultationDone;
        }
        public static DataTable getConsultationsReceived(int myId)
        {
            DataTable consultationDone = new DataTable();
            ModelConsultation consultation = new ModelConsultation();
            consultation.receiverId = myId;
            consultationDone = consultation.getConsultsReceived();
            return consultationDone;
        }
        public static string getConsultationState(int consultationId)
        {
            string consultationState;
            ModelConsultation consultation = new ModelConsultation();
            consultation.consultationId = consultationId;
            consultationState = consultation.getConsultationState();
            return consultationState;
        }
        public static int newConsultation(int senderId, int receiverId, string topic, string message)
        {
            int consultationId;
            ModelConsultation consultation = new ModelConsultation();
            consultation.senderId = senderId;
            consultation.receiverId = receiverId;
            consultation.consultationTopic = topic;
            consultation.consultationState = "Done";
            consultation.createObjectConsultation();
            consultation.insertObject();
            consultationId = consultation.getLastInsertId();
            ConsultationMessageController.sendConsultationMessage(consultationId, senderId, message);
            return consultationId;
        }
    }
}
