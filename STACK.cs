// CÀI ĐẶT STACK
public class Node{
    public int number;
    public Node next;
    public Node(int value){
        number = value;
        next = null;
    }
    public Node AddHead(int value){
        Node newNode = new Node(value);
        newNode.next = this;
        return newNode;
    }
    public int GetValue(){
        return number;
    }
    public Node GetNext(){
        return next;
    }
}
// Định nghĩa LinkedList ----------------------
public class LinkedList
{
    public Node head;
    public Node tail;
    public LinkedList(){
        head = null; tail = null;
    }
    public void AddHead(int value){
        if (head == null){
            head = new Node(value);
            tail = head;
        }else
            head = head.AddHead(value);
    }
    public int GetHead(){
        if (head == null)
            Console.WriteLine("LinkedList empty");
        return head.GetValue();
    }
    public void RemoveHead(){
        if (head == null)
            Console.WriteLine("LinkedList empty");
        head = head.GetNext();
    }
    public bool IsEmpty(){
        return head == null;  
    } 
}

// Định nghĩa Stack ----------------------
public class Stack{
    public LinkedList list;
    public Stack(){
        list = new LinkedList();
    }
    public void Push(int value){
        list.AddHead(value);
    }
    public int Pop(){
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
