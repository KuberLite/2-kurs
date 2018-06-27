using System.Windows.Forms;

namespace TreeView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            textBox1.Text = node.Text;
        }
    }
}
