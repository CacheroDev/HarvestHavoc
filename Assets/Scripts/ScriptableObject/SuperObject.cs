

using UnityEngine;

[CreateAssetMenu (fileName = "SuperManager", menuName = "ScriptableObject/Manager")]

public class SuperObject : ScriptableObject
{
    static SuperObject superObject;
    public static SuperObject instance
    {
        get
        {
            if (superObject == null)
            {
                superObject = Resources.Load<SuperObject>("SuperManager");
            }
            return superObject;
        }
    }

    //public int HP;
    public int fruit;
    public bool tellStory;
    public float bossHP;
}
