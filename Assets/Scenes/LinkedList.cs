using System;

public class LinkedList_Study<T>
{
    public T Data { get; set; }
    public LinkedList_Study<T> Next { get; set; }
    public LinkedList_Study(T data)
    {
        this.Data = data;
        this.Next = null;
    }

    private LinkedList_Study<T> head;

    public void Add(LinkedList_Study<T> newNode) // �� ��带 �߰�.
    {
        if (head == null) head = newNode; //����Ʈ�� ��� ���� �� head�� �� ��带 �Ҵ�.
        else // ����Ʈ�� ������� ���� ��.
        {
            var current = head;
            while (current != null && current.Next != null)  // ������ ���(Tail)�� �̵��Ͽ� �߰�.
                current = current.Next;
            current.Next = newNode;
        }
    }

    public void AddAfter(LinkedList_Study<T> current, LinkedList_Study<T> newNode) //�� ��带 �߰��� ����.
    {
        if (head == null || current == null || newNode == null)
            throw new InvalidOperationException();
        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void Remove(LinkedList_Study<T> removeNode) // Ư�� ��带 ����.
    {
        if (head == null || removeNode == null) return;
        if (removeNode == head)
        {
            head = head.Next;
            removeNode = null;
        }
        else
        {
            var current = head;
            while (current != null && current.Next != removeNode) current = current.Next;
            if (current != null)
            {
                current.Next = removeNode.Next;
                removeNode = null;
            }
        }
    }

    public LinkedList_Study<T> GetNode(int index) // ������ ��ġ�� �ִ� ��带 ��ȯ.
    {
        var current = head;
        for (int i = 0; i < index && current != null; i++)
        {
            current = current.Next;
        }
        return current;
    }

    public int Count() // head���� ������ ������ �̵��ϸ鼭 ī��Ʈ ����(��尡 � �ִ���)
    {
        int cnt = 0;
        var current = head;
        while (current != null)
        {
            cnt++;
            current = current.Next;
        }
        return cnt;
    }
}