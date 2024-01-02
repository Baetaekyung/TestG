using UnityEngine;
public class Viewmodel : MonoBehaviour
{
    public Transform cam;

    public Animator animator;
    public float rayFuck;
    private bool b_gay = false;
    public bool b_fuck = false;
    private Trigger_Raycast tCock;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        RayTest();
    }
    private void LateUpdate()
    {
        transform.SetPositionAndRotation(cam.position, cam.rotation);
    }
    private void RayTest()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit gay, rayFuck))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.DrawRay(transform.position, transform.forward * rayFuck, Color.red, 5);
                if (gay.transform.TryGetComponent(out tCock))
                {
                    animator.Play("Interacting");
                    tCock.InitDieTime();
                    b_gay = true;
                }
            }
        }
        if (b_gay)
        {
            tCock.HandleTrigger();
            if (b_fuck)
            {
                print("Tt คว!");
                b_fuck = false;
                CancelInteract();
            }
        }
        if (Input.GetKeyUp(KeyCode.E) && b_gay)
        {
            CancelInteract();
        }
    }
    private void CancelInteract()
    {
        print("cancelInteract");
        animator.SetTrigger("gay");
        b_gay = false;
    }
}
