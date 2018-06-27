using System.Windows;

namespace Lab_13.Command
{

    interface Icommand
    {
        void Move();
    }

    public class JumpCommand : Icommand
    {
        public void Move()
        {
            
                MessageBox.Show("Use command Jump");
            
        }
    }

    public class RunCommand: Icommand
    {
        public void Move()
        {
          MessageBox.Show("Use command Run");
        }
    }

    public class SwimCommand : Icommand
    {
        public void Move()
        {
        MessageBox.Show("Use command Swim");
        }
    }

}