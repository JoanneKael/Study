using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList : MonoBehaviour
{
    void Start()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddFirst(10);    //10
        list.AddLast(20);     //10, 20
        list.AddLast(30);     //10, 20, 30
        list.AddFirst(9);     //9, 10, 20, 30

        for (var node = list.First; node != null; node = node.Next)
        {
            print("�߰��� ��� : " + node.Value);
        }

        //��� ã��
        LinkedListNode<int> nodeTemp = list.Find(20);

        // ��� Ư�� ��ġ�� �߰��ϱ� ==> ���� ���� ����Ʈ
        list.AddAfter(nodeTemp, 21);
        list.AddBefore(nodeTemp, 19);

        //����
        list.Remove(10);

        //�˻�
        for (var node = list.First; node != null; node = node.Next)
        {
            print(node.Value);
        }
    }
}
