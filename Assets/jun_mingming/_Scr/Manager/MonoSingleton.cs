using UnityEngine;
using System.Reflection;

[DefaultExecutionOrder(-200)]// 이거 제대로 알아오기 상속했을때 생기는 문제
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static readonly SingletonFlags singletonFlag = typeof(T).GetCustomAttribute<AttributeSingleton>()?.Flags ?? SingletonFlags.None; // 유니티 static consturctor 잘 돼는지 모르겟음
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (!instance)
            {
                instance = Initialize();
            }
            return instance;
        }
    }

    private static T Initialize()
    {
        print("Init");
        if (singletonFlag.HasFlag(SingletonFlags.NoAutoInstance))
        {
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().isLoaded)
            {
                print("로딩이됐노..");
                return FindObjectOfType<T>();
            }
            return null;
        }

        //AutoInstance
        GameObject gameObject = new GameObject(typeof(T).FullName); // Destroy 에서 호출할때, 앱종류시 문제 해결해야함
        T result = gameObject.AddComponent<T>();
        if (singletonFlag.HasFlag(SingletonFlags.DontDestroy))
        {
            DontDestroyOnLoad(gameObject);
        }

        return result;
    }

    protected virtual void Awake()
    {
        //print("-AwakeInit-");
        //print((bool)instance);
        print("밍");
        if (instance)
        {
            Debug.LogError("twoSingletons");
            Destroy(gameObject);
        }
        else
        {
            instance = (T)this;
            print(instance.name);
            //print(typeof(T).FullName);
        }
    }
    protected virtual void OnDestroy()
    {//종료시 참조하는거 고치기
    }

}