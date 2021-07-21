using System;
using System.Collections;

//Принцип открытости/закрытости (open–closed principle)
//«программные сущности должны быть открыты для расширения, но закрыты для модификации».

namespace SolidIncorrectClass
{
    public class Parent
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double FirstMethod(int value3, int value4)
        {
            return Math.Sqrt(Value1 * value3 + Value2 * value4);
        }

    }

    public class Child : Parent
    {
        //Перекрываем метод родителя
        public int FirstMethod(int value3)
        {
            return new Random(2).Next() * Value1 + value3;
        }
    }

    
}
