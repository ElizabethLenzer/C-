class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class Queue {
    constructor() {
        this.head = null;
        this.tail = null;
        this.length = 0;
    }

    enqueue(data) {
        let newNode = new Node(data);
        if (this.isEmpty()) {
            this.head = newNode;
            this.tail = this.head;
            return ++this.length;
        }
        this.tail.next = newNode;
        this.tail = this.tail.next
        return ++this.length;
    }

    dequeue() {
        if (!this.isEmpty()) {
            let data = this.head.data;
            this.head = this.head.next;
            this.length -= 1;
            return data;
        }
        return null;
    }

    size() {
        return this.length;
    }

    front() {
        return this.head.data;
    }

    isEmpty() {
        return this.head === null;
    }
}