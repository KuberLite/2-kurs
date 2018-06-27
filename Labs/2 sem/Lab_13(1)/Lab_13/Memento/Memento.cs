using System.Collections.Generic;
using System.Windows;

namespace Lab_13.Memento
{
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }

    class Heros
    {
        private int patrons = 10; 
        private int lives = 5; 

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
               MessageBox.Show("Производим движение. Осталось "+ patrons.ToString()+" движений" );
            }
            else
                MessageBox.Show("Вариантов движения больше нет");
        }
        public HeroMemento SaveState()
        {
            MessageBox.Show("Сохранение игры. Параметры: " +patrons.ToString() + " движений," + lives.ToString() + " кликов");
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            MessageBox.Show("Восстановление игры. Параметры: " + patrons.ToString() + " движений," + lives.ToString() + " кликов");
        }
    }
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    }
}
