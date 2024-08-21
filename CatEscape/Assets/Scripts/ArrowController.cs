using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float arrowDown;
    public float moveSpeed = 4f;
    public float radius = 1f;
    private Transform PlayerTrans;

    private void Start()
    {

        this.PlayerTrans = GameObject.Find("player").transform;
    }

    void Update()
    {
       


        arrowDown = -1;
        this.transform.Translate(0, arrowDown * moveSpeed, 0);
        bool isCollided = this.CheckCollsion();
        if (isCollided)
        {
            Object.Destroy(this.gameObject);
        }

        if (this.transform.position.y <= -6)
        {
            Object.Destroy(this.gameObject);
        }




    }
    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, radius);
    }

    // �浹üũ�� ���Ŀ� �浹�� �Ǿ��ٸ� true�� ��ȯ
    private bool CheckCollsion()
    {
        float distance = Vector3.Distance(PlayerTrans.position, this.transform.position);
        // float d1 = c.magnitude;
        // Vector3 c = PlayerTrans.position.y - this.transform.position.y
        // ����
        //var d2 = PlayerTrans.position.y - this.transform.position.y;

        //float d3 = Vector3.Distance(PlayerTrans.position,this.transform.position);

        // �������� ��
        PlayerController playerController = this.PlayerTrans.GetComponent<PlayerController>();

        float sumRadius = this.radius + playerController.radius;
        Debug.Log($"{distance},{sumRadius}");

        if (distance <= sumRadius)
        {
            Debug.Log("�浹�߽��ϴ�");
            return true;
        }
        else
        {
            Debug.Log("�ѵ����߽��ϴ�");
            return false;   
        }
    }

}
