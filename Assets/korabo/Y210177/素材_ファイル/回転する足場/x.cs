using UnityEngine;

public class x : MonoBehaviour
{
    [Header("��]����")]
    public bool mainasu = false;

    public float spead = 1;
    // Update is called once per frame
    void Update()
    {
        if (!mainasu)
        {            
            this.transform.Rotate(Vector3.right, spead * Time.timeScale);
        }

        if (mainasu)
        {
            this.transform.Rotate(Vector3.right, -spead * Time.timeScale);
        }
    }
}
