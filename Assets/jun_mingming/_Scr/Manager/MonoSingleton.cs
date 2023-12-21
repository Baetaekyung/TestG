using UnityEngine;
using System.Reflection;

[DefaultExecutionOrder(-200)]// �̰� ����� �˾ƿ��� ��������� ����� ����
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static readonly SingletonFlags singletonFlag = typeof(T).GetCustomAttribute<AttributeSingleton>()?.Flags ?? SingletonFlags.None; // ����Ƽ static consturctor �� �Ŵ��� �𸣰���
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
                print("�ε��̵Ƴ�..");
                return FindObjectOfType<T>();
            }
            return null;
        }

        //AutoInstance
        GameObject gameObject = new GameObject(typeof(T).FullName);
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
        print("��");
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
    {
    }

}