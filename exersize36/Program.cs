void exer36() {

    Random rnd = new Random();
    int[] array = new int[rnd.Next(1, 11)];
    int sum = 0;

    for (int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(-99, 100);
        if (i % 2 != 0) {
            sum += array[i];
        }
    }


    Console.WriteLine("Полученный массив:" + "[{0}]", string.Join(", ", array));
    Console.WriteLine("Сумма чисел на нечетных позициях:" + sum);
}

exer36();
