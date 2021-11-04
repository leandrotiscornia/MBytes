using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;



namespace Chat
{
    public partial class UserControlChatMainPanel : UserControl
    {
        private List<int> groupsId;
        private List<int> subjectsId;

        Func<ListViewItem, int> getChatId = item => int.Parse(item.SubItems[0].Text);
        Func<ListViewItem, int> getHostId = item => int.Parse(item.SubItems[1].Text);

        public UserControlChatMainPanel()
        {
            InitializeComponent();
            groupsId = new List<int>();
            subjectsId = new List<int>();
        }
        
       
        private void loadGroups()
        {
            DataTable groups = GroupController.listGroups();
            foreach(DataRow group in groups.Rows)
            {
                cbGroups.Items.Add(group[1]);
                groupsId.Add((int)group[0]);
            }
        }
        private void loadSubjects(int groupId)
        {
            DataTable subjects = SubjectController.listSubjectsByGroup(groupId);
            foreach (DataRow subject in subjects.Rows)
            {
                cbSubjects.Items.Add(subject[1]);
                subjectsId.Add((int)subject[0]);
            }
        }
        private void loadSessions()
        {
            DataTable sessions = ChatSessionController.listSessions();
            DataTable registers = ChatSessionController.listRegister();
            ListViewItem sessionView;
            ListViewItem registerView;
            lvSessions.Clear();
            lvRegisters.Clear();
            foreach(DataRow session in sessions.Rows)
            {
                sessionView = new ListViewItem(session[0].ToString());
                sessionView.SubItems.Add(session[1].ToString());
                sessionView.SubItems.Add(session[2].ToString());
                sessionView.SubItems.Add(session[3].ToString());
                lvSessions.Items.Add(sessionView);
            }
            foreach(DataRow register in registers.Rows)
            {
                Console.WriteLine("" + register[0] + register[1] + register[2]);
                registerView = new ListViewItem(register[0].ToString());
                registerView.SubItems.Add(register[1].ToString());
                registerView.SubItems.Add(register[2].ToString());
                registerView.SubItems.Add(register[3].ToString());
                lvRegisters.Items.Add(registerView);
            }
        }
        private void createSession(int groupId, int subjectId)
        {
            FormChatSession chatSession = 
                new FormChatSession(ChatSessionController.openSession(Session.userId, tbSessionName.Text, groupId, subjectId),
                false, Session.userId);
            chatSession.Show();
        }
        private void joinSession()
        {
            if (lvSessions.SelectedIndices.Count > 0 && tcChat.SelectedTab.Name == "tpSessions")
            {
                FormChatSession chatSession = new FormChatSession(getChatId(lvSessions.SelectedItems[0]), false, getHostId(lvSessions.SelectedItems[0]));
                chatSession.Show();
                ChatSessionController.joinSession(Session.userId, getChatId(lvSessions.SelectedItems[0]));
            }
            else if (lvRegisters.SelectedItems.Count > 0 && tcChat.SelectedTab.Name == "tpRegisters")
            {
                FormChatSession chatRegister = new FormChatSession(getChatId(lvRegisters.SelectedItems[0]), true, getHostId(lvRegisters.SelectedItems[0]));
                chatRegister.Show();
            }
        }
        
        private void btnJoin_Click(object sender, EventArgs e)
        {
            joinSession();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cbGroups.SelectedIndex != null && cbSubjects.SelectedIndex != null)
                createSession(groupsId[cbGroups.SelectedIndex], subjectsId[cbSubjects.SelectedIndex]);
        }

        private void UserControlChatMainPanel_Load(object sender, EventArgs e)
        {
            loadSessions();
            loadGroups();
        }

        private void tcChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSessions();
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroups.SelectedIndex > 0)
                loadSubjects(groupsId[cbGroups.SelectedIndex]);
        }
    }



}
