using UnityEngine;
using UnityEngine.UI;
public class HealtBar : MonoBehaviour
{

    /*
     
        https://github.com/hammerinformation

     */
    [SerializeField] private Image healthImage;
    const float maxHealt = 100f;
    [SerializeField] private float health = 100f;

    



    public void Damage(float damage)
    {
        health -= damage;
        healthImage.fillAmount = health / maxHealt;

    }

    private void LateUpdate()
    {

        //Example
        if (Input.GetMouseButtonDown(1))
        {
            Damage(10);
        }
    }



}
