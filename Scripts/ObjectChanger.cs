using Unity.VisualScripting;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] objects;
    [SerializeField] private CarDisplay carDisplay;
    private int currentIndex;

    [SerializeField] private Material currentMaterial;
    [SerializeField] private Color newColour;

    private void Awake()
    {
        ChangeObjectInFocus(0);
    }

    public void ChangeObjectInFocus(int value)
    {
        currentIndex += value;
        if (currentIndex < 0) currentIndex = objects.Length - 1;
        else if (currentIndex > objects.Length - 1) currentIndex = 0;

        if (carDisplay != null) carDisplay.DisplayCar((Car)objects[currentIndex]);
        currentMaterial = carDisplay.carMaterial;
    }

    public void ChangeObjectColour()
    {
        newColour = Random.ColorHSV();
        if (currentMaterial != null) currentMaterial.SetColor("_BaseColor", newColour);
    }
}
