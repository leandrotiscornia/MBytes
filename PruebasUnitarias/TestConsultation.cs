using System;
using System.Data;
using Datos;
using Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestConsultation
    {
        [TestMethod]
        public void AnewConsultation()
        {
            Globals.consultationId = ConsultationController.newConsultation(71, 70, "testTopic", "testDoubt");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BgetConsultationsDone()
        {
            DataTable consultations = ConsultationController.getConsultationsDone(71);
            DataRow consultation = consultations.Rows[consultations.Rows.Count - 1];
            foreach (DataColumn column in consultations.Columns)
                Console.WriteLine(column.ColumnName + ": "+ consultation[column].ToString());
            
            Assert.IsTrue(
                consultation[1].ToString() == "teacher" &&
                consultation[2].ToString() == "teacher" &&
                consultation[3].ToString() == "testTopic" &&
                consultation[4].ToString() == "Done" 
                );
        }
        [TestMethod]
        public void CanswerConsultation()
        {
            ConsultationMessageController.sendConsultationMessage(Globals.consultationId, 70, "testAnswer");
            ConsultationController.changeConsultationState(Globals.consultationId, "Answered");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void DgetConsultationsAnswered()
        {
            DataTable consultations = ConsultationController.getConsultationsDone(71);
            DataRow consultation = consultations.Rows[consultations.Rows.Count - 1];
            Assert.IsTrue(
                consultation[1].ToString() == "teacher" &&
                consultation[2].ToString() == "teacher" &&
                consultation[3].ToString() == "testTopic" &&
                consultation[4].ToString() == "Answered" 
                );
        }
        [TestMethod]
        public void EreadConsultation()
        {
            ConsultationController.changeConsultationState(Globals.consultationId, "Readed");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void FgetConsultationsReaded()
        {
            DataTable consultations = ConsultationController.getConsultationsDone(71);
            DataRow consultation = consultations.Rows[consultations.Rows.Count - 1];
            Assert.IsTrue(
                consultation[1].ToString() == "teacher" &&
                consultation[2].ToString() == "teacher" &&
                consultation[3].ToString() == "testTopic" &&
                consultation[4].ToString() == "Readed" 
                );
        }
        [TestMethod]
        public void GfileConsultation()
        {
            ConsultationController.changeConsultationState(Globals.consultationId, "Filed");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void HgetConsultationsFiled()
        {
            DataTable consultations = ConsultationController.getConsultationsDone(71);
            DataRow consultation = consultations.Rows[consultations.Rows.Count - 1];
            Assert.IsTrue(
                consultation[1].ToString() == "teacher" &&
                consultation[2].ToString() == "teacher" &&
                consultation[3].ToString() == "testTopic" &&
                consultation[4].ToString() == "Filed" 
                );
        }
        [TestMethod]
        public void IgetConsultationMessages()
        {
            DataTable messages = ConsultationMessageController.getConsultationMessages(Globals.consultationId);
            Assert.IsTrue(
                messages.Rows[0][0].ToString() == "71" &&
                messages.Rows[1][0].ToString() == "70" &&
                messages.Rows[0][1].ToString() == "testDoubt" &&
                messages.Rows[1][1].ToString() == "testAnswer"
                );
        }
    }
}
