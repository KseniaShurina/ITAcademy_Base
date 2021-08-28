using HW9.Enums;
using System;

namespace HW9
{
    public class PenFactory
    {
        private int penLenght;

        public PenFactory(int penLenght)
        {
            this.penLenght = penLenght;
        }

        public Pen CreatePen(Color color)
        {
            Pen pen = new Pen(color, penLenght);
            return pen;
        }

        public MyCollection<Pen>  CreatePenBox()
        {
            // создаём коробку
            MyCollection<Pen> penBox = new MyCollection<Pen>(); 
            // цикл перебора всех цветов
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                // в цикле мы созд карандаш
                Pen pen1 = CreatePen(color);
                // добавляем карандаш в коробку
                penBox.Add(pen1);
            }
            return penBox;
        }
    }
}
