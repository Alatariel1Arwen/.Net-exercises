using FixExercise;

var myQueueInteger  = new MyQueue<int>(10);

myQueueInteger.Enqueue(1);
myQueueInteger.Enqueue(2);
myQueueInteger.Enqueue(3);
myQueueInteger.Enqueue(4);
myQueueInteger.Enqueue(5);
myQueueInteger.Enqueue(6);

myQueueInteger.Dequeue();
myQueueInteger.Peek();


var myQueueString = new MyQueue<String>(10);

myQueueString.Enqueue("Monica");
myQueueString.Enqueue("Chandler");
myQueueString.Enqueue("Ross");
myQueueString.Enqueue("Rachel");
myQueueString.Enqueue("Joey");
myQueueString.Enqueue("Phoebe");

myQueueString.Dequeue();
myQueueString.Peek();


