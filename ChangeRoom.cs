using UnityEngine;
using UnityEngine.Events;

public class ChangeRoom : MonoBehaviour, IGrabable
{
    [SerializeField] RoomControl roomToSwitch;
    public UnityEvent onChangeRoom;
    public void Use()
    {
        NavigationControl navControl = FindFirstObjectByType<NavigationControl>();
        if (navControl != null)
        {
            navControl.isChangingToSSubRoom = true;
        }

        RoomManager.Instance.SetCurrentRoom(roomToSwitch);
        AudioManager.Instance.Play("click");
        onChangeRoom?.Invoke();
    }
}
