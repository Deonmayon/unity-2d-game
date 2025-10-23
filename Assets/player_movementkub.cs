using UnityEngine;
using UnityEngine.InputSystem;  // ใช้ Input System ใหม่

public class player_movementkub : MonoBehaviour
{
    public float moveSpeed = 5f;  // ความเร็วในการเคลื่อนที่
    private Vector2 moveInput;

    // ฟังก์ชัน Start
    void Start()
    {
        // ไม่มีการตั้งค่าอะไรใน Start
    }

    // ฟังก์ชัน Update
    void Update()
    {
        // รับค่า Input โดยใช้ Input System ใหม่
        // ตรวจสอบปุ่มกด W/A/S/D (ขึ้น, ซ้าย, ลง, ขวา)
        moveInput = new Vector2(Keyboard.current.aKey.isPressed ? -1 : (Keyboard.current.dKey.isPressed ? 1 : 0),
                                Keyboard.current.wKey.isPressed ? 1 : (Keyboard.current.sKey.isPressed ? -1 : 0));

        // ใช้ตำแหน่งที่ได้รับจาก Input ในการเคลื่อนที่
        transform.Translate(moveInput * moveSpeed * Time.deltaTime);  // เดินไปตาม Input
    }
}
