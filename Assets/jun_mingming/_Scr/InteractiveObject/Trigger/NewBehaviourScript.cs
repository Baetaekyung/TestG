using UnityEngine;
public class NewBehaviourScript : TriggerBehavior //¿Ã∞≈ ¿Ã∏ßππ∑Œ«“±Ó ¡§«—ªÁ∂˜ ª«ª««ÿ¡‹
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
            Player.Instance.playerViewmodel.b_fuck = true;
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