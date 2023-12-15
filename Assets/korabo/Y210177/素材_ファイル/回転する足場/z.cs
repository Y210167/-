using UnityEngine;

public class z : MonoBehaviour
{
    [Header("‰ñ“]•ûŒü")]
    public bool mainasu = false;

    public float spead = 1;
    // Update is called once per frame
    void Update()
    {
        if (mainasu)
        {
            this.transform.Rotate(Vector3.forward, spead * Time.timeScale);
        }

        if (!mainasu)
        {
            this.transform.Rotate(Vector3.forward, -spead * Time.timeScale);
        }
    }
}
