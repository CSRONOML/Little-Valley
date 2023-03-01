using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;
    [SerializeField] private float damp;
    
    public Vector2 Velocity { private set; get; }

    private Vector2 Acceleration;

    private void FixedUpdate() {
        var target = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Velocity = Vector2.SmoothDamp(Velocity, target, ref Acceleration, damp);
        rigidbody2D.MovePosition(rigidbody2D.position + Velocity * speed * Time.fixedDeltaTime);
    }

}
