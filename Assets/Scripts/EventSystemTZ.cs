using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemTZ
{
    public static UnityEvent generatorEvents = new UnityEvent();
    public static UnityEvent playEvents = new UnityEvent();
    public static UnityEvent backEvents = new UnityEvent();

    public static void SendGeneratCharacter() => generatorEvents.Invoke();
    public static void PlayCharacter() => playEvents.Invoke();
    public static void BackMenu() => backEvents.Invoke();

}
