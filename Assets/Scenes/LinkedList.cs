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
            print("추가한 노드 : " + node.Value);
        }

        //노드 찾기
        LinkedListNode<int> nodeTemp = list.Find(20);

        // 노드 특정 위치에 추가하기 ==> 이중 연결 리스트
        list.AddAfter(nodeTemp, 21);
        list.AddBefore(nodeTemp, 19);

        //삭제
        list.Remove(10);

        //검색
        for (var node = list.First; node != null; node = node.Next)
        {
            print(node.Value);
        }
    }
}
