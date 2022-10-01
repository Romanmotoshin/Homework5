void exer34() {

    Random rnd = new Random();
    int[] array = new int[rnd.Next(1, 11)];
    int count = 0;

    for (int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(100, 1000);
        if (array[i] % 2 == 0) {
            count++;
        }
    }


    Console.WriteLine("Полученный массив:" + "[{0}]", string.Join(", ", array));
    Console.WriteLine("Количество четных чисел в массиве:" + count);
}

exer34();
