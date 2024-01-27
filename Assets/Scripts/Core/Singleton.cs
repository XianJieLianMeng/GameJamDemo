public class Singleton<T> where T : class, new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }

    protected Singleton()
    {
        // 防止通过new关键字实例化该类
        if (instance != null)
        {
            UnityEngine.Debug.LogError("Cannot instantiate singleton class. Use the provided Instance property instead.");
        }
    }
}