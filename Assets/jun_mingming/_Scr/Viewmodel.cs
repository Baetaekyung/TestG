using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Viewmodel : MonoSingleton<Viewmodel>// 이거 이름 카메라로바꾸기
{
    public Transform cam;
    public Transform gay;

    public Animator animator;
    public float rayFuck;
    private bool b_gay = false;
    public bool b_fuck = false;
    private Trigger_Raycast tCock;
    protected override void Awake()
    {
        base.Awake();
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
                print("Tt ㅗ!");
                b_fuck = false;
                CancelInteract();
            }
        }
        if (Input.GetKeyUp(KeyCode.E) && b_gay)
        {
            CancelInteract();
        }
    }
    public void PlayAnimation(string a)
    {
        animator.Play(a);
    }
    private void CancelInteract()
    {
        print("cancelInteract");
        animator.SetTrigger("gay");
        b_gay = false;
    }
    public bool ShootRay(float gay, out RaycastHit a)
    {
        Debug.DrawRay(transform.position, transform.forward * gay, Color.red, 3);
        if (Physics.Raycast(transform.position, transform.forward, out a, gay))
        {
            return true;
        }
        else return false;
    }
}
