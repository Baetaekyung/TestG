using UnityEngine;
public class NewBehaviourScript : TriggerBehavior
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
        if (dieTime <= 0)
        {
            base.HandleTrigger();
            InitDieTime();
        }
    }
    public void InitDieTime()
    {
        dieTime = gay;
    }
}