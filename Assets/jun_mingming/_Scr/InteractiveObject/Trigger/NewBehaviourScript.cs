using UnityEngine;
public class NewBehaviourScript : TriggerBehavior //�̰� �̸������ұ� ���ѻ�� �ǻ�����
{
    [Space(10)]
    public float dieTime;//get only
    private float gay;
    private void Awake()
    {
        gay = dieTime;
    }
    public override void HandleTrigger()
    {
        print("c");
        dieTime -= Time.deltaTime;
        if (Gay())
        {
            base.HandleTrigger();
            Viewmodel.Instance.b_fuck = true;
            InitDieTime();
        }
    }
    public void InitDieTime()
    {
        dieTime = gay;
    }
    public bool Gay()
    {
        return dieTime <= 0;
    }
}