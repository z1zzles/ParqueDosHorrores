using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Modify Health Condition")]
public class ModifyHealthAttrCondition : MonoBehaviour
{
    public bool destroyWhenActivated = false;
    public int healthChange = -1;

    //This will create a dialog window asking for which dialog to add
    private void Reset()
    {
        Utils.Collider2DDialogWindow(this.gameObject, true);
    }

    // This function gets called everytime this object collides with another
    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        OnTriggerEnter2D(collisionData.collider);
    }

    private void OnTriggerEnter2D(Collider2D colliderData)
    {
        HealthSystemAttrCondition healthScript = colliderData.gameObject.GetComponent<HealthSystemAttrCondition>();
        if (healthScript != null)
        {
            // subtract health from the player
            healthScript.ModifyHealth(healthChange);


            if (destroyWhenActivated)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
