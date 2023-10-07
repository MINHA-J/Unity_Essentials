using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private int layerMask;

    void Start()
    {
        // 레이어 인덱스가 8인 레이어마스크 변수에 대입. Blue
        // 8만큼 Bit Shift
        layerMask = 1 << 8;
    }

    void Update()
    {
        // Screen에서 world로 Ray 발사
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // 마우스 왼쪽 버튼 클릭 시 함수 실행
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red);
                
                // Layer mask 8: Blue만 검출
                if (Physics.Raycast(ray.origin, ray.direction * 1000f, out hit, Mathf.Infinity, layerMask))
                {
                    // RaycastHit - 충돌 정보를 가져올 수 있음
                    Debug.Log("Hit Blue " + hit.collider.gameObject.name);
                }
            }
        }
    }
}
