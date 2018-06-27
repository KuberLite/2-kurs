using System.Windows;

namespace Lab_13.State
{
    public enum State { Run, Swim, Jump }

    class Hero
    {
        public State state { get; set; }

        public Hero(State st)
        {
            state = st;
        }

        public void StartFromJump()
        {
            if (state == State.Jump)
            {
                MessageBox.Show("Object start jumping");
                state = State.Run;
            }

            else if (state == State.Run)
            {
                MessageBox.Show("Object start running");
                state = State.Swim;
            }

            else if (state == State.Swim)
            {
                MessageBox.Show("Object start swimming");

            }
        }

        public void StartFromSwim()
        {
            if (state == State.Swim)
            {
                MessageBox.Show("Object start swimming");
                state = State.Run;
            }

            else if (state == State.Run)
            {
                MessageBox.Show("Object start running");

            }
        }
    }

}