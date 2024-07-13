using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	[SerializeField] Rigidbody2D rb;
	[SerializeField] public float jumpForceMultiplier = 1f;

	private float jumpForce = 0f;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			jumpForce = 1f;
		}
	}
	private void FixedUpdate()
	{
		rb.AddForce(Vector2.up * jumpForce * jumpForceMultiplier, ForceMode2D.Impulse);
		jumpForce = 0;
	}
}
