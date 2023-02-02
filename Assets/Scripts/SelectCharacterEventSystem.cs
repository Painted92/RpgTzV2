using UnityEngine.Events;

public class SelectCharacterEventSystem
{
    public static UnityEvent generatorEvents = new UnityEvent();
    public static void SendGeneratCharacter() => generatorEvents.Invoke();
   
}
