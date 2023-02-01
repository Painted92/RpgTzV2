using System;

public class GenerateCharacter 
{
    public int numberCharacter; 
    public GenerateCharacter(int characterLenght) // конструктор рандомайзер принимает в себя длинну масива обьектов. и возвращает случайное число из длинны масива.
    {
        for (int i = 0; i < characterLenght; i++)
        {
            Random random = new Random();
            numberCharacter = random.Next(0, characterLenght);
        }
    }
    
}


