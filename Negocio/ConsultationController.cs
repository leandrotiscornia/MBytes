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
            consultationDone = consultation.getConsultationssDone();
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
        public static void newConsultation(int senderId, int receiverId, string topic, string message)
        {
            ModelConsultation consultation = new ModelConsultation();
            consultation.senderId = senderId;
            consultation.receiverId = receiverId;
            consultation.consultationTopic = topic;
            consultation.consultationState = "Done";
            consultation.createObjectConsultation();
            consultation.insertObject();
            ConsultationMessageController.sendConsultationMessage(consultation.getLastInsertId(), senderId, message);
        }


    }
}
