using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class UI_Test_Gay : MonoSingleton<UI_Test_Gay>
{
    public Text t1;
    public Text t2;
    public Text t3;
}
