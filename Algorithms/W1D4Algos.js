/*
    Pseudocode:
    create a method that returns some data from a node or null if said node does not exist
    if this.head.next == null return null
    create a runner 
    iterate through the list looking at runner.next.next
    stop when the loop hits null
    return runner.data
    */
    secondToLast() {
        if (this.head.next == null){
            return null
        }
        let runner = this.head
        while (runner.next.next != null){
            runner = runner.next
        }
        return runner.data
    }
/*
    Pseudocode:
    Similar to .contains()
    scan through the list for when runner.next.data == val
    then set runner.next to runner.next.next & return true
    if runner == null return false
    */
    removeVal(val) {
        let runner = this.head
        while (runner != null){
            if (runner.next.data == val){
                let temp = runner.next
                temp.next = null
                runner.next = runner.next.next
                return temp
            }
        }
        return null
    }
/*
    Pseudocode:
    create a method that looks through a list and inserts a node before a node with given data, returning the ndoe that was added
    run through the list, searching for the target (runner.next.data)
    create a variable to hold the old runner.next
    set runner.next to a new node with newVal as its data
    set runner.next.next to the old runner.next
    return runner.next
    return null outside of the loop
    */
    prepend(newVal, targetVal) {
        let runner = this.head
        while (runner != null){
            if (runner.next.data == targetVal){
                const link = runner.next
                runner.next = new Node(newVal)
                runner.next.next = link
                return runner.next
            }
            runner = runner.next
        }
        return null
    }