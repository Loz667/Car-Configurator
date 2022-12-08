using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI carName;
    [SerializeField] private TextMeshProUGUI carDescription;
    [SerializeField] private TextMeshProUGUI carPrice;

    [SerializeField] private Image carSpeed;
    [SerializeField] private Image carAccel;
    [SerializeField] private Image carHandling;

    public Material carMaterial;
    
    [SerializeField] private Transform carHolder;

    public void DisplayCar(Car currentCar)
    {
        carName.text = currentCar.modelName;
        carDescription.text = currentCar.modelDescription;
        carPrice.text = "£" + currentCar.modelPrice;

        carSpeed.fillAmount = currentCar.speed / 100;
        carAccel.fillAmount = currentCar.accel / 100;
        carHandling.fillAmount = currentCar.handling / 100;

        if (carHolder.childCount > 0)
            Destroy(carHolder.GetChild(0).gameObject);

        Instantiate(currentCar.modelPrefab, carHolder.position, carHolder.rotation, carHolder);

        carMaterial = currentCar.modelMaterial;
    }
}
