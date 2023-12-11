using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_floor : MonoBehaviour
{
    // �_�ł̏��
    private bool isBlinking = false;
    // ���s��
    private bool Running = true;
    // ��������
    private bool isFalling = false;
    // ���̐F
    public Color originColor;
    // ���̈ʒu
    public Vector3 originPosition;
    // ���̉�]
    public Quaternion originRotation;

    private BoxCollider boxCol;

    public void Start()
    {
        // �I�u�W�F�N�g�̐F�ƈʒu���i�[
        originColor = GetComponent<Renderer>().material.color;
        originPosition = transform.position;
        originRotation = transform.rotation;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // �G�ꂽ�I�u�W�F�N�g���v���C���[����������s
        if (other.gameObject.CompareTag("Player"))
        {
            isBlinking = true;
            if (isBlinking && Running)
            {
                StartCoroutine(drop());
                Running = false;
            }
        }
            
        
    }

    IEnumerator drop()
    {
        if (isBlinking)
        {
            // ����_�ł����邩
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(i);
                GetComponent<Renderer>().material.color = Color.red;
                yield return new WaitForSeconds(0.2f);
                GetComponent<Renderer>().material.color = originColor;
                yield return new WaitForSeconds(0.2f);
                if (i == 2)
                {
                    Debug.Log("�_�ŏI��");
                    isBlinking = false;
                    isFalling = true;
                }
            }
        }

        if (isFalling)
        {
            // �_�ł��I���������s
            Debug.Log("������[");
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            boxCol = gameObject.GetComponent<BoxCollider>();
            // �L�l�}�e�B�b�N��farce�ɂ��ăI�u�W�F�N�g����������悤�ɂ���
            rigidbody.isKinematic = false;

            boxCol.enabled = false;
            // ���b��Ɍ��̈ʒu�ɖ߂���
            yield return new WaitForSeconds(10.0f);
            // �L�l�}�e�B�b�N��߂�
            rigidbody.isKinematic = true;
            transform.position = originPosition;
            transform.rotation = originRotation;
            boxCol.enabled = true;
            Running = true;
            isFalling = false;
        }
        
    }
}
