using UnityEditor.U2D.Path;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    [Header("Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float damp;
    
    [Header("References")]
    [SerializeField] private new Rigidbody2D rigidbody2D;
    
    public Vector2 Velocity { private set; get; }
    public bool Stopping { private set; get; }
    public bool LastVelocityWasNegative { private set; get; }

    private Vector2 Acceleration;

    private void FixedUpdate() {
        var target = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Velocity = Vector2.SmoothDamp(Velocity, target, ref Acceleration, damp);
        Stopping = target.magnitude == 0;

        if (target.x != 0) {
            LastVelocityWasNegative = target.x < 0;
        }

        rigidbody2D.MovePosition(rigidbody2D.position + Velocity * speed * Time.fixedDeltaTime);
    }

}
