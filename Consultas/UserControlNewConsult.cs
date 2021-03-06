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


namespace Consultas
{
    public partial class UserControlNewConsult : UserControl
    {

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user selects an item in the ListView")]
        public event EventHandler SelectedIndexChanged;

        public int userId { get; set; }
        
    
        public UserControlNewConsult()
        {
            InitializeComponent();
        }

        private void UserControlNewConsult_Load(object sender, EventArgs e)
        {
            loadPersons();
        }

        protected virtual void lvNewConsults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNewConsults.SelectedIndices.Count > 0)
                this.userId = Int32.Parse(lvNewConsults.SelectedItems[0].SubItems[2].Text);
            else
                this.userId = -1;
            this.SelectedIndexChanged?.Invoke(this, e);
        }
        
        public void loadPersons()
        {
            DataTable personsTable = new DataTable();
            personsTable = PersonController.GetScheduleUsers();
            ListViewItem item;
            lvNewConsults.Items.Clear();
            ImageList images = new ImageList();
            images.ImageSize = new Size(40 , 40);
            images.ColorDepth = ColorDepth.Depth32Bit;

            if(personsTable.Rows.Count > 0)
            {
                foreach (DataRow person in personsTable.Rows)
                {
                    item = new ListViewItem(person[1].ToString());
                    item.SubItems.Add(person[2].ToString() + " " + person[4].ToString());
                    item.SubItems.Add(person[0].ToString());
                    item.SubItems.Add(person[6].ToString());
                    lvNewConsults.Items.Add(item);
                }
            }
            foreach(ListViewItem itemm in lvNewConsults.Items)
            {
                if (File.Exists(Path.Combine(PictureController.getPicturePath(), itemm.Text + ".jpg")))
                    images.Images.Add(Image.FromFile(PictureController.getPicturePath() + itemm.Text + ".jpg"));
                else
                    images.Images.Add(new Bitmap(40, 40));
                itemm.ImageIndex = images.Images.Count - 1;
            }
            lvNewConsults.LargeImageList = images;
        }
        
    }
}
