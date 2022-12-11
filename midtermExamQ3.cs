int num = 0;
int[] arr = new int[num];
do{
    Console.Write("Input the number for size of array: ");
    num = Convert.ToInt32(Console.ReadLine());
    if(num > 0){
        arr = new int[num];
        break;
    }
}while(num <= 0);

Console.WriteLine($"Input {num} elements in the array:");
for(int i = 0; i < num; i++){
    Console.Write($"element - {i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Array: ");
foreach(int i in arr){
    Console.Write(i + " ");
}
Console.WriteLine();

Console.Write("Which elements in the array are you searching?: ");
int searchElement = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < num; i++){
    if(searchElement == arr[i]){
        Console.WriteLine($"The index of {searchElement}: {i}");
    }
}


Console.Write("Replace it with what?: ");
int replaceElement = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < num; i++){
    if(searchElement == arr[i]){
        arr[i] = replaceElement;
        Console.WriteLine($"The element {searchElement} was replaced with {replaceElement}");
    }
}

Console.WriteLine("New array: ");
foreach(int i in arr){
    Console.Write(i + " ");
}