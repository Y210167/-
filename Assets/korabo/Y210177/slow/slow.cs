using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        // �R���g���[���L�[��������Ă��邩�ǂ������`�F�b�N���܂��B
        if (Input.GetMouseButtonDown(1))
        {
            // �R���g���[���L�[�������ꂽ

            // �^�C���X�P�[�����X���[���[�V�����ɂ���
            Time.timeScale = 0.3f;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            // �R���g���[���L�[�������ꂽ

            // �^�C���X�P�[�������ɖ߂�
            Time.timeScale = 1.0f;
        }
    }
}
