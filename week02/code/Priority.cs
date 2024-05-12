public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue five items two of which have the same value
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("School", 4);
        priorityQueue.Enqueue("Work", 3);
        priorityQueue.Enqueue("Church", 5);
        priorityQueue.Enqueue("Family", 5);
        priorityQueue.Enqueue("Friends", 3);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }


        // Defect(s) Found: The Dequeue functions doesn't remove items from the queue

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with multiple priorities and return them in priority order
        // Expected Result: Arsenal,Aston Villa,Liverpool,Southampton,Man City,Chelsea
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Man City", 1);
        priorityQueue.Enqueue("Arsenal", 3);
        priorityQueue.Enqueue("Chelsea", 1);
        priorityQueue.Enqueue("Liverpool", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("Aston Villa", 3);
        priorityQueue.Enqueue("Southampton", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        //- The Deque method is not returning the correct values
        Console.WriteLine("---------");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Items with the same priority should be returned in the order they entered the queue
        // Expected Result: Avocado, Banana, Orange, Guava, Peaches
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Guava", 1);
        priorityQueue.Enqueue("Peaches", 1);
        priorityQueue.Enqueue("Avocado", 3);
        priorityQueue.Enqueue("Banana", 3);
        priorityQueue.Enqueue("Orange", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        // The function is returning highest prioity , not the first one to enter the queue
        Console.WriteLine("---------");
    
    // Test 4
    // Scenario: Calling the  dequeue  method from an  empty list will return an error message
    // Expected Result: The queue is empty.
    Console.WriteLine("Test 4");
    priorityQueue = new PriorityQueue();
    Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        // Pass. calling Dequeue method on an empty queue will return an error message
    Console.WriteLine("---------");
}


}