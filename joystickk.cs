using UnityEngine;

public class joystickk : MonoBehaviour
{
    public RectTransform joyStickObj;
    // Start is called before the first frame update
    private void Awake()
    {
        joyStickObj = GetComponent<RectTransform>();
    }

}
