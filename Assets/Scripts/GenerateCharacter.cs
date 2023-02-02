using System;

public class GenerateCharacter 
{
    public int numberCharacter; 
    public GenerateCharacter(int characterLenght) 
    {
        for (int i = 0; i < characterLenght; i++)
        {
            Random random = new Random();
            numberCharacter = random.Next(0, characterLenght);
        }
    }
    
}


