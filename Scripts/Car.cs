using UnityEngine;

[CreateAssetMenu(fileName = "New Car", menuName = "Car")]
public class Car : ScriptableObject
{
    public GameObject modelPrefab;
    public Material modelMaterial;
    public string modelName;
    public string modelDescription;
    public string modelPrice;
    public float accel;
    public float speed;
    public float handling;
}
