using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LinkedList<int> number = new LinkedList<int>();

        number.AddFirst(10); //10
        number.AddLast(20); //10, 20
        number.AddLast(30); //10, 20, 30
        number.AddFirst(9); //9, 10, 20, 30

        //노드 찾기
        LinkedListNode<int> nodeTemp = number.Find(20);

        // 노드 특정 위치에 추가하기
        number.AddAfter(nodeTemp, 21);
        number.AddBefore(nodeTemp, 19);

        //삭제
        number.Remove(10);

        //검색
        for (var node = number.First; node != null; node = node.Next)
        {
            print(node.Value);
        }
    }
}
