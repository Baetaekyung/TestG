using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "DialogData/Data")]
public class DialogData : ScriptableObject
{
    public List<Datas> data = new List<Datas>();
    public string nickName;
    public Sprite sourceImage;
}
