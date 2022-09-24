using UnityEngine.Events;

public class EventManager
{
   public static UnityEvent<int> HealingPickedUp  = new UnityEvent<int>();

   public static void CallerHealingPicker(int healing)
    {
        HealingPickedUp.Invoke(healing);
    }
}
