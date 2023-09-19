

using UnityEngine;

using UnityEngine;

[CreateAssetMenu(menuName = "Mover")]
public class MoveData : ScriptableObject
{

    public float speed = 10f;

    public int direction;

    public void Move(Transform transform)
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }
}   