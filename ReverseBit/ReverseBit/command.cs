using System;

namespace ReverseBit
{
    static class command
    {
        //выполняет битовый реверс каждого байта в массиве и выводит результат на экран.
        public static void main(byte[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                int tmp = (int)vs[i];
                tmp = ((tmp & 0x55) << 1) | ((tmp >> 1) & 0x55);
                tmp = ((tmp & 0x33) << 2) | ((tmp >> 2) & 0x33);
                tmp = ((tmp & 0x0F) << 4) | ((tmp >> 4) & 0x0F);
                vs[i] = (byte)tmp;
            }
        }

    }
}
