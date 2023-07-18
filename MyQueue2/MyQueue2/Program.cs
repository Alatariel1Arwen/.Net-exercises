using FixExercise;

var myQueueInteger = new MyQueue<int>(10);

myQueueInteger.Enqueue(1);
myQueueInteger.Enqueue(2);
myQueueInteger.Enqueue(3);
myQueueInteger.Enqueue(4);
myQueueInteger.Enqueue(5);
myQueueInteger.Enqueue(6);

int dequeuedItem = myQueueInteger.Dequeue();
Console.WriteLine(dequeuedItem);

int peekedItem = myQueueInteger.Peek();
Console.WriteLine(peekedItem);


var myQueueString = new MyQueue<string>(10);

myQueueString.Enqueue("Monica");
myQueueString.Enqueue("Chandler");
myQueueString.Enqueue("Ross");
myQueueString.Enqueue("Rachel");
myQueueString.Enqueue("Joey");
myQueueString.Enqueue("Phoebe");

string dequeueString = myQueueString.Dequeue();
Console.WriteLine(dequeueString);

string peekedString = myQueueString.Peek();
Console.WriteLine(peekedString);

