﻿namespace _03.WildFarm.Foods
{
    public abstract class Food
    {
        private int quantity;

        public Food(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}