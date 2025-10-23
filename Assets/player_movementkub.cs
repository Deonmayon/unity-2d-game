using UnityEngine;
using UnityEngine.InputSystem;  // �� Input System ����

public class player_movementkub : MonoBehaviour
{
    public float moveSpeed = 5f;  // ��������㹡������͹���
    private Vector2 moveInput;

    // �ѧ��ѹ Start
    void Start()
    {
        // ����ա�õ�駤������� Start
    }

    // �ѧ��ѹ Update
    void Update()
    {
        // �Ѻ��� Input ���� Input System ����
        // ��Ǩ�ͺ������ W/A/S/D (���, ����, ŧ, ���)
        moveInput = new Vector2(Keyboard.current.aKey.isPressed ? -1 : (Keyboard.current.dKey.isPressed ? 1 : 0),
                                Keyboard.current.wKey.isPressed ? 1 : (Keyboard.current.sKey.isPressed ? -1 : 0));

        // ����˹觷�����Ѻ�ҡ Input 㹡������͹���
        transform.Translate(moveInput * moveSpeed * Time.deltaTime);  // �Թ仵�� Input
    }
}
