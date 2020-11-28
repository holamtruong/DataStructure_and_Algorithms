// CÀI ĐẶT QUEUE

public class Node{
    public int number;
    public Node next;
    public Node(int value){
        number = value;
        next = null;
    }
    public Node AddLast(int value){
        Node newNode = new Node (value);
        next = newNode;
        return newNode;
    }
    public int GetValue(){
        return number;
    }
    public Node GetNext(){
        return next;
    }
}

// Định nghĩa LinkedList --------

public class LinkedList{
    public Node head;
    public Node tail;
    public LinkedList(){
        head = null;
        tail = null;
    }
    public void AddLast(int value){
        if (head == null){
            head = new Node(value);
            tail = head;
        }else
            tail = tail.AddLast(value);
    }
    public int GetHead(){
        if (head == null)
            Console.Write("LinkedList is empty");
        return head.GetValue();
    }
    public void RemoveHead(){
        if (head == null)
            Console.Write("LinkedList is empty");
        head = head.GetNext();
    }
    public bool IsEmpty(){
        return head == null;
    }
}

// Định nghĩa Queue ---------

public class Queue{
    public LinkedList list;
    public Queue(){
        list = new LinkedList ();}
    public void Enqueue(int value){
        list.AddLast(value);
    }
    public int Dequeue(){
        int value = list.GetHead();
        list.RemoveHead();
        return value;
    }
    public bool IsEmpty(){
        return list.IsEmpty();
    }
    public int Peak(){
        return list.GetHead();
    }
}
