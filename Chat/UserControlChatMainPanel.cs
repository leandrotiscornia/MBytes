using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            loadPicture();

        }
        public void loadPicture()
        {
            Console.WriteLine(Session.ci);
            Console.WriteLine(Path.Combine(PictureController.getPicturePath(), Session.ci + ".jpg"));
            if (File.Exists(Path.Combine(PictureController.getPicturePath(), Session.ci + ".jpg")))
                pbProfilePicture.Image = Image.FromFile(Path.Combine(PictureController.getPicturePath(), Session.ci + ".jpg"));
        }
       
        private void loadGroups()
        {
            DataTable groups = GroupController.listInscriptedGroups(Session.ci);
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
            ImageList sessionImages = new ImageList();
            sessionImages.ImageSize = new Size(40, 40);
            sessionImages.ColorDepth = ColorDepth.Depth32Bit;
            foreach (DataRow session in sessions.Rows)
            {
                sessionView = new ListViewItem(session[2].ToString());
                sessionView.SubItems.Add(session[1].ToString());
                sessionView.SubItems.Add(session[0].ToString());
                sessionView.SubItems.Add(session[3].ToString());
                sessionView.SubItems.Add(session[4].ToString());
                lvSessions.Items.Add(sessionView);
            }
            foreach (ListViewItem item in lvSessions.Items)
            {
                if (File.Exists(Path.Combine(PictureController.getPicturePath(), item.SubItems[3].Text + ".jpg")))
                    sessionImages.Images.Add(Image.FromFile(PictureController.getPicturePath() + item.SubItems[3].Text + ".jpg"));
                else
                    sessionImages.Images.Add(new Bitmap(40, 40));
                item.ImageIndex = sessionImages.Images.Count - 1;
            }
            lvSessions.LargeImageList = sessionImages;

            ImageList registerImages = new ImageList();
            registerImages.ImageSize = new Size(40, 40);
            registerImages.ColorDepth = ColorDepth.Depth32Bit;
            foreach (DataRow register in registers.Rows)
            {
                
                registerView = new ListViewItem(register[2].ToString());
                registerView.SubItems.Add(register[1].ToString());
                registerView.SubItems.Add(register[0].ToString());
                registerView.SubItems.Add(register[3].ToString());
                registerView.SubItems.Add(register[4].ToString());
                registerView.SubItems.Add(register[5].ToString());
                lvRegisters.Items.Add(registerView);
                
            }
            foreach (ListViewItem item in lvRegisters.Items)
            {
                if (File.Exists(Path.Combine(PictureController.getPicturePath(), item.SubItems[5].Text + ".jpg")))
                    registerImages.Images.Add(Image.FromFile(PictureController.getPicturePath() + item.SubItems[5].Text + ".jpg"));
                else
                    registerImages.Images.Add(new Bitmap(40, 40));
                item.ImageIndex = registerImages.Images.Count - 1;
            }
            lvRegisters.LargeImageList = registerImages;

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
            loadPicture();
        }

        private void tcChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSessions();
            
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubjects(groupsId[cbGroups.SelectedIndex]);
        }

        
    }



}
