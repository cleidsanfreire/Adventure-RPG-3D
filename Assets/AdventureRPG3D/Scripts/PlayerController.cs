using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlyerController controls;

    [SerializeField] private Vector2 _moveInput;

    private void Awake()
    {
        controls = new PlyerController();

        controls.Player.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => _moveInput = Vector2.zero;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
