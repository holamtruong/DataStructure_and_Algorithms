// CÀI ĐẶT LINKEDLIST
// Định nghĩa Node ----------------------
public class Node{
    public int data;
    public Node next;
    public Node(int d){
        data = d;
        next = null }
}

// Định nghĩa LinkedList ----------------------
class LinkedList{
    Node head;
    public void InsertFront(LinkedList list, int new_data)
    {
        Node new_node = new Node (value);
        new_node.next = list.head;
        list.head = new_node;
    }

    public void InsertLast(LinkedList list, int value){
        Node new_node = new Node (value);
        if (list.head == null){
            list.head = new_node;
            return;
        }
        Node lastNode = GetLastNode(list);
        lastNode.next = new_node;
    }

    public void InsertAfter(Node prev_node, int value){
        if (prev_node == null){
            Console.WriteLine("Cannot be null");
            return;
        }
        Node new_node = new Node (value);
        new_node.next = prev_node.next;
        prev_node.next = new_node;
    }

    public Node GetLastNode(LinkedList list)
    {
        Node temp = list.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public void DeleteNodebyKey(LinkedList list, int key){
        Node temp = list.head;
        Node prev = null;
        if (temp != null && temp.data == key) {
            list.head = temp.next;
            return;
        }
        while (temp != null && temp.data != key){
            prev = temp;
            temp = temp.next;
        }
        if (temp == null)
            return;
        prev.next = temp.next;
    }
    
     public void ReverseLinkedList(LinkedList list)
    {
        Node prev = null;
        Node current = list.head;
        Node temp = null;
        while (current != null){
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        list.head = prev;
    }
}
