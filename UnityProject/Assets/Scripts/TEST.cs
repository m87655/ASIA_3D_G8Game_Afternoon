using UnityEngine;

public class TEST : MonoBehaviour
{
    private void Update()
    {
        Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        posMouse.z = 10;
        Vector3 pos = Camera.main.ScreenToWorldPoint(posMouse);
        GetComponent<Rigidbody>().MovePosition(pos);
    }
}
